//Да се напише програма, която извежда във възходящ ред, всички трицифрени естествени
//числа, които съдържат последователни цифри. Те се записват в масив. Да не се използват “/” и “%” в
//програмата. Например числата 123 и 543 са с последователни цифри
using System;
using System.Collections;

class MyClass
{
    static void Main()
    {
        char[] arr;
        ArrayList list = new ArrayList();
        bool isConsecutive = false;
        int diff = 0;
        for (int i = 100; i < 999; i++)
        {
            arr = i.ToString().ToCharArray();
            //Array.Sort(arr);
            if ((int.Parse(arr[0].ToString()) - int.Parse(arr[1].ToString()) == 1) &&
                (int.Parse(arr[1].ToString()) - int.Parse(arr[2].ToString()) == 1))
            {
                isConsecutive = true;
            }
            else if ((int.Parse(arr[1].ToString()) - int.Parse(arr[0].ToString()) == 1) &&
                (int.Parse(arr[2].ToString()) - int.Parse(arr[1].ToString()) == 1))
            {
                isConsecutive = true;
            }

            if (isConsecutive)
            {
                list.Add(i);
            }
            isConsecutive = false;

        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }

    }

}

