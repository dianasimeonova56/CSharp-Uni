//Потребителят въвежда две последователности от символи. Да се напише програма, която
//проверява дали в по-голямата се съдържа по-малката. След това, ако е възможно в началото на по-големия
//стринг се подреждат символите от по-малкия.
using System;

class MyClass
{
    static void Main()
    {
        string first = Console.ReadLine(),
    second = Console.ReadLine(), newString = "";
        bool flag;
        int index, count = 0;
        char[] arr;
        if (first.Length > second.Length)
        {
            flag = first.Contains(second);
            arr = second.ToCharArray();
            while (first.Contains(second))
            {
                count++;
                index = first.IndexOf(second);
                first = first.Remove(index, second.Length);
            }
            for (int i = 0; i < count; i++)
            {
                first = first.Insert(0, second);
            }
            newString = first;

        }
        else
        {
            flag = second.Contains(first);
            index = second.IndexOf(first);
            second.Remove(index);
            newString += first + second;
        }
        Console.WriteLine(flag);
        Console.WriteLine(newString);

    }

}

