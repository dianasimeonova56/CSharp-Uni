//Да се напише програма, която въвежда цели числа от клавиатурата,
//докато въведените числа са положителни
//(Въвеждането се прекратява при въвеждане от потребителя на отрицателно число
//или 0).
//Програмата да установява, дали въведените числа образуват възходяща или низходяща редица

using System;

class MyClass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine()), nextNum = int.Parse(Console.ReadLine());
        string type = "", type2 = "";
        while (num > 0 && nextNum > 0)
        {
            if (num < nextNum)
            {
                type = "wyzhodqshta";
                if (type2 == "nizhodqshta")
                {
                    type = "nito w, nito n";
                }
                else
                {
                    type2 = "wyzhodqshta";
                }
            }
            else if (num > nextNum)
            {
                type = "nizhodqshta";
                if (type2 == "wyzhodqshta")
                {
                    type = "nito w, nito n";
                }
                else
                {
                    type2 = "nizhodqshta";
                }
            }
            num = nextNum;
            nextNum = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(type);

    }
}
