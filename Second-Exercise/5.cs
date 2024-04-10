//Да се състави алгоритъм, който въвежда от клавиатурата целите числа m и n (m<n).
//Алгоритъмът да извежда всички числа в интервала [m; n], които са кратни на 7. Направете проверка за
//коректност на входа (m<n)
using System;

class MyClass
{
    static void Main()
    {
        int m, n;
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        while (m > n)
        {
            Console.WriteLine("Enter n again so it's m < n!");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = m; i < n; i++)
        {
            if (i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }


    }

}

