//Даден е двумерен масив m с равен брой редове и колони. Да се напише програма, която
//намира сумата на елементите с четни стойности, разположени над главния диагонал. Размерността
//и стойностите на елементите на масива се въвеждат от клавиатурата
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
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < j)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        sum += m[i, j];
                    }
                }
            }
        }
        Console.WriteLine($"sum is : {sum}");

    }

}

