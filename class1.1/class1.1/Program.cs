using System;
Console.WriteLine("1.1 Поменять местами две переменные");
//Вводим с консоли переменные a и b
Console.WriteLine("Введите переменную a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Меняем переменные местами:");
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"Переменная a = {a}, переменная b = {b}");