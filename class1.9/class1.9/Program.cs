using System;


class Program { 
    static void Main()
    {
        //Вводим значения
        Console.WriteLine("Введите число: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите первую букву единицы измерения, в которой представлено введенное число: \n * г - граммы; \n к - килограммы; \n ц - центнеры; \n т - тонны;");
        string n = Console.ReadLine();
        Console.WriteLine("Введите таким же образом первую букву единицы измерения, в которую хотите преобразовать введенное значение: ");
        string m = Console.ReadLine();

        // Ошибки--------------------------------------
        List<string> errorMessages = new List<string>();

        if (value <= 0)
        {
            errorMessages.Add("Ошибка! Значение не может быть меньше или равным нулю.");
        }

        if (n != "г" && n != "к" && n != "ц" && n != "т")
        {
            errorMessages.Add("Ошибка! Первая единица измерения должна быть одной из: г, к, ц, т.");
        }

        if (m != "г" && m != "к" && m != "ц" && m != "т")
        {
            errorMessages.Add("Ошибка! Вторая единица измерения должна быть одной из: г, к, ц, т.");
        }

        // Если есть ошибки, выводим их
        if (errorMessages.Count > 0)
        {
            foreach (var error in errorMessages)
            {
                Console.WriteLine(error);
            }
            return; // Выход из программы, если есть ошибки
        }
        //-------------------------------------------
        Console.WriteLine(ConvertNtoM(value, n, m));
    }
    static string ConvertNtoM(double val, string n1, string m1)
    {
        //Для преобразования граммов в другие единицы измерения
        double result = 0;
        if (n1 == "г")
        {
            if (m1 == "к")
            {
                result = val / 1000;
            }
            else if (m1 == "ц")
            {
                result = val / 100000;
            }
            else if (m1 == "т")
            {
                result = val / 1000000;
            }
        }
        if (n1 == "к")
        {
            if (m1 == "г")
            {
                result = val * 1000;
            }
            else if (m1 == "ц")
            {
                result = val / 100;
            }
            else if (m1 == "т")
            {
                result = val / 1000;
            }
        }
        if (n1 == "ц")
        {
            if (m1 == "г")
            {
                result = val * 100000;
            }
            else if (m1 == "к")
            {
                result = val * 100;
            }
            else if (m1 == "т")
            {
                result = val / 10;
            }
        }
        if (n1 == "т")
        {
            if (m1 == "г")
            {
                result = val * 1000000;
            }
            else if (m1 == "к")
            {
                result = val * 1000;
            }
            else if (m1 == "ц")
            {
                result = val * 10;
            }
        }
        if (m1 == "г") return result + " граммов";
        if (m1 == "к") return result + " килограммов";
        if (m1 == "ц") return result + " центнеров";
        if (m1 == "т") return result + " тонн";

        return "Ошибка в преобразовании";
    }
}