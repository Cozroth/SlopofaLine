namespace SlopofaLine
{
    public class Line
    {
        private Point _startPoint;
        private Point _endPoint;
        public Line(Point startPoint, Point endpoint)
        {
            _startPoint = startPoint;
            _endPoint = endpoint;
        }
        public Point StartPoint { get { return _startPoint; } }
        public Point EndPoint { get { return _endPoint; } }
    }
}
