//Въвежда се дума от потребителя. Да се напише програма, която връща броят на гласните
//в нея. (Гласни са а, е, и, о, у, ъ, ю, я)
using System;

class MyClass
{
    static void Main()
    {
        string word = "";
        Console.WriteLine("Enter word: ");
        word = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    count++;
                    break;
                default:
                    continue;
            }
        }
        Console.WriteLine($"Vowel letters are: {count}");
    }
}
