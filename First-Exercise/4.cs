//Въвежда се цяло положително число n. Да се напише програма без масив, която изисква
//въвеждането на n символа, след което ги извежда в обратен ред. Нека да се изведат на един ред разделени
//с интервал.

using System;

class MyClass
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter a positive whole number: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter {n} chars");
        string s = "";

        for (int i = 0; i < n; i++)
        {
            s += Console.ReadLine();
        }
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }

    }
}
