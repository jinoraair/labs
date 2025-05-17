using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        Random random = new Random();
        int size = Convert.ToInt32(Console.ReadLine()); // Размер массива
        int[] randomArray = new int[size];

        // Заполнение массива случайными числами
        for (int i = 0; i < size; i++)
        {
            randomArray[i] = random.Next(10, 100); // Генерация числа от 10 до 1000
        }

        // Вывод массива на экран
        Console.WriteLine("Массив случайных чисел:");
        foreach (int num in randomArray)
        {
            Console.WriteLine(num);
        }

        BubbleSort(randomArray);
    }
    static void BubbleSort(int[] array)
    {
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int b = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = b;
                }
            }
        }
        Console.WriteLine("Массив в отсортированном виде: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}