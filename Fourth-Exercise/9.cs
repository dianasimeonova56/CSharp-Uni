//Да се напише програма, която дефинира клас PointR3, който определя точка в
//пространството, а точките да се съхраняват в масив от обекти. Да се въведат n точки в пространството и
//да се изведат координатите на точката, която е най-близо до центъра на тримерната координатна система.

using System;
using System.Collections;


class PointR3
{
    public double x1;
    public double x2;
    public double y1;
    public double y2;
    public double z1;
    public double z2;
    public PointR3(double a, double b, double c, double d, double e, double f)
    {
        x1 = a;
        x2 = b;
        y1 = c;
        y2 = d;
        z1 = e;
        z1 = f;
    }

    public double Razstoqnie()
    {
        double first = Math.Pow(x2 - x1, 2);
        double second = Math.Pow(y2 - y1, 2);
        double third = Math.Pow(z2 - z1, 2);
        double final = Math.Sqrt(first + second + third);
        return final;
    }
}


class MyClass
{
    static void Main()
    {
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());
        double x1, x2, y1, y2, z1, z2;


        PointR3[] d = new PointR3[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write($"Enter x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write($"Enter y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write($"Enter y2: ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write($"Enter z1: ");
            z1 = double.Parse(Console.ReadLine());
            Console.Write($"Enter z2: ");
            z2 = double.Parse(Console.ReadLine());
            d[i] = new PointR3(x1, x2, y1, y2, z1, z2);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i}: {d[i].Razstoqnie()}");
        }

    }
}