namespace Geometry
{
    public class LineSegment
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public LineSegment(Point start, Point end)
        {
            StartPoint = start;
            EndPoint = end;
        }
    }
}
