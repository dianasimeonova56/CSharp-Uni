//Даден е двумерен масив m с равен брой редове и колони. Да се напише програма, която
//намира кои стойности по главния диагонал колко пъти се съдържат сред елементите разположени над
//него. Размерността и стойностите на елементите на масива се въвеждат от клавиатурата
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] m = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    for (int a = 0; a < n; a++)
                    {
                        for (int b = 0; b < n; b++)
                        {
                            if (a < b)
                            {
                                if (m[i, j] == m[a, b])
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    Console.WriteLine(m[i, j] + " is found " + count + "times above the main diagonal");
                    count = 0;
                }
            }
        }

    }

}

