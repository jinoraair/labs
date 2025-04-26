using System;

class Program
{
    static void Main()
    {
        int a = GetValidInput("Введите делимое: ");
        int b = GetValidInput("Введите делитель: ");

        // Проверка деления на нуль
        while (b == 0)
        {
            Console.WriteLine("Ошибка: делитель не может быть нулем. Пожалуйста, введите делитель еще раз.");
            b = GetValidInput("Введите делитель: ");
        }

        Del(a, b);
    }

    static int GetValidInput(string message)
    {
        int result = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            isValidInput = int.TryParse(userInput, out result);

            if (!isValidInput)
            {
                Console.WriteLine("Ошибка! Введите корректное целое число:");
            }
        }
        return result;
    }

    static void Del(int A, int B)
    {
        bool isNegativeResult = (A < 0) ^ (B < 0); // Если в одном из чисел стоит отрицательный знак
        int n;

        A = Math.Abs(A);
        B = Math.Abs(B);

        for (n = 0; A >= B; n++)
        {
            A -= B;
        }

        if (isNegativeResult)
        {
            n = -n; // Знак частного зависит от знаков делимого и делителя
        }

        Console.WriteLine($"Целая часть {n}, остаток {A}");
    }
}