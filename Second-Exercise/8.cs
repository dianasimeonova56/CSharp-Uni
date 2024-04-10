//Имаме 3 естествени числа a<=b<=c. Да се състави алгоритъм, чрез който се въвеждат
//тези естествени числа и след това да се определи дали b е в лявата, дясната половина или в средата на
//интервала между а и с.
using System;

class MyClass
{
    static void Main()
    {
        int a, b, c, diff1, diff2;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        diff1 = b - a; diff2 = c - b;
        if (diff1 > diff2)
        {
            Console.WriteLine("b is closer to c");
        }
        else if (diff1 < diff2)
        {
            Console.WriteLine("b is closer to a");
        }
        else
        {
            Console.WriteLine("b is right between a and c");
        }

    }

}

