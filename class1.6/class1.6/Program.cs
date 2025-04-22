using System;
Console.WriteLine("1.6 Вывести таблицу значений функции f(x)=sin(x^2)*ln(x) для x от 10 до 15 с шагом 0.5");
for (double x = 10; x <= 15; x += 0.5)
{
    double f = Math.Sin(Math.Pow(x, 2)) * Math.Log(x);
    Console.WriteLine($"Для x = {x} f(x) = {f}");
}