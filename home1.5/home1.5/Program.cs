using System;

class Program
{
    static void Main()
    {
        double a = GetValidInput("Сторона AB: ");
        double b = GetValidInput("Сторона BC: ");
        double c = GetValidInput("Сторона CA: ");
        double a1 = GetValidInput("Сторона A1B1: ");
        double b1 = GetValidInput("Сторона B1C1: ");
        double c1 = GetValidInput("Сторона C1A1: ");

        Similar(a, b, c, a1, b1, c1);
    }

    static double GetValidInput(string message)
    {
        double result = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            isValidInput = double.TryParse(userInput, out result) && result > 0;

            if (!isValidInput)
            {
                Console.WriteLine("Ошибка! Введите корректное положительное число:");
            }
        }
        return result;
    }
//проверка введенных сторон треугольника на корректность
    static bool IsValidTriangle(double A, double B, double C)
    {
        return (A + B > C) && (A + C > B) && (B + C > A);
    }

    static void Similar(double A, double B, double C, double A1, double B1, double C1)
    {
        if (IsValidTriangle(A, B, C) && IsValidTriangle(A1, B1, C1))
        {
            double arcosAB = Math.Acos((A * A + B * B - C * C) / (2 * A * B));
            double arcosAC = Math.Acos((A * A + C * C - B * B) / (2 * A * C));
            double arcosBC = Math.Acos((B * B + C * C - A * A) / (2 * B * C));
            double arcosAB1 = Math.Acos((A1 * A1 + B1 * B1 - C1 * C1) / (2 * A1 * B1));
            double arcosAC1 = Math.Acos((A1 * A1 + C1 * C1 - B1 * B1) / (2 * A1 * C1));
            double arcosBC1 = Math.Acos((B1 * B1 + C1 * C1 - A1 * A1) / (2 * B1 * C1));

            if (A / A1 == B / B1 && A / A1 == C / C1 && B / B1 == C / C1)
            {
                if (arcosAB == arcosAB1 && arcosBC == arcosBC1 && arcosAC == arcosAC1)
                {
                    Console.WriteLine("Да. Треугольники подобны.");
                }
                else
                {
                    Console.WriteLine("Нет. Треугольники не подобны.");
                }
            }
            else
            {
                Console.WriteLine("Нет. Треугольники не подобны.");
            }
        }
        else
        {
            Console.WriteLine("Некорректные стороны треугольников.");
        }
    }
}
