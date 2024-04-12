//Да се напише програма, която извежда всички цели числа от интервала [1;n], които
//удовлетворяват следното условие: x ^ 2 + y ^ 2 = z ^ 2.n е число, което се въвежда от потребителя. Да се
//създаде клас с полета x, y и z, които съхраняват тези стойности. Всички комбинации от числата да се
//съхраняват в масив от обекти. Да се изведе масива.

using System;

class Stoinosti
{
    public int x, y, z;
    public Stoinosti(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}



class MyClass
{
    static void Main()
    {
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());
        List<Stoinosti> list = new List<Stoinosti>();


        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                for (int k = 1; k < n + 1; k++)
                {
                    if (i * i + j * j == k * k) list.Add(new Stoinosti(i, j, k));
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{list[i].x}^2 + {list[i].y}^2 = {list[i].z}^2");
        }
    }
}