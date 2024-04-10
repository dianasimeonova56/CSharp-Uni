//Да се разработи алгоритъм, който проверява дали две числа a и b, въведени от
//клавиатурата са взаимнопрости. Две числа са взаимнопрости, ако освен 1 нямат друг общ делител.

using System;

class MyClass
{
    static void Main()
    {
        int a, b, count = 0;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());


        for (int i = 1; i < a; i++)
        {
            if (a % i == 0)
            {
                if (b % i == 0)
                {
                    count++;
                }
            }
        }

        if (count == 1)
        {
            Console.WriteLine("da");
        }
        else
        {
            Console.WriteLine("ne");
        }
    }

}

