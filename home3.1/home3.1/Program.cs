using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число (целое): ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число (целое): ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        SumBinary(num1, num2);
    }

    //ПЕРЕВОДИМ ЧИСЛО В ДВОИЧНУЮ СИСТЕМУ
    static string ToBinary(int num)
    {
        int rem;
        string res = ""; //string.Empty
        while (num > 0)
        {
            rem = num % 2;
            num /= 2;
            res = rem + res; //res = rem.ToString() + res;
        }
        return res;
    }
    static int ToDecimal(string str)
    {
        int decim = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            int numericValue = str[i] == '1' ? 1 : 0;

            decim += numericValue * (int)Math.Pow(2, i); // Накопление результата         
        }
        return decim;
    }

    //СУММА ДВОИЧНЫХ ЧИСЕЛ
    static void SumBinary(int n1, int n2)
    {
        int b1 = Convert.ToInt32(ToBinary(n1));
        Console.WriteLine($"Число {n1} в двоичной системе исчисления: {b1}");
        int b2 = Convert.ToInt32(ToBinary(n2));
        Console.WriteLine($"Число {n2} в двоичной системе исчисления: {b2}");
        int rem = 0; //отвечает за случаи, когда могут сложиться две единицы, и тогда единицу придется перенести на следующий бит
        string str = "";
        while (b1 != 0 || b2 != 0)
        {
            //сумму в дв.системе будем считать побитово
            str += (b1 % 10 + b2 % 10 + rem) % 2; //первый бит суммы посчитали
            rem = (b1 % 10 + b2 % 10 + rem) / 2;
            //отбросили этот бит
            b1 = b1 / 10;
            b2 = b2 / 10;
        }
        if (rem != 0) str += rem;
        Console.Write("Сумма в двоичном виде: ");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
        int summa = Convert.ToInt32(ToDecimal(str));
        Console.Write($"Сумма в десятичном виде: {summa}");
    }
}