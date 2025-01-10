using System;
using System.Collections.Generic;

namespace Geometry
{
    public class RationalBezierSurface
    {
        public List<Point> ControlPoints { get; set; }

        public RationalBezierSurface(List<Point> controlPoints) { ControlPoints = controlPoints; }

        
        public Point GetSurfacePoint(float u, float v)
        {
            float[] Bu = new float[4];
            float[] Bv = new float[4];
            
            Bu[0] = (1 - u) * (1 - u);
            Bu[1] = 2 * u * (1 - u) * (1 - u);
            Bu[2] = 2 * u * u * (1 - u);
            Bu[3] = u * u;

            Bv[0] = (1 - v) * (1 - v);
            Bv[1] = 2 * v * (1 - v) * (1 - v);
            Bv[2] = 2 * v * v * (1 - v);
            Bv[3] = v * v;



            float x = 0, y = 0, z = 0, h = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var p = ControlPoints[i * 4 + j];
                    x += Bu[i] * Bv[j] * p.X;
                    y += Bu[i] * Bv[j] * p.Y;
                    z += Bu[i] * Bv[j] * p.Z;
                    h += Bu[i] * Bv[j] * p.H;
                }
            }
            return new Point(x, y, z, h);
        }

        public (List<Point>, List<(int, int)>) GetSurfaceMesh()
        {
            List<Point> surfacePoints = new List<Point>();
            List<(int, int)> meshLines = new List<(int, int)>();

            int resolution = 30; // Частота сетки
            for (int i = 0; i <= resolution; i++)
            {
                float u = i / (float)resolution;
                for (int j = 0; j <= resolution; j++)
                {
                    float v = j / (float)resolution;
                    surfacePoints.Add(GetSurfacePoint(u, v));

                    int currentIndex = i * (resolution + 1) + j;
                    if (j > 0) meshLines.Add((currentIndex - 1, currentIndex));

                    if (i > 0) meshLines.Add((currentIndex - (resolution + 1), currentIndex));
                }
            }
            return (surfacePoints, meshLines);
        }
    }
}
