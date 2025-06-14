using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N (нечетное): ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n % 2 != 1)
        {
            Console.Write("Ошибка! Введенная N должна быть нечетной: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        int[,] array = new int[n, n];
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = num++;
            }
        }
        Console.WriteLine("Полученный массив: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Результат обхода по спирали:");
        Spiral(array, n);
    }
    static void Spiral(int[,] arr, int n)
    {
        int x = n / 2; 
        int y = n / 2;
        Console.Write(arr[y, x] + " ");

        for (int h = 1; h < n; h++) //h - шаг
        {
            //Вправо
            for (int i = 0; i < h; i++) 
            {
                x++;
                Console.Write(arr[y, x] + " ");
            }
            //Вниз
            for (int i = 0; i < h; i++) 
            {
                y++;
                Console.Write(arr[y, x] + " ");
            }

            h++;
            if (h >= n) break;
            //Влево
            for (int i = 0; i < h; i++) 
            {
                x--;
                Console.Write(arr[y, x] + " ");
            }
            //Вверх
            for (int i = 0; i < h; i++) 
            {
                y--;
                Console.Write(arr[y, x] + " ");
            }
        }

}

}