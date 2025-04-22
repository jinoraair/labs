using System;
Console.WriteLine("1.5 Вычислить значение выражения");
double result = (Math.Sin(5)+Math.Pow(1.75, 2)) / (3*Math.Pow(double.Epsilon,Math.Cos(7)));
Console.WriteLine($"Результат вычисления = {result}");