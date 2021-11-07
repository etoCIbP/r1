using System;

namespace r1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число C");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число L");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число L");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число L");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число L");
            double e = double.Parse(Console.ReadLine());

            double y1 = Math.Sqrt(Math.Sin(b * m + Math.Cos(n * x)));
            double y2 = Math.Sqrt(b * m) - Math.Sin(x);
            double y3 = Math.Sqrt(Math.Sqrt(Math.Pow(e, Math.Abs(Math.Cos(x))))) + Math.Sqrt(Math.Abs(b * m * x));

            Console.WriteLine($"y1= {y1}   " + $"y2= {y2}   " + $"y3= {y3}   ");
        }
    }
}
