//Въвежда се положително цяло число x. Да се напише програма, която извежда числото,
//като премахва 0 от него. Да се използва ArrayList

using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        string n = Console.ReadLine();
        ArrayList array = new ArrayList();

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == '0')
            {
                continue;
            }
            array.Add(n[i]);
        }

        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i]);
        }
    }
}
