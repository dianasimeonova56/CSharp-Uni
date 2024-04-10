//Да се състави алгоритъм, чрез който се въвеждат три естествени числа a, b, c и след това
//стойностите им да се извеждат, подредени в низходящ ред.
using System;

class MyClass
{
    static void Main()
    {
        int a, b, c, max, middle, min;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        c = int.Parse(Console.ReadLine());
        //max = a; middle = a; min = a;
        if (a > b)
        {
            middle = a; min = b;
        }
        else
        {
            middle = b; min = a;
        }
        if (middle > c)
        {
            max = middle;
            if (min > c)
            {
                middle = min;
                min = c;
            }
            else
            {
                middle = c;
            }
        }
        else
        {
            max = c;
        }
        Console.WriteLine($"{max} {middle} {min}");
    }

}

