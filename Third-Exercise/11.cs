//Дадена е квадратна матрица, която се съхранява в масив m. Да се напише програма,
//която нулира n-тия ред и n-тата колона на m. На мястото на тези елементи да се запишат 0. Размерността
//и стойностите на елементите на масива се въвеждат от клавиатурата. 
using System;
using System.Collections;

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
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i == k)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == k)
                    {
                        m[i, j] = 0;
                    }
                }
            }

        }
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

}

