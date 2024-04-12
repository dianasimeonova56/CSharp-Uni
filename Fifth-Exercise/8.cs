//Въвежда се списък от думи. Да се напише програма, която извежда списъка, като
//премахва думите, които имат цифри от него. Да се използва ArrayList.

using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        string s = Console.ReadLine();
        ArrayList array = new ArrayList();
        bool toRemove = false;

        while (s != "0")
        {
            array.Add(s);
            s = Console.ReadLine();
        }
        char[] ch;
        for (int i = 0; i < array.Count; i++)
        {
            string word = (string)array[i];
            foreach (char c in word)
            {
                if (char.IsDigit(c)) toRemove = true; break;
            }
            if (toRemove)
            {
                array.RemoveAt(i);
            }
            toRemove = false;
        }

        for (int i = 0; i < array.Count; i++)
        {
            Console.WriteLine(array[i]);
        }


    }
}
