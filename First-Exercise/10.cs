//Да се напише програма, която въвежда пет цели положителни числа. Да се игнорират
//въведените от потребителя числа, ако не са положителни. Да се изведе минимума и максимума на числата
using System;

class MyClass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int min = num, max = num;
        for (int i = 0; i < 4; i++)
        {
            if (num <= 0)
            {
                Console.WriteLine("Enter a whole positive num!");
                num = int.Parse(Console.ReadLine());
            }
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Max is {max}, min is {min}");

    }
}
