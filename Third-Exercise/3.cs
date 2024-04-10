// Да се напише програма, която генерира едномерен масив от 20 целочислени елемента
//със стойности в интервала [1; 99]. Да се намери броят на числата, които съдържат цифра 2 и най-голямото
//от тях.
using System;

class MyClass
{
    static void Main()
    {
        int[] arr = new int[20];

        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 99);
        }
        int max = 0, count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].ToString().Contains('2'))
            {
                count++;
            }
            if (max < arr[i]) max = arr[i];
        }
        Console.WriteLine($"max is {max}, 2 is in {count} numbers");

    }

}

