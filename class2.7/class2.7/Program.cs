using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точек по X: ");
        double[] arrayX = new double[15];
        for (int i = 0; i < 15; i++)
        {
            arrayX[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Введите ккординаты точек по Y: ");
        double[] arrayY = new double[15];
        for (int i = 0; i < 15; i++)
        {
            arrayY[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Координаты точек: ");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine($"X = {arrayX[i]}, Y = {arrayY[i]}");
        }
        Diametr(arrayX, arrayY);
    }

    static void Diametr(double[] arrX, double[] arrY)
    {
        double max_dist = 0;
        double X1 = 0;
        double X2 = 0;
        double Y1 = 0;
        double Y2 = 0;
        for (int i = 0; i < 15; i++)
        {
            for (int j = i + 1; j < 14; j++)
            {
                double dist = Math.Sqrt(Math.Pow((arrX[j] - arrX[i]), 2) + Math.Pow((arrY[j] - arrY[i]), 2));
                if (max_dist < dist)
                {
                    max_dist = dist;
                    X1 = arrX[j];
                    X2 = arrX[i];
                    Y1 = arrY[j];
                    Y2 = arrY[i];
                }
            }
            
        }
        Console.WriteLine($"Диаметр множества точек: {max_dist} расположен между точками:\nX1 = {X1}, Y1 = {Y1}\nX2 = {X2}, Y2 = {Y2}");
    }
}
