//Да се напише програма, която въвежда цели числа от клавиатурата,
//докато въведените числа са положителни
//Да се напише програма, която изисква от потребителя да въведе цяло число b и после
//последователност от още 10 цели числа. Да се изведе дали сред въведените 10 числа се съдържа числото
//b и колко пъти.

using System;

class MyClass
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine()), count = 0, nextNum;
        Console.WriteLine("Enter 10 more whole numbers");
        for (int i = 0; i < 10; i++)
        {
            nextNum = int.Parse(Console.ReadLine());
            if (nextNum == b)
            {
                count++;
            }
        }

        Console.WriteLine(count);

    }
}
