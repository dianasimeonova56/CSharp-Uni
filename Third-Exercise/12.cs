//Дадена е матрица a от реални числа с размерност n=6 реда и m=5 колони. Да се състави
//програма за намиране на сумата sum от всички елементи на матрицата а, сумата sum_up от всички
//елементи на матрицата а, намиращи се над главния диагонал и сумата sum_down от всички елементи на
//матрицата а, намиращи се под главния диагонал.
using System;
using System.Collections;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] m = new int[n, n];
        int sum_up = 0, sum_down = 0;
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
                if (i < j) { sum_up += m[i, j]; }
                if (i > j) { sum_down += m[i, j]; }
            }
        }
        Console.WriteLine($"sum up is {sum_up}, sum down is {sum_down}");
    }

}

