namespace SlopofaLine
{
    public class ConsoleIO
    {

        public static double GetCoordinate(string prompt)
        {
            double value;
            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Invalid input! The input must be a number.");

            } while (true);
        }
        public static void SlopeofaLine(Line line)
        {
            double x1 = line.StartPoint.X, y1 = line.StartPoint.Y, x2 = line.EndPoint.X, y2 = line.EndPoint.Y, m, divZero;
            divZero = x2 - x1;
            if (divZero != 0)
            {
                m = (y2 - y1) / (x2 - x1);
                Console.WriteLine($"The slope of a line with points ({x1},{y1}) and ({x2},{y2}) is {m}.");
            }
            else
            {
                Console.WriteLine($"A line with points ({x1},{y1}) and ({x2},{y2}) is a vertical line and has no slope.");
            }
        }
    }
}
