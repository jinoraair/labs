using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число, до которого будут выведены все простые числа: ");
        int num = Convert.ToInt32(Console.ReadLine());
        SimpleNums(num);
    }

    static void SimpleNums(int n)
    {
        for (int i = 2; i < n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0) // Если i делится на j, значит оно не простое
                {
                    isPrime = false;
                    break; // Выходим из цикла, оно не простое
                }
            }
            if (isPrime) // Если isPrime остался true, значит i – простое
            {
                Console.WriteLine(i);
            }
        }
    }
}