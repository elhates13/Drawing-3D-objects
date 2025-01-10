using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Tao.OpenGl;
using System.Drawing;
using System.Security.Cryptography;
using System.Reflection;

namespace Geometry
{
    public partial class MainForm : Form
    {
        private List<Point> points = new List<Point>();                                                           
        private List<LineSegment> sceneLines = new List<LineSegment>();
        private List<RationalBezierCurve> sceneCurves = new List<RationalBezierCurve>();
        private List<RationalBezierSurface> sceneSurfaces = new List<RationalBezierSurface>();
        private Timer rotationTimer; // Таймер для вращения

        private bool fileLoaded = false;
        private bool isRotating = false; // Флаг активации вращения
        private float rotationAngle = 0.0f; // Угол текущего поворота
        private float rotationSpeed = 8.0f; // Скорость вращения

        public MainForm()
        {
            InitializeComponent();
            OpenGL_Painter.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_POINT_SIZE);

            rotationTimer = new Timer();
            rotationTimer.Interval = 30;
            rotationTimer.Tick += (sender, e) => RotateObject();
        }

        private void OpenGL_Painter_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(0, 0, 0);                                                //Камера
            Gl.glOrtho(-1, 1, -1, 1, -100, 10);

            RenderScene();
        }

        private void ClearScene()
        {
            points.Clear();
            sceneLines.Clear();
            sceneCurves.Clear();
            sceneSurfaces.Clear();
            rotationTimer.Stop();
        }

        private void RenderScene()
        {
            foreach (var segment in sceneLines)
            {
                var point1 = segment.StartPoint;
                var point2 = segment.EndPoint;

                Gl.glBegin(Gl.GL_LINES);

                Gl.glColor3f(0.0f, 1.0f, 0.0f);  // Зеленый для прямых
                Gl.glVertex3f(point1.X / point1.H, point1.Y / point1.H, point1.Z / point1.H);
                Gl.glVertex3f(point2.X / point2.H, point2.Y / point2.H, point2.Z / point2.H);
                Gl.glTranslatef(0, 0, 0);
                Gl.glEnd();
            }

            foreach (var curve in sceneCurves)
            {
                var curvePoints = curve.GetCurvePoints();

                Gl.glBegin(Gl.GL_LINE_STRIP);
                Gl.glColor3f(1.0f, 0.0f, 0.0f); // Красный для кривых

                foreach (var point in curvePoints)
                {
                    Gl.glVertex3f(point.X / point.H, point.Y / point.H, point.Z / point.H);
                }

                Gl.glTranslatef(0, 0, 0);
                Gl.glEnd();

                //Для проверки контрольных точек куска поверхности при вписывании

                //foreach (var point in curve.ControlPoints)
                //{
                //    Gl.glColor3f(0.0f, 0.0f, 0.0f);
                //    Gl.glPointSize(8.0f);
                //    Gl.glBegin(Gl.GL_POINTS);
                //    Gl.glVertex3f(point.X / point.H, point.Y / point.H, point.Z / point.H);
                //    Gl.glEnd();
                //}
                //Gl.glEnd();
                //Gl.glFlush();
            }

            foreach (var surface in sceneSurfaces)
            {

                var (points, lines) = surface.GetSurfaceMesh();
                Gl.glBegin(Gl.GL_LINES);
                Gl.glColor3f(0.0f, 0.0f, 1.0f); // Синий для куска поверхности
                foreach (var line in lines)
                {
                    var point1 = points[line.Item1];
                    var point2 = points[line.Item2];

                    Gl.glVertex3f(point1.X / point1.H, point1.Y / point1.H, point1.Z / point1.H);
                    Gl.glVertex3f(point2.X / point2.H, point2.Y / point2.H, point2.Z / point2.H);
                }
                Gl.glEnd();

                //Для проверки контрольных точек куска поверхности при вписывании

                //foreach (var point in surface.ControlPoints)
                //{
                //    Gl.glColor3f(0.0f, 0.0f, 0.0f);
                //    Gl.glPointSize(8.0f);
                //    Gl.glBegin(Gl.GL_POINTS);
                //    Gl.glVertex3f(point.X / point.H, point.Y / point.H, point.Z / point.H);
                //    Gl.glEnd();
                //}
                //Gl.glEnd();
                //Gl.glFlush();
            }
        }

        private void ApplyTransformationForLines(float[,] TransformationMatrix)
        {
            for (int i = 0; i < sceneLines.Count; i++)
            {
                var line = sceneLines[i];

                line.StartPoint = Point.TransformPoint(line.StartPoint, TransformationMatrix);
                line.EndPoint = Point.TransformPoint(line.EndPoint, TransformationMatrix);

                sceneLines[i] = line;
            }
        }

        private void ApplyTransformationForCurves(float[,] transformationMatrix)
        {
            for (int i = 0; i < sceneCurves.Count; i++)
            {
                var curve = sceneCurves[i];

                for (int j = 0; j < curve.ControlPoints.Count; j++)
                {
                    var transformedPoint = Point.TransformPoint(curve.ControlPoints[j], transformationMatrix);
                    curve.ControlPoints[j] = transformedPoint;
                }

                sceneCurves[i] = curve;
            }
        }

        private void ApplyTransformationForSurfaces(float[,] transformationMatrix)
        {
            for (int i = 0; i < sceneSurfaces.Count; i++)
            {
                var surface = sceneSurfaces[i];
                for (int j = 0; j < surface.ControlPoints.Count; j++)
                {
                    var transformedPoint = Point.TransformPoint(surface.ControlPoints[j], transformationMatrix);
                    surface.ControlPoints[j] = transformedPoint;
                }
                sceneSurfaces[i] = surface;
            }
        }

        private void ApplyTransformationBasedOnObjectType(float[,] transformationMatrix)
        {
            if (sceneLines.Count > 0) ApplyTransformationForLines(transformationMatrix);
            else if (sceneCurves.Count > 0) ApplyTransformationForCurves(transformationMatrix);
            else if (sceneSurfaces.Count > 0) ApplyTransformationForSurfaces(transformationMatrix);
            OpenGL_Painter.Invalidate();
        }

        private void LoadSceneFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                bool isPointSection = true;

                foreach (var line in lines)
                {
                    var values = line.Split(' ');
                    if (values.Length == 0) continue;
                    if (isPointSection)
                    {
                        if (values.Length == 4)
                        {
                            float x = float.Parse(values[0]);
                            float y = float.Parse(values[1]);
                            float z = float.Parse(values[2]);
                            float h = float.Parse(values[3]);

                            points.Add(new Point(x, y, z, h));
                        }
                        else if (values.Length == 8)
                        {
                            float x1 = float.Parse(values[0]);
                            float y1 = float.Parse(values[1]);
                            float z1 = float.Parse(values[2]);
                            float h1 = float.Parse(values[3]);
                            float x2 = float.Parse(values[4]);
                            float y2 = float.Parse(values[5]);
                            float z2 = float.Parse(values[6]);
                            float h2 = float.Parse(values[7]);

                            var point1 = new Point(x1, y1, z1, h1);
                            var point2 = new Point(x2, y2, z2, h2);

                            points.Add(point1);
                            points.Add(point2);

                            sceneLines.Add(new LineSegment(point1, point2));
                        }
                        else if(values.Length == 1)
                        {
                            isPointSection = false;
                        }
                    }
                    if (!isPointSection && values.Length == 2)
                    {
                        int Index1 = int.Parse(values[0]);
                        int Index2 = int.Parse(values[1]);

                        var point1 = points[Index1];
                        var point2 = points[Index2];

                        sceneLines.Add(new LineSegment(point1, point2));
                    }
                    if (!isPointSection && values.Length == 4)
                    {
                        int index1 = int.Parse(values[0]);
                        int index2 = int.Parse(values[1]);
                        int index3 = int.Parse(values[2]);
                        int index4 = int.Parse(values[3]);

                        var pointList = new List<Point>
                            {
                                points[index1],
                                points[index2],
                                points[index3],
                                points[index4]
                            };

                        var bezierCurve = new RationalBezierCurve(pointList);
                        sceneCurves.Add(bezierCurve);
                    }
                    if (!isPointSection && values.Length == 16)
                    {
                        List<Point> controlPoints = new List<Point>();

                        for (int i = 0; i < 16; i++)
                        {
                            int pointIndex = int.Parse(values[i]);
                            if (pointIndex < 0 || pointIndex >= points.Count)
                            {
                                throw new Exception($"Недопустимый индекс точки: {pointIndex}");
                            }
                            controlPoints.Add(points[pointIndex]);
                        }
                        var surface = new RationalBezierSurface(controlPoints);
                        sceneSurfaces.Add(surface);
                    }

                }
                fileLoaded = true;
                FileLoadingSuccesful(fileLoaded);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке файла: " + ex.Message);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ClearScene();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл сцены";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadSceneFromFile(filePath);
            }
            StandartParameters();
            RenderScene();
            OpenGL_Painter.Invalidate();
        }


        private void CentreLines()
        {
            float maxX = float.MinValue, maxY = float.MinValue, minX = float.MaxValue, minY = float.MaxValue, trX, trY, sc;

            for (int i = 0; i < sceneLines.Count; i++)
            {
                var line = sceneLines[i];

                if (maxX < line.StartPoint.X / line.StartPoint.H) maxX = line.StartPoint.X / line.StartPoint.H;
                if (maxY < line.StartPoint.Y / line.StartPoint.H) maxY = line.StartPoint.Y / line.StartPoint.H;
                if (minX > line.StartPoint.X / line.StartPoint.H) minX = line.StartPoint.X / line.StartPoint.H;
                if (minY > line.StartPoint.Y / line.StartPoint.H) minY = line.StartPoint.Y / line.StartPoint.H;

                if (maxX < line.EndPoint.X / line.EndPoint.H) maxX = line.EndPoint.X / line.EndPoint.H;
                if (maxY < line.EndPoint.Y / line.EndPoint.H) maxY = line.EndPoint.Y / line.EndPoint.H;
                if (minX > line.EndPoint.X / line.EndPoint.H) minX = line.EndPoint.X / line.EndPoint.H;
                if (minY > line.EndPoint.Y / line.EndPoint.H) minY = line.EndPoint.Y / line.EndPoint.H;
            }

            trX = (maxX + minX) / 2;
            trY = (maxY + minY) / 2;

            if ((maxX - minX) / 2 > (maxY - minY) / 2) sc = 2 / (maxX - minX);
            else sc = 2 / (maxY - minY);

            ApplyTransformationForLines(Matrixs.GetTranslationMatrix(-trX, -trY, 0));
            ApplyTransformationForLines(Matrixs.GetScalingMatrix(sc, sc, sc));
            OpenGL_Painter.Invalidate();
        }

        private void CentreCurves()
        {
            float maxX = float.MinValue, maxY = float.MinValue, minX = float.MaxValue, minY = float.MaxValue, trX, trY, sc;

            for (int i = 0; i < sceneCurves.Count; i++)
            {
                var line = sceneCurves[i];
                for (int j = 0; j < 3; j++)
                {
                    
                    if (maxX < line.ControlPoints[j].X / line.ControlPoints[j].H) maxX = line.ControlPoints[j].X / line.ControlPoints[j].H;
                    if (maxY < line.ControlPoints[j].Y / line.ControlPoints[j].H) maxY = line.ControlPoints[j].Y / line.ControlPoints[j].H;
                    if (minX > line.ControlPoints[j].X / line.ControlPoints[j].H) minX = line.ControlPoints[j].X / line.ControlPoints[j].H;
                    if (minY > line.ControlPoints[j].Y / line.ControlPoints[j].H) minY = line.ControlPoints[j].Y / line.ControlPoints[j].H;
                    
                    /*
                    if (maxX < line.ControlPoints[j].X) maxX = line.ControlPoints[j].X;
                    if (maxY < line.ControlPoints[j].Y) maxY = line.ControlPoints[j].Y;
                    if (minX > line.ControlPoints[j].X) minX = line.ControlPoints[j].X;
                    if (minY > line.ControlPoints[j].Y) minY = line.ControlPoints[j].Y;
                    */
                }
            }

            trX = (maxX + minX) / 2;
            trY = (maxY + minY) / 2;

            if ((maxX - minX) / 2 > (maxY - minY) / 2) sc = 2 / (maxX - minX);
            else sc = 2 / (maxY - minY);

            ApplyTransformationForCurves(Matrixs.GetTranslationMatrix(-trX, -trY, 0));
            ApplyTransformationForCurves(Matrixs.GetScalingMatrix(sc, sc, sc));
            OpenGL_Painter.Invalidate();
        }

        private void CentreSurfaces()
        {
            float maxX = float.MinValue, maxY = float.MinValue, minX = float.MaxValue, minY = float.MaxValue, trX, trY, sc;

            for (int i = 0; i < sceneSurfaces.Count; i++)
            {
                var surface = sceneSurfaces[i];
                for (int j = 0; j < surface.ControlPoints.Count; j++)
                {
                    float x = surface.ControlPoints[j].X / surface.ControlPoints[j].H;
                    float y = surface.ControlPoints[j].Y / surface.ControlPoints[j].H;

                    if (maxX < x) maxX = x;
                    if (maxY < y) maxY = y;
                    if (minX > x) minX = x;
                    if (minY > y) minY = y;
                }
            }

            trX = (maxX + minX) / 2;
            trY = (maxY + minY) / 2;

            if ((maxX - minX) / 2 > (maxY - minY) / 2) sc = 2 / (maxX - minX);
            else sc = 2 / (maxY - minY);

            ApplyTransformationForSurfaces(Matrixs.GetTranslationMatrix(-trX, -trY, 0));
            ApplyTransformationForSurfaces(Matrixs.GetScalingMatrix(sc, sc, sc));

            OpenGL_Painter.Invalidate();
        }

        private void CentreButton_Click(object sender, EventArgs e)
        {
            if (sceneLines.Count > 0) CentreLines();
            else if (sceneCurves.Count > 0) CentreCurves();
            else if (sceneSurfaces.Count > 0) CentreSurfaces();
        }

        private void ButtonTranslateX_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetTranslationMatrix((float)NumericUpDownTranslateX.Value, 0, 0));
        }

        private void ButtonTranslateY_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetTranslationMatrix(0, (float)NumericUpDownTranslateY.Value, 0));
        }

        private void ButtonTranslateZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetTranslationMatrix(0, 0, (float)NumericUpDownTranslateZ.Value));
        }

        private void ButtonScaleX_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetScalingMatrix((float)NumericUpDownScaleX.Value, 1, 1));
        }

        private void ButtonScaleY_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetScalingMatrix(1, (float)NumericUpDownScaleY.Value, 1));
        }

        private void ButtonScaleZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetScalingMatrix(1, 1, (float)NumericUpDownScaleZ.Value));
        }

        private void ButtonScaleXYZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetScalingMatrix((float)NumericUpDownScaleXYZ.Value, (float)NumericUpDownScaleXYZ.Value, (float)NumericUpDownScaleXYZ.Value));
        }

        private void ButtonRotateX_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetRotationXMatrix((float)NumericUpDownRotateX.Value));
        }

        private void ButtonRotateY_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetRotationYMatrix((float)NumericUpDownRotateY.Value));
        }

        private void ButtonRotateZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetRotationZMatrix((float)NumericUpDownRotateZ.Value));
        }

        private void ButtonShearX_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetShearMatrixX((float)NumericUpDownShearXY.Value, (float)NumericUpDownShearXZ.Value));
        }

        private void ButtonShearY_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetShearMatrixY((float)NumericUpDownShearYX.Value, (float)NumericUpDownShearYZ.Value));
        }

        private void ButtonShearZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetShearMatrixZ((float)NumericUpDownShearZX.Value, (float)NumericUpDownShearZY.Value));
        }

        private void ButtonOPPX_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetOPPMatrixX((float)NumericUpDownOPPX.Value));
        }

        private void ButtonOPPY_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetOPPMatrixY((float)NumericUpDownOPPY.Value));
        }

        private void ButtonOPPZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetOPPMatrixZ((float)NumericUpDownOPPZ.Value));
        }

        private void ButtonOPPXYZ_Click(object sender, EventArgs e)
        {
            ApplyTransformationBasedOnObjectType(Matrixs.GetOPPMatrix((float)NumericUpDownOPPXYZ.Value, (float)NumericUpDownOPPXYZ.Value, (float)NumericUpDownOPPXYZ.Value));
        }
        private void ScaleСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ScaleСheckBox.Checked)
            {
                NumericUpDownScaleX.Visible = true;
                NumericUpDownScaleY.Visible = true;
                NumericUpDownScaleZ.Visible = true;
                ScaleLabel1.Visible = true;
                ButtonScaleX.Visible = true;
                ButtonScaleY.Visible = true;
                ButtonScaleZ.Visible = true;
                ButtonScaleXYZ.Visible = false;
                ScaleLabel2.Visible = false;
                NumericUpDownScaleXYZ.Visible = false;
            }
            else
            {
                NumericUpDownScaleX.Visible = false;
                NumericUpDownScaleY.Visible = false;
                NumericUpDownScaleZ.Visible = false;
                ButtonScaleX.Visible = false;
                ButtonScaleY.Visible = false;
                ButtonScaleZ.Visible = false;
                ScaleLabel1.Visible = false;
                ButtonScaleXYZ.Visible = true;
                ScaleLabel2.Visible = true;
                NumericUpDownScaleXYZ.Visible = true;
            }
        }

        private void OPPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!OPPCheckBox.Checked)
            {
                NumericUpDownOPPX.Visible = true;
                NumericUpDownOPPY.Visible = true;
                NumericUpDownOPPZ.Visible = true;
                ButtonOPPX.Visible = true;
                ButtonOPPY.Visible = true;
                ButtonOPPZ.Visible = true;
                ButtonOPPXYZ.Visible = false;
                OPPLabel1.Visible = true;
                OPPLabel2.Visible = false;
                NumericUpDownOPPXYZ.Visible = false;
            }
            else
            {
                NumericUpDownOPPX.Visible = false;
                NumericUpDownOPPY.Visible = false;
                NumericUpDownOPPZ.Visible = false;
                ButtonOPPX.Visible = false;
                ButtonOPPY.Visible = false;
                ButtonOPPZ.Visible = false;
                ButtonOPPXYZ.Visible = true;
                OPPLabel1.Visible = false;
                OPPLabel2.Visible = true;
                NumericUpDownOPPXYZ.Visible = true;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void StandartParameters()
        {
            NumericUpDownTranslateX.Value = 0;
            NumericUpDownTranslateY.Value = 0;
            NumericUpDownTranslateZ.Value = 0;

            NumericUpDownScaleX.Value = 1;
            NumericUpDownScaleY.Value = 1;
            NumericUpDownScaleZ.Value = 1;
            NumericUpDownScaleXYZ.Value = 1;

            NumericUpDownRotateX.Value = 0;
            NumericUpDownRotateY.Value = 0;
            NumericUpDownRotateZ.Value = 0;

            NumericUpDownShearXY.Value = 0;
            NumericUpDownShearXZ.Value = 0;
            NumericUpDownShearYX.Value = 0;
            NumericUpDownShearYZ.Value = 0;
            NumericUpDownShearZX.Value = 0;
            NumericUpDownShearZY.Value = 0;

            NumericUpDownOPPX.Value = 1;
            NumericUpDownOPPY.Value = 1;
            NumericUpDownOPPZ.Value = 1;
            NumericUpDownOPPXYZ.Value = 1;
        }

        private void FileLoadingSuccesful(bool FirstFile)
        {
            NumericUpDownTranslateX.Enabled = FirstFile;
            NumericUpDownTranslateY.Enabled = FirstFile;
            NumericUpDownTranslateZ.Enabled = FirstFile;

            NumericUpDownScaleX.Enabled = FirstFile;
            NumericUpDownScaleY.Enabled = FirstFile;
            NumericUpDownScaleZ.Enabled = FirstFile;
            NumericUpDownScaleXYZ.Enabled = FirstFile;

            NumericUpDownRotateX.Enabled = FirstFile;
            NumericUpDownRotateY.Enabled = FirstFile;
            NumericUpDownRotateZ.Enabled = FirstFile;

            NumericUpDownShearXY.Enabled = FirstFile;
            NumericUpDownShearXZ.Enabled = FirstFile;
            NumericUpDownShearYX.Enabled = FirstFile;
            NumericUpDownShearYZ.Enabled = FirstFile;
            NumericUpDownShearZX.Enabled = FirstFile;
            NumericUpDownShearZY.Enabled = FirstFile;

            NumericUpDownOPPX.Enabled = FirstFile;
            NumericUpDownOPPY.Enabled = FirstFile;
            NumericUpDownOPPZ.Enabled = FirstFile;
            NumericUpDownOPPXYZ.Enabled = FirstFile;

            CentreButton.Enabled = FirstFile;
        }

        private void CurveSurface_Click(object sender, EventArgs e)
        {
            if (sceneCurves.Count > 0) CreatePartialSurface(sceneCurves[0]);
            else MessageBox.Show("Сначала добавьте кривую.");
        }

        private void StartRotating_Click(object sender, EventArgs e)
        {
            isRotating = true;
            if (!IsObjectOutOfBounds()) rotationTimer.Start();
        }

        private void EndRotating_Click(object sender, EventArgs e)
        {
            isRotating = false;
            rotationTimer.Stop();
        }

        private void CreatePartialSurface(RationalBezierCurve originalCurve)
        {
            var originalPoints = originalCurve.ControlPoints;
            var rotatedPoints = new List<Point>();

            foreach (var point in originalPoints)
            {
                rotatedPoints.Add(Point.TransformPoint(point, Matrixs.GetRotationZMatrix(90)));
            }

            var middleRow1 = new List<Point>();
            var middleRow2 = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                middleRow1.Add(new Point(
                    (originalPoints[i].X * 2 + rotatedPoints[i].X) / 3,
                    (originalPoints[i].Y * 2 + rotatedPoints[i].Y) / 3,
                    (originalPoints[i].Z * 2 + rotatedPoints[i].Z) / 3,
                    (originalPoints[i].H * 2 + rotatedPoints[i].H) / 3
                ));

                middleRow2.Add(new Point(
                    (originalPoints[i].X + rotatedPoints[i].X * 2) / 3,
                    (originalPoints[i].Y + rotatedPoints[i].Y * 2) / 3,
                    (originalPoints[i].Z + rotatedPoints[i].Z * 2) / 3,
                    (originalPoints[i].H + rotatedPoints[i].H * 2) / 3
                ));
            }

            var controlPoints = new List<Point>();
            controlPoints.AddRange(originalPoints);
            controlPoints.AddRange(middleRow1);     
            controlPoints.AddRange(middleRow2);     
            controlPoints.AddRange(rotatedPoints);  

            var surface = new RationalBezierSurface(controlPoints);
            sceneSurfaces.Add(surface);

            sceneCurves.Clear();
            OpenGL_Painter.Invalidate();
        }

        private void RotateObject()
        {
            if (!fileLoaded || !isRotating)
                return;

            if (IsObjectOutOfBounds()) rotationSpeed = -rotationSpeed;
            rotationAngle = rotationSpeed;
            float radians = rotationAngle * (float)Math.PI / 180.0f;

            ApplyTransformationBasedOnObjectType(Matrixs.GetRotationZMatrix(radians));

            OpenGL_Painter.Invalidate();
        }
        private bool IsObjectOutOfBounds()
        {
            if (sceneLines.Count>0)
            for (int i = 0; i < sceneLines.Count; i++)
            {
                float x1 = sceneLines[i].StartPoint.X / sceneLines[i].StartPoint.H;
                float y1 = sceneLines[i].StartPoint.Y / sceneLines[i].StartPoint.H;

                float x2 = sceneLines[i].EndPoint.X / sceneLines[i].EndPoint.H;
                float y2 = sceneLines[i].EndPoint.Y / sceneLines[i].EndPoint.H;

                if (Math.Abs(x1) > 1 || Math.Abs(y1) > 1 || Math.Abs(x2) > 1 || Math.Abs(y2) > 1) return true;
            }
            else if (sceneCurves.Count > 0)
            {
                for (int i = 0; i < sceneCurves.Count; i++)
                {
                    for (int j = 0; j < sceneCurves[i].ControlPoints.Count; j++)
                    {
                        float x = sceneCurves[i].ControlPoints[j].X / sceneCurves[i].ControlPoints[j].H;
                        float y = sceneCurves[i].ControlPoints[j].Y / sceneCurves[i].ControlPoints[j].H;
                        if (Math.Abs(x) > 1 || Math.Abs(y) > 1) return true;
                    }
                }
            }
            else if (sceneSurfaces.Count > 0)
            {
                for (int i = 0; i < sceneSurfaces.Count; i++)
                {
                    for (int j = 0; j < sceneSurfaces[i].ControlPoints.Count; j++)
                    {
                        float x = sceneSurfaces[i].ControlPoints[j].X / sceneSurfaces[i].ControlPoints[j].H;
                        float y = sceneSurfaces[i].ControlPoints[j].Y / sceneSurfaces[i].ControlPoints[j].H;
                        if (Math.Abs(x) > 1 || Math.Abs(y) > 1) return true;
                    }
                }
            }
            return false;
        }
        //=============================================================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            DrawVoxelSphere(new Point(0.0f, 0.0f, 0.0f, 1), 0.5f, 0.1f, 15f); //Это надо добавить в RenderScene()
        }
        public void DrawVoxelSphere(Point center, float radius, float voxelSize, float rotationAngle)
        {


            Gl.glPushMatrix(); 
            Gl.glTranslatef(center.X, center.Y, center.Z);
            Gl.glRotatef(rotationAngle, 1.0f, 1.0f, 1.0f);
            Gl.glTranslatef(-center.X, -center.Y, -center.Z);

            int gridMinX = (int)Math.Floor((center.X - radius) / voxelSize);
            int gridMaxX = (int)Math.Ceiling((center.X + radius) / voxelSize);
            int gridMinY = (int)Math.Floor((center.Y - radius) / voxelSize);
            int gridMaxY = (int)Math.Ceiling((center.Y + radius) / voxelSize);
            int gridMinZ = (int)Math.Floor((center.Z - radius) / voxelSize);
            int gridMaxZ = (int)Math.Ceiling((center.Z + radius) / voxelSize);


            Gl.glColor3f(0.0f, 0.0f, 1.0f);


            for (int x = gridMinX; x <= gridMaxX; x++)
            {
                for (int y = gridMinY; y <= gridMaxY; y++)
                {
                    for (int z = gridMinZ; z <= gridMaxZ; z++)
                    {
                        float voxelCenterX = x * voxelSize + voxelSize / 2.0f;
                        float voxelCenterY = y * voxelSize + voxelSize / 2.0f;
                        float voxelCenterZ = z * voxelSize + voxelSize / 2.0f;


                        float distance = (float)Math.Sqrt(
                            Math.Pow(voxelCenterX - center.X, 2) +
                            Math.Pow(voxelCenterY - center.Y, 2) +
                            Math.Pow(voxelCenterZ - center.Z, 2)
                        );

                        if (distance <= radius)
                        {
                            DrawVoxel(voxelCenterX, voxelCenterY, voxelCenterZ, voxelSize);
                        }
                    }
                }
            }

            Gl.glPopMatrix(); 
        }


        private void DrawVoxel(float x, float y, float z, float size)
        {
            float halfSize = size / 2.0f;


            Gl.glBegin(Gl.GL_LINES);

            // Рёбра куба
            Gl.glVertex3f(x - halfSize, y - halfSize, z - halfSize); 
            Gl.glVertex3f(x + halfSize, y - halfSize, z - halfSize); 

            Gl.glVertex3f(x + halfSize, y - halfSize, z - halfSize);
            Gl.glVertex3f(x + halfSize, y + halfSize, z - halfSize);

            Gl.glVertex3f(x + halfSize, y + halfSize, z - halfSize);
            Gl.glVertex3f(x - halfSize, y + halfSize, z - halfSize);

            Gl.glVertex3f(x - halfSize, y + halfSize, z - halfSize);
            Gl.glVertex3f(x - halfSize, y - halfSize, z - halfSize);

            Gl.glVertex3f(x - halfSize, y - halfSize, z + halfSize); 
            Gl.glVertex3f(x + halfSize, y - halfSize, z + halfSize); 

            Gl.glVertex3f(x + halfSize, y - halfSize, z + halfSize);
            Gl.glVertex3f(x + halfSize, y + halfSize, z + halfSize);

            Gl.glVertex3f(x + halfSize, y + halfSize, z + halfSize);
            Gl.glVertex3f(x - halfSize, y + halfSize, z + halfSize);

            Gl.glVertex3f(x - halfSize, y + halfSize, z + halfSize);
            Gl.glVertex3f(x - halfSize, y - halfSize, z + halfSize);

            Gl.glVertex3f(x - halfSize, y - halfSize, z - halfSize);
            Gl.glVertex3f(x - halfSize, y - halfSize, z + halfSize);

            Gl.glVertex3f(x + halfSize, y - halfSize, z - halfSize);
            Gl.glVertex3f(x + halfSize, y - halfSize, z + halfSize);

            Gl.glVertex3f(x + halfSize, y + halfSize, z - halfSize);
            Gl.glVertex3f(x + halfSize, y + halfSize, z + halfSize);

            Gl.glVertex3f(x - halfSize, y + halfSize, z - halfSize);
            Gl.glVertex3f(x - halfSize, y + halfSize, z + halfSize);

            Gl.glEnd();
        }
    }
}