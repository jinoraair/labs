using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int size = 10; // Размер массива
        int[] randomArray = new int[size];

        // Заполнение массива случайными числами
        for (int i = 0; i < size; i++)
        {
            randomArray[i] = random.Next(10, 999); // Генерация числа от 10 до 1000
        }

        // Вывод массива на экран
        Console.WriteLine("Массив случайных чисел:");
        foreach (int num in randomArray)
        {
            Console.WriteLine(num);
        }

        SumOfNums(randomArray);
    }

    static void SumOfNums(int[] rand)
    {
        int max_sum = 0;
        List<int> numbersWithMaxSum = new List<int>(); // Список для хранения чисел с максимальной суммой

        for (int i = 0; i < rand.Length; i++)
        {
            int sum = 0;

            if (rand[i] >= 10 && rand[i] < 100)
            {
                sum = rand[i] % 10 + rand[i] / 10;
            }
            else if (rand[i] >= 100 && rand[i] <= 999)
            {
                sum = rand[i] % 10 + (rand[i] / 10) % 10 + rand[i] / 100;
            }

            if (sum > max_sum)
            {
                max_sum = sum;
                numbersWithMaxSum.Clear(); // Очищаем список, если нашли новую максимальную сумму
                numbersWithMaxSum.Add(rand[i]); // Добавляем новое число
            }
            else if (sum == max_sum)
            {
                numbersWithMaxSum.Add(rand[i]); // Добавляем число с той же максимальной суммой
            }
        }

        // Выводим числа с максимальной суммой цифр
        Console.WriteLine($"Числа с максимальной суммой цифр {max_sum}: {string.Join(", ", numbersWithMaxSum)}");
    }
}
