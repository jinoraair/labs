using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первый параметр функции: ");
        double parametr1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второй параметр функции: ");
        double parametr2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третий параметр функции: ");
        double parametr3 = Convert.ToDouble(Console.ReadLine());
        ThreeParam(parametr1, parametr2, parametr3);
    }
    static void ThreeParam(double p1, double p2, double p3)
    {
        p1 = (p2 + p3) / 2;
        Console.WriteLine($"Значение первого параметра получилось равным {p1}.");
        p2 = (p1 + p3) / 2;
        Console.WriteLine($"Значение второго параметра получилось равным {p2}.");
        p3 = (p1 + p2) / 2;
        Console.WriteLine($"Значение третьего параметра получилось равным {p3}.");
    }
}