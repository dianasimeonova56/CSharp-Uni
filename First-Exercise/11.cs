//Да се напише програма, която позволява въвеждането на цяло положително число от
//клавиатурата, докато се въведе число различно от него. Тогава въвеждането се прекратява и се извежда
//еднаквото число и броят пъти на въвеждането му. 
using System;

class MyClass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine()), count = 0, prevNum = num;
        while (num > 0)
        {
            num = int.Parse(Console.ReadLine());
            count++;
            if (prevNum != num)
            {
                break;
            }
            prevNum = num;
        }

        Console.WriteLine($"{prevNum} - {count} times");
    }
}
