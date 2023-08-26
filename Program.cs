using SlopofaLine;
class Program
{
    static void Main(string[] args)
    {
        double x, y;
        Point startPoint, endPoint;
        Line line;

        Console.WriteLine("Start Point");
        x = ConsoleIO.GetCoordinate("Enter X Coordinate: ");
        y = ConsoleIO.GetCoordinate("Enter Y Coordinate: ");
        startPoint = new Point(x, y);


        Console.WriteLine("\nEnd Point");
        x = ConsoleIO.GetCoordinate("Enter X Coordinate: ");
        y = ConsoleIO.GetCoordinate("Enter Y Coordinate: ");
        endPoint = new Point(x, y);

        line = new Line(startPoint, endPoint);
        ConsoleIO.SlopeofaLine(line);
    }
}
