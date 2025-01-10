namespace Geometry
{
    public class Point
    {
        public float X, Y, Z, H;

        public Point(float x, float y, float z, float h)
        {
            X = x; Y = y; Z = z; H = h;
        }

        public static Point TransformPoint(Point point, float[,] matrix)
        {
            float newX = matrix[0, 0] * point.X + matrix[0, 1] * point.Y + matrix[0, 2] * point.Z + matrix[0, 3] * point.H;
            float newY = matrix[1, 0] * point.X + matrix[1, 1] * point.Y + matrix[1, 2] * point.Z + matrix[1, 3] * point.H;
            float newZ = matrix[2, 0] * point.X + matrix[2, 1] * point.Y + matrix[2, 2] * point.Z + matrix[2, 3] * point.H;
            float newH = matrix[3, 0] * point.X + matrix[3, 1] * point.Y + matrix[3, 2] * point.Z + matrix[3, 3] * point.H;
            return new Point(newX, newY, newZ, newH);
        }
    }
}
