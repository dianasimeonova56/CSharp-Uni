//Въвежда се поредица от думи. Да се напише програма, която извежда списък, който
//съдържа само пет-символните думи. Да се преброят думите, които съдържат главна буква в списъка. Да
//се използва ArrayList.
using System;
using System.Collections;


class MyClass
{
    static void Main()
    {
        ArrayList words = new ArrayList();
        string word = "", currWord = ""; int count = 0;
        ArrayList fiveCharWords = new ArrayList();

        while (word != "end")
        {
            word = Console.ReadLine();
            words.Add(word);
            if (word.ToCharArray().Length == 5)
            {
                fiveCharWords.Add(word);
            }
            if (word.Any(char.IsUpper))
            {
                count++;
            }
        }
        Console.WriteLine("Words containing 5 chars are: ");
        for (int i = 0; i < fiveCharWords.Count; i++)
        {
            Console.WriteLine(fiveCharWords[i] + " ");
        }
        Console.WriteLine($"Words with uppercase letters are found: {count} times");

    }

}
