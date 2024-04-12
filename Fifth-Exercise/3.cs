//Въвежда се положително цяло число x. Да се напише програма, която извежда числото,
//като премахва дублиращите се цифри от него и водещите 0. Да се използва класът ArrayList.
using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        Console.WriteLine("Enter a positive whole num: ");
        string n = Console.ReadLine();
        char[] numArray = n.ToString().ToCharArray();
        ArrayList final = new ArrayList();

        int i = 0;
        for (int j = i; j < numArray.Length; j++)
        {
            if (numArray[i].Equals(numArray[j]))
            {
                continue;
            }
            final.Add(numArray[j]);
        }

        if (final[0].Equals('0'))
        {
            final.RemoveAt(0);
        }

        for (i = 0; i < final.Count; i++)
        {
            Console.Write(final[i]);
        }

    }

}
