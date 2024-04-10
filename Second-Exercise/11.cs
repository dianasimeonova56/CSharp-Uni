//Да се състави алгоритъм, който чете от клавиатурата цели числа до въвеждане на
//числото 0 и намира сумата на положителните числа във въведената редица. 
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        while (n != 0)
        {
            if (n > 0)
            {
                sum += n;
            }
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);

    }

}

