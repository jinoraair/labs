using System;

// Определяем перечисление NumberType с двумя возможными значениями: Integer и Float
public enum NumberType
{
    Integer,
    Float
}
// Структура Number
public struct Number
{
    private int intValue;
    private float floatValue;

    // Свойство Type позволяет нам получить тип числа (целое или вещественное)
    public NumberType Type { get; private set; }

    // Конструктор для целого числа
    public Number(int value)
    {
        intValue = value;
        floatValue = 0;
        Type = NumberType.Integer;
    }

    public Number(float value)
    {
        intValue = 0;
        floatValue = value;
        Type = NumberType.Float;
    }

    // Переопределение метода ToString для удобного отображения значения
    public override string ToString()
    {
        return Type == NumberType.Integer ? intValue.ToString() : floatValue.ToString();
    }// Возвращаем строковое представление в зависимости от типа

    //=============================================================
    // АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ
    public static Number operator +(Number a, Number b)
    {
        return new Number(a.ToFloat() + b.ToFloat()); // Создаем новое вещественное число
    }

    public static Number operator -(Number a, Number b)
    {
        return new Number(a.ToFloat() - b.ToFloat());
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number(a.ToFloat() * b.ToFloat());

    }

    public static Number operator /(Number a, Number b)
    {
        if (b.ToFloat() == 0)
            throw new DivideByZeroException("Ошибка! Деление на ноль недопустимо.");

        return new Number(a.ToFloat() / b.ToFloat());

    }

    // Операции сравнения
    public static bool operator ==(Number a, Number b)
    {
        return a.ToFloat() == b.ToFloat();
    }

    public static bool operator !=(Number a, Number b)
    {
        return !(a == b);
    }

    public static bool operator >(Number a, Number b)
    {
        return a.ToFloat() > b.ToFloat();
    }

    public static bool operator <(Number a, Number b)
    {
        return a.ToFloat() < b.ToFloat();
    }

    public static bool operator >=(Number a, Number b)
    {
        return a.ToFloat() >= b.ToFloat();
    }

    public static bool operator <=(Number a, Number b)
    {
        return a.ToFloat() <= b.ToFloat();
    }

    private float ToFloat()
    {
        return Type == NumberType.Integer ? intValue : floatValue;
    }

    public override bool Equals(object obj)
    {
        if (obj is Number)
        {
            Number other = (Number)obj;
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return ToFloat().GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        //Ввод целого числа и проверка его на соответствие типу данных 
        Console.WriteLine("Введите первое число - целое: ");
        string input1 = Console.ReadLine();
        Number firstNumber;
        bool isValidInt = false;

        if (int.TryParse(input1, out int intValue))
        {
            firstNumber = new Number(intValue);
        }
        else
        {
            isValidInt = true;
            while (isValidInt)
            {
                Console.WriteLine("Ошибка! Введите целое число: ");
                input1 = Console.ReadLine();
                if (int.TryParse(input1, out intValue))
                {
                    isValidInt = false;
                }
            }
        }
        //Ввод вещественного числа и проверка его на соответствие типу данных 
        Console.WriteLine("Введите второе число - вещественное: ");
        string input2 = Console.ReadLine();
        Number secondNumber;
        bool isValidFloat = false;

        if (float.TryParse(input2, out float floatValue))
        {
            secondNumber = new Number(floatValue);
        }
        else
        {
            isValidFloat = true;
            while (isValidFloat)
            {
                Console.WriteLine("Ошибка! Введите вещественное число: ");
                input1 = Console.ReadLine();
                if (float.TryParse(input2, out floatValue))
                {
                    isValidFloat = false;
                }
            }
        }
        Number intNumber = new Number(intValue);
        Number floatNumber = new Number(floatValue);

        Console.WriteLine($"Целое число: {intNumber}");
        Console.WriteLine($"Вещественное число: {floatNumber}");

        // Арифметические операции
        Number sum = intNumber + floatNumber;
        Number difference = intNumber - floatNumber;
        Number product = intNumber * floatNumber;
        Number quotient = intNumber / floatNumber;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Разница: {difference}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Частное: {quotient}");

        // Операции сравнения
        Console.WriteLine($"{intNumber} равняется {floatNumber}: {intNumber == floatNumber}");
        Console.WriteLine($"{intNumber} больше {floatNumber}: {intNumber > floatNumber}");
    }
}
