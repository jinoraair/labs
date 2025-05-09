// Susing System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны первого треугольника: ");
        double a = GetValidInput("Сторона AB: ");
        double b = GetValidInput("Сторона BC: ");
        double c = GetValidInput("Сторона CA: ");
        Console.WriteLine("Введите стороны второго треугольника: ");
        double a1 = GetValidInput("Сторона A1B1: ");
        double b1 = GetValidInput("Сторона B1C1: ");
        double c1 = GetValidInput("Сторона C1A1: ");
        while (a <= 0 || b <= 0 || c <= 0 || a1 <= 0 || b1 <= 0 || c1 <= 0)
        {
            Console.WriteLine("Ошибка! Стороны должны быть больше 0.");
            a = GetValidInput("Сторона AB: ");
            b = GetValidInput("Сторона BC: ");
            c = GetValidInput("Сторона CA: ");
            a1 = GetValidInput("Сторона A1B1: ");
            b1 = GetValidInput("Сторона B1C1: ");
            c1 = GetValidInput("Сторона C1A1: ");
        }
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

            isValidInput = double.TryParse(userInput, out result);

            if (!isValidInput)
            {
                Console.WriteLine("Ошибка! Введите корректное число:");
            }
        }
        return result;
    }
    static void Similar(double A, double B, double C, double A1, double B1, double C1)
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
}