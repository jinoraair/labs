using System;
Console.WriteLine("1.4 Ввести 3 вещ.числа и вывести значение выражения...");
//Вводим переменную a
Console.WriteLine("Введите вещественную переменную a: ");
double a = Convert.ToDouble(Console.ReadLine());
//Вводим переменную b
Console.WriteLine("Введите вещественную переменную b: ");
double b = Convert.ToDouble(Console.ReadLine());
//Вводим переменную c
Console.WriteLine("Введите вещественную переменную c: ");
double c = Convert.ToDouble(Console.ReadLine());
//Находим значение выражения
double result = ((Math.Pow(a * b + 7 * c,3)-(Math.Pow(a,2)+ Math.Pow(b, 2) + Math.Pow(c, 2))) / (b - a*c - a* (b+c)));
Console.WriteLine($"Результат вычисления = {result}");