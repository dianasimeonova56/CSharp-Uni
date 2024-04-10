//Да се разработи алгоритъм, който въвежда от клавиатурата естествено число k.
//Алгоритъмът да извежда всички трицифрени числа, сумата от цифрите, на които е равна на числото k. 
using System;

class MyClass
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n1, n2, n3, num;
        for (int i = 100; i < 999; i++)
        {
            num = i;
            n1 = num % 100; num /= 10;
            n2 = num % 10; num /= 10;
            n3 = num;
            if (n1 + n2 + n3 == k)
            {
                Console.WriteLine(i);
            }
        }
    }

}

