//Да се напише програма, която въвежда цели числа. Въвеждането на числата се
//прекратява, ако потребителят въведе 0. Да се изведе средноаритметичното на въведените числа и найголямото от тях
using System;

class MyClass
{
    static void Main()
    {
        int num;
        Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        int max = num, count = 0;
        double average = 0;

        while (num != 0)
        {
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }
            average += num;
            count++;
        }
        Console.WriteLine($"Average is {(float)average / count} and max is {max}");
    }
}
