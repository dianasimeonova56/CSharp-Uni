//Да се разработи алгоритъм, който намира най-малката цифра на дадено положително
//цяло число. 
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()), min, currNum;
        min = n % 10;
        n /= 10;
        while (n != 0)
        {
            currNum = n % 10;
            if (currNum < min)
            {
                min = currNum;
            }
            n /= 10;
        }
        Console.WriteLine(min);


    }

}

