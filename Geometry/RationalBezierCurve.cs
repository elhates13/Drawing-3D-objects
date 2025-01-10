using System.Collections.Generic;

namespace Geometry
{
    public class RationalBezierCurve
    {
        public List<Point> ControlPoints { get; set; }

        public RationalBezierCurve(List<Point> controlPoints)
        {
            ControlPoints = controlPoints;
        }

        public List<Point> GetCurvePoints()
        {
            List<Point> curvePoints = new List<Point>();
            float t = 0.0f;
            while (t <= 1.0)
            {
                int[] edge = { 0, 1, 2, 3 };

                float x = (1 - t) * (1 - t) * ControlPoints[edge[0]].X + 2 * t * (1 - t) * (1 - t) * ControlPoints[edge[1]].X + 2 * t * t * (1 - t) * ControlPoints[edge[2]].X + t * t * ControlPoints[edge[3]].X;
                float y = (1 - t) * (1 - t) * ControlPoints[edge[0]].Y + 2 * t * (1 - t) * (1 - t) * ControlPoints[edge[1]].Y + 2 * t * t * (1 - t) * ControlPoints[edge[2]].Y + t * t * ControlPoints[edge[3]].Y;
                float z = (1 - t) * (1 - t) * ControlPoints[edge[0]].Z + 2 * t * (1 - t) * (1 - t) * ControlPoints[edge[1]].Z + 2 * t * t * (1 - t) * ControlPoints[edge[2]].Z + t * t * ControlPoints[edge[3]].Z;
                float h = (1 - t) * (1 - t) * ControlPoints[edge[0]].H + 2 * t * (1 - t) * (1 - t) * ControlPoints[edge[1]].H + 2 * t * t * (1 - t) * ControlPoints[edge[2]].H + t * t * ControlPoints[edge[3]].H;

                curvePoints.Add(new Point(x / h, y / h, z / h, 1));

                t += 0.01f;
            }
            return curvePoints;
        }
    }
}