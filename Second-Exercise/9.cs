//Да се разработи алгоритъм, който въвежда от клавиатурата цифра k. Алгоритъмът да
//извежда всички четирицифрени числа, една от цифрите, на които е равна на k.
using System;

class MyClass
{
    static void Main()
    {
        string k = (Console.ReadLine());
        for (int i = 1000; i < 9999; i++)
        {
            if (i.ToString().Contains(k))
            {
                Console.WriteLine(i);
            }
        }

    }

}

