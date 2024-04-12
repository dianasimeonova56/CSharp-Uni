//Да се напише програма, която разделя въведен стринг на думи и ги запазва в масив. Да
//се въведат два стринга. След това да се изведат думите, като се редуват една от единия стринг, после една
//от другия. Да се използва класът ArrayList
using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] nArr = n.Split(' ');
        string m = Console.ReadLine();
        string[] mArr = m.Split(' ');
        ArrayList array = new ArrayList();

        for (int i = 0; i < nArr.Length || i < mArr.Length; i++)
        {
            if (i < nArr.Length)
            {
                array.Add(nArr[i]);
            }
            if (i < mArr.Length)
            {
                array.Add(mArr[i]);
            }
        }

        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i] + " ");
        }

    }

}
