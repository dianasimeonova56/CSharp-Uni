//Да се разработи алгоритъм, който намира броя на цифрите на дадено положително цяло
//число. 
using System;

class MyClass
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        while (number > 0)
        {
            count++;
            number /= 10;
        }
        Console.WriteLine(count);
    }
}
