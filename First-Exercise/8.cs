//Да се напише програма, която въвежда 10 цели числа. Числата се въвеждат от
//потребителя, като не се допуска две съседни числа да имат еднаква стойност. Ако това се случи
//последното въведено число се игнорира (Например при въвеждане на 2 и отново на 2 се взема само едната
//двойка). Да се изведе средното аритметично и минимума на числата.
using System;

class MyClass
{
    static void Main()
    {
        int currNum = int.Parse(Console.ReadLine()), prevNum = 0, min = currNum;
        double sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (currNum == prevNum)
            {
                Console.WriteLine("Enter a different number!");
                currNum = int.Parse(Console.ReadLine());
            }
            else
            {
                sum += currNum;
            }
            if (currNum < min)
            {
                min = currNum;
            }
            prevNum = currNum;
            currNum = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Min is {min}, average is {sum / 10}");


    }
}
