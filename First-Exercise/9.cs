//Да се напише програма, която въвежда 7 цели числа от клавиатурата и установява, дали
//въведените числа са само четни или само нечетни.
using System;

class MyClass
{
    static void Main()
    {
        int num = 0; bool same = true;
        string type = "";
        for (int i = 0; i < 7; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {

                if (type == "nechetni")
                {
                    same = false;
                }
                type = "chetni";
            }
            else
            {

                if (type == "chetni")
                {
                    same = false;

                }
                type = "nechetni";
            }
        }
        if (same)
        {
            Console.WriteLine($"Chislata sa samo {type}");
        }
        else
        {
            Console.WriteLine("Chislata ne sa ednotipni");
        }

    }
}
