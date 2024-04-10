//Въвеждат се имената на пет фирми. Като резултат да се изведат тези от тях, чиито имена
//съдържат цифра. Нека да се изведат на един ред разделени с интервал.
using System;

class MyClass
{
    static void Main()
    {
        string firma = "", toPrint = ""; ; bool hasDigits = false;
        for (int i = 0; i < 5; i++)
        {
            firma = Console.ReadLine();
            for (int j = 0; j < firma.Length; j++)
            {
                if (char.IsDigit(firma[j]))
                {
                    hasDigits = true; break;
                }
                else
                {
                    hasDigits = false;
                }
            }
            if (hasDigits)
            {
                if (i == 4)
                {
                    toPrint += firma;
                }
                else
                {
                    toPrint += firma + " ";
                }
            }

        }
        Console.WriteLine(toPrint);

    }
}
