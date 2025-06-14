using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;

//Сделала тест всего на 8 вопросов, потому что надоело строчить вопросы (надеюсь не критично), зато есть таймер 
class Program
{
    static void Main()
    {
        //Таймер
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        //Остальной код
        string[] correct_answers = new string[]{"3","2","4","1","4","4", "3", "1"};
        string[] answers = new string[8];
        Answers(answers);
        int score = Score(answers, correct_answers);
        stopwatch.Stop();
        Console.WriteLine($"============================\nВаш результат: {score}/8");
        Console.WriteLine($"Время выполнения: {stopwatch.Elapsed.TotalSeconds} сек");
        if (score < 5)
        {
            Console.WriteLine("Тест не пройден.");
        }
        else { Console.WriteLine("Тест пройден."); }
    }
    static void Answers(string[] array) {
                  
        for (int i = 0; i < 8; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("\nВопрос №1:\n В чем отличие между break и continue?\n");
                Console.WriteLine("1. Break исп-ся в switch-case, а continue в циклах\n" +
                    "2. Нет отличий\n" +
                    "3. Continue пропускает итерацию, break выходит из цикла\n" +
                    "4. Continue работает только в циклах, break дополнительно в методах\n");
            }
            else if (i == 1)
            {
                Console.WriteLine("\nВопрос №2:\n Что делает try-catch?\n");
                Console.WriteLine("1. Работает с файлами\n" +
                    "2. Работает с исключениями\n" +
                    "3. Работает с базой данных\n" +
                    "4. Работает с классами\n");
            }
            else if (i == 2)
            {
                Console.WriteLine("\nВопрос №3: Какие типы переменных существуют?\n");
                Console.WriteLine("1. int, char, bool, float, double\n" +
                    "2. int, char, bool, string\n" +
                    "3. int, char, bool, float, double, uint, short\n" +
                    "4. Всё перечисленное\n");
            }
            else if (i == 3)
            {
                Console.WriteLine("\nВопрос №4: Какие циклы существуют в языке C#?\n");
                Console.WriteLine("1. for, while, do while, foreach\n" +
                    "2. for\n" +
                    "3. for, while\n" +
                    "4. for, while, foreach\n");
            }
            else if (i == 4)
            {
                Console.WriteLine("\nВопрос №5: Где верно происходит вывод данных в консоль?\n");
                Console.WriteLine("1. Console.Write(''Hi'');\n" +
                    "2. console.log(''Hi'');\n" +
                    "3. print(''Hi'');\n" +
                    "4. Console.WriteLine(''Hi'');\n");
            }
            else if (i == 5)
            {
                Console.WriteLine("\nВопрос №6: Для чего можно использовать язык c#?\n");
                Console.WriteLine("1. Для создавния веб-сайтов\n" +
                    "2. Для создания программ под ПК;\n" +
                    "3. Для написания игр\n" +
                    "4. Всё перечисленное\n");
            }
            else if (i == 6)
            {
                Console.WriteLine("\nВопрос №7: Где правильно создан массив?\n");
                Console.WriteLine("1. int arr = {2,5};\n" +
                    "2. int arr [] = {2,5};\n" +
                    "3. int[] arr = new [2] {2,5};\n" +
                    "4. int[] arr = new Array [2,5]\n");
            }
            else if (i == 7)
            {
                Console.WriteLine("\nВопрос №8: Какое из перечисленных ключевых слов исп-ся для создания комментария в C#?\n");
                Console.WriteLine("1. //, /* */\n" +
                    "2. #\n" +
                    "3. @\n" +
                    "4. ..\n");
            }
            Console.WriteLine($"Ответ: ");
            string input = Console.ReadLine();
            array[i] = input;         
        }
    }
    static int Score(string[] array, string[] correct_array)
    {
        int score = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] == correct_array[i])
            {
                score += 1;
            }
        }
        return score;
    }
}