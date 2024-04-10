//Да се напише програма, която извежда всички двуцифрени числа, които съдържат
//въведена (избрана) от потребителя цифра

using System;

class MyClass
{
    static void Main()
    {
        int num;
        Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(num.ToString() + i.ToString());
            if (i != 0 && i != num)
            {
                Console.WriteLine(i.ToString() + num.ToString());
            }

        }
    }
}
