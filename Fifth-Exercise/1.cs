//Да се напише програма, която извежда простите множители на две числа x и y, които се
//въвеждат. Да се изведат, ако има общи множители между простите числа. Да се използва класът ArrayList.

using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        int x, y;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        ArrayList xMult = new ArrayList();
        ArrayList yMult = new ArrayList();
        ArrayList p = new ArrayList();

        for (int i = 2; x != 1; i++)
        {
            while (x % i == 0)
            {
                x /= i;
                if (!xMult.Contains(i))
                {
                    xMult.Add(i);
                }
            }

        }
        for (int i = 2; y != 1; i++)
        {
            while (y % i == 0)
            {
                y /= i;
                if (!yMult.Contains(i))
                {
                    yMult.Add(i);
                }
            }
        }

        for (int i = 0; i < xMult.Count; i++)
        {
            for (int j = 0; j < yMult.Count; j++)
            {

                if (xMult[i].Equals(yMult[j]))
                {
                    p.Add(xMult[i]);
                    break;
                }
            }
        }

        for (int i = 0; i < p.Count; i++)
        {
            Console.WriteLine(p[i]);
        }
    }

}
}