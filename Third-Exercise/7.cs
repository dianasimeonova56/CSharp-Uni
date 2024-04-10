//: Даден е двумерен масив m с равен брой редове и колони. Да се напише програма, която
//намира сумата на елементите, разположени по двата главни диагонала (които образуват буквата X).
//Размерността и стойностите на елементите на масива се въвеждат от клавиатурата. 
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] m = new int[n, n];
        int sum = 0;
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
                if (i == j) { sum += m[i, j]; }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i + j) == (n - 1)) { sum += m[i, j]; }
            }
        }
        Console.WriteLine(sum);

    }

}

