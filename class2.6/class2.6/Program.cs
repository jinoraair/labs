using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[size];

        for (int i = 0; i < size; i++)
        {
            nums[i] = i + 1;
        }

        Console.WriteLine("Получившийся массив: ");
        PrintArray(nums);

        Console.WriteLine("Введите элемент, который мы будем искать: ");
        int target = Convert.ToInt32(Console.ReadLine());
        //нужен индекс найденного значения
        int index = BinarySearch(nums, target);
        PrintHighlightedArray(nums, target, index);
    }

    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            if (array[middle] == target)
            {
                return middle;
            }
            if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1; // В случае, если элемент не найден
    }

    public static void PrintArray(int[] array)
    {
        foreach (int n in array)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }

    public static void PrintHighlightedArray(int[] array, int target, int index)
    {
        foreach (int n in array)
        {
            if (n == target && index != -1)
            {
                Console.Write($"*{n}* "); // Если нашёл элемент, выделяем его
            }
            else
            {
                Console.Write(n + " ");
            }
        }
        Console.WriteLine();

        if (index == -1)
        {
            Console.WriteLine($"Элемент {target} не найден в массиве.");
        }
    }
}
