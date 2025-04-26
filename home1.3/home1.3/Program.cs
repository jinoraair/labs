using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a*x^2 + b*x + c = 0");

        Console.WriteLine("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveEquation(a, b, c);
    }

    static void SolveEquation(double A, double B, double C)
    {
        if (A == 0)
        {
            if (B == 0)
            {
                if (C == 0)
                {
                    Console.WriteLine("Все числа являются корнями.");
                }
                else
                {
                    Console.WriteLine("Нет решений: уравнение является противоречием.");
                }
            }
            else
            {
                double x = -C / B;
                Console.WriteLine($"Линейное уравнение: единственный корень x = {x}");
            }
        }
        else
        {
            double d = Math.Pow(B, 2) - 4 * A * C;
            if (d > 0)
            {
                double x1 = (-B + Math.Sqrt(d)) / (2 * A);
                double x2 = (-B - Math.Sqrt(d)) / (2 * A);
                Console.WriteLine($"2 корня: x1 = {x1}; x2 = {x2}");
            }
            else if (d == 0)
            {
                double x = -B / (2 * A);
                Console.WriteLine($"1 корень: x = {x}");
            }
            else
            {
                Console.WriteLine("Корней нет.");
            }
        }
    }
}