using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вещественное число x, чтобы -1 <= x <= 1: ");
        double x = Convert.ToDouble(Console.ReadLine());

        while (x < -1 || x > 1)
        {
            Console.WriteLine("Ошибка! Введите вещественное число x, чтобы -1 <= x <= 1: ");
            x = Convert.ToDouble(Console.ReadLine());
        }

        double f = Func(x);
        Console.WriteLine($"Приближение к e^x = {f}");
    }

    static double Func(double num)
    {
        int k = 0; // Начинаем с 0 для правильного учёта 0! = 1
        double e = 1; // Учитываем 1, которая прибавляется в начале
        double term = 1;

        while (Math.Abs(term) > Math.Pow(10, -6)) // Условие выхода из цикла
        {
            k++; // Увеличиваем k
            term = Math.Pow(num, k) / Factorial(k); // Вычисляем текущее слагаемое
            e += term; 
        }

        return e;
    }

    // Функция для факториала
    static long Factorial(int k)
    {
        long fact = 1;
        for (int i = 1; i <= k; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
