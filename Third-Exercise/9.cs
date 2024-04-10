//Даден е двумерен масив m (nXn). Той представя квадратна матрица с размерност n по n.
//Да се напише програма, която изтрива k-тия ред и k-тата колона на m. Така масивът вече има размерност
//(n-1Xn-1). Размерността и стойностите на елементите на масива се въвеждат от клавиатурата
using System;
using System.Collections;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] m = new int[n, n];
        int[,] newM = new int[n - 1, n - 1];
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
                continue;
            for (int j = 0; j < n; j++)
            {
                if (j == k) continue;
                newM[i, j] = m[i, j];
            }
        }

        for (int i = 0; i < newM.GetLength(0); i++)
        {
            for (int j = 0; j < newM.GetLength(1); j++)
            {
                Console.Write(newM[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

}

