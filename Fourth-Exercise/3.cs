//Да се напише програма, която чете координатите на n точки от равнината и
//извежда найголямото разстояние (d) между две от тях.
//За целта да се дефинира клас PointR2, определящ точка от
//равнината, а точките да се съхраняват в масив от обекти.


using System;

class PointR2
{
    public double x1;
    public double x2;
    public double y1;
    public double y2;
    public PointR2(double a, double b, double c, double d)
    {
        x1 = a;
        x2 = b;
        y1 = c;
        y2 = d;
    }

    public double Razstoqnie()
    {
        double first = Math.Pow(x2 - x1, 2);
        double second = Math.Pow(y2 - y1, 2);
        double final = Math.Sqrt(first + second);
        return final;
    }
}


class MyClass
{
    static void Main()
    {
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());
        double x1, x2, y1, y2;


        PointR2[] d = new PointR2[n];

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
            d[i] = new PointR2(x1, x2, y1, y2);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i}: {d[i].Razstoqnie()}");
        }

    }
}
