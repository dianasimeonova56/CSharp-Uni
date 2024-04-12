//Да се напише програма, която извежда въведено число, като премахва намиращите се
//една до друга повтарящи се цифри. Да се използва класът ArrayList.
using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        Console.WriteLine("Enter a positive whole num: ");
        string n = Console.ReadLine();
        char[] numArray = n.ToCharArray();
        List<char> final = new List<char>()

foreach (char item in numArray)
        {
            if (final.Count == 0 || final.Last() != item)
            {
                final.Add(item);
            }
        }


        for (int i = 0; i < final.Count; i++)
        {
            Console.Write(final[i]);
        }

    }

}
