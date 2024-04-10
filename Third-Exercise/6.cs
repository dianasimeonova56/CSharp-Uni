//Да се напише програма, която намира всички цели числа до дадено положително цяло
//число n, за които е вярно, че са кратни на произведението от цифрите си. Те се записват в масив
using System;

class MyClass
{
    static void Main()
    {
        int end = int.Parse(Console.ReadLine());
        char[] arr;
        int proizwedenie;
        for (int i = 1; i < end; i++)
        {
            arr = i.ToString().ToCharArray();
            proizwedenie = int.Parse(arr[0].ToString());
            if (arr.Length == 1)
            {
                continue;
            }
            for (int j = 1; j < arr.Length; j++)
            {
                proizwedenie *= int.Parse(arr[j].ToString());
            }
            if (proizwedenie == 0)
            {
                continue;
            }
            if (i % proizwedenie == 0)
            {
                Console.WriteLine(i + "e kratno na proizwedenieto na cifrite si");
            }

        }

    }

}

