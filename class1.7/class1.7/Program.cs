using System;
Console.WriteLine("1.7 Ввести вещ.число, знак арифм.операции и еще одно вещ.число. Вычислить и вывести результат.");
Console.WriteLine("Введите первое вещественное число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите знак операции: ");
string sign = Console.ReadLine();
Console.WriteLine("Введите второе вещественное число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (sign == "+")
{
    Console.WriteLine(num1+num2);
}
if (sign == "-")
{
    Console.WriteLine(num1 - num2);
}
if (sign == "*")
{
    Console.WriteLine(num1 * num2);
}
if (sign == "/")
{
    Console.WriteLine(num1 + num2);
}
if (sign == "^")
{
    Console.WriteLine(Math.Pow(num1, num2));
}