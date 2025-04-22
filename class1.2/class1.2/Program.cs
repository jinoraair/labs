using System;
Console.WriteLine("1.2 Переставить цифры натурального числа таким образом, чтобы\nполучилось наименьшее число, записанное этими же цифрами");
Console.WriteLine("Введите любое натуральное число: ");
string num = Console.ReadLine();
num = String.Concat(num.OrderBy(c => c));
Console.WriteLine("Полученное натуральное число: ");
Console.WriteLine(num);