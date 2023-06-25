using System;

class Program
{
    static void Main(string[] args)
    {
        double x1, y1, x2, y2;

        Console.WriteLine("Podaj współrzędne punktu początkowego (x1, y1):");
        x1 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędne punktu końcowego (x2, y2):");
        x2 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + distance);
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}