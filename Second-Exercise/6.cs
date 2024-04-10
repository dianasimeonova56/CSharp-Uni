//Да се разработи алгоритъм, който проверява дали дадено естествено число n (n>1) е
//съвършено. Числото е съвършенно, ако е равно на сумата от делителите си.
using System;

class MyClass
{
    static void Main()
    {
        int n, sum = 0;
        n = int.Parse(Console.ReadLine());
        while (n < 1)
        {
            Console.WriteLine("Enter n again so it's n > 1!");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n) { Console.WriteLine("yes"); }
        else { Console.WriteLine("no"); }



    }

}

