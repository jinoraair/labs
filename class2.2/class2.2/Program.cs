using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Ошибка! Пожалуйста, введите четное положительное число: ");
        }

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            bool isUnique;
            do
            {
                Console.Write($"Введите элемент номер {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write($"Пожалуйста, введите целое значение для элемента {i + 1}: ");
                }

                // Проверка на уникальность
                isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        Console.WriteLine($"Все значения в массиве должны быть разные! Попробуйте ввести новое значение для элемента {i + 1}: ");
                        break;  // Если нашли дубликат, прерываем цикл проверки
                    }
                }
            } while (!isUnique); // Продолжаем запрашивать, пока элемент не уникален
        }

        Console.WriteLine("Полученный массив: ");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        TwoMax(array, size);
    }
    static void TwoMax(int[] arr, int n)
    {
        int max_num = 0;
        int max_num2 = 0;
        //поиск максимального числа
        for (int i = 0; i < n; i++)
        {
            if (max_num < arr[i])
            {
                max_num = arr[i];
            }
        }
        Console.WriteLine($"Максимальное значение: {max_num}");
        //поиск второго максимального значения:
        for (int i = 0; i < n; i++)
        {
            if (max_num2 < arr[i] && arr[i] < max_num)
            {
                max_num2 = arr[i];
            }
        }
        Console.WriteLine($"Второе максимальное значение: {max_num2}");
    }
}
