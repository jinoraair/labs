using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите любое целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        func(n);
    }
    static void func(int num)
    {
        int q = 0;
        while (num > 1)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
                q += 1;
                Console.WriteLine(num);
            }
            else
            {
                num = 3 * num + 1;
                q += 1;
                Console.WriteLine(num);
            }
        }
        Console.WriteLine($"Количество замен, приводящих к 1: {q}");
       
    }
}