//Да се напише програма, която сортира в низходящ ред елементите на едномерен масив.
//Нека елементите на масива са 10 реални числа, които се въвеждат от потребителя. След въвеждането им
//трябва да се изведат в последователността, в която са въведени и после сортирани.
using System;
using System.Collections;

class MyClass
{
    static void Main()
    {
        float[] arr = new float[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Array.Sort(arr);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }


    }

}

