//Да се разработи алгоритъм, който намира и извежда всички трицифрени числа, сумата
//от цифрите, на които е нечетна. 
using System;

class MyClass
{
    static void Main()
    {
        int n1, n2, n3, num, sum = 0;
        for (int i = 100; i < 999; i++)
        {
            num = i;
            n1 = num % 100; num /= 10;
            n2 = num % 10; num /= 10;
            n3 = num;
            sum += n1 + n2 + n3;
            if (sum % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

    }

}

