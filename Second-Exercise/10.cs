//Да се разработи алгоритъм, който проверява дали сумата от цифрите на дадено
//положително цяло число е кратна на 5. 
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        if (sum % 5 == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }

}

