//Да се напише програма, която запазва размера на трите страни на n триъгълника чрез
//клас Triangle и извежда триъгълника с най-голямата площ. Да се провери за коректност на дължината на
//страните (Ако сборът на две от страните е по-малък от третата, тогава данните не са коректни). Лицето
//на триъгълник се смята по хероновата формула, където p e полупериметър равен на (a+b+c)/2.


using System;

class Triangle
{
    public double a, b, c;
    private double p;
    public Triangle(double x, double y, double z)
    {
        a = x;
        b = y;
        c = z;
    }

    public double HeronFormula()
    {
        p = (a + b + c) / 2;
        double underRoot = p * (p - a) * (p - b) * (p - c);
        return Math.Sqrt(underRoot);
    }
}


class MyClass
{
    static void Main()
    {
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());
        double a, b, c;


        Triangle[] arr = new Triangle[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter a -{i}: ");
            a = double.Parse(Console.ReadLine());
            Console.Write($"Enter b -{i}: ");
            b = double.Parse(Console.ReadLine());
            Console.Write($"Enter c -{i}: ");
            c = double.Parse(Console.ReadLine());
            arr[i] = new Triangle(a, b, c);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i}: {arr[i].HeronFormula()}");
        }

    }
}