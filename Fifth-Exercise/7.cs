//: Да се напише програма, която извежда цифрата с най-голям брой повторения в числото
//x. Да се използва класът ArrayList.
using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        string x = Console.ReadLine();
        int countMax = 0, currCount = 0;
        ArrayList array = new ArrayList();
        char[] s = x.ToCharArray();


        for (int i = 0; i < s.Length; i++)
        {
            array.Add(s[i]);
        }
        char mostFreq = (char)array[0];
        for (int i = 0; i < array.Count; i++)
        {
            for (int j = 0; j < array.Count; j++)
            {
                if (s[i] == s[j])
                {
                    currCount++;
                }
            }
            if (currCount > countMax)
            {
                countMax = currCount;
                mostFreq = (char)array[i];
            }
        }
        Console.WriteLine(mostFreq);

    }

}
