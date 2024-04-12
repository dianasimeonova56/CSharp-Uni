//Да се напише програма, която чете n изречения. За целта да се дефинира клас Sentence,
//който освен изречението да съхранява и броя на думите в него, както и най-дългата дума в него. Да се
//изведе изречението с най-много думи и това с най-дълга дума.


using System;

class Sentence
{
    public string s;
    public string longest;
    public int count;
    public string[] words;
    private char[] separator = { ',', ' ', '.' };
    public Sentence(string sent)
    {
        s = sent;
    }

    public void PrintSentence()
    {
        Console.WriteLine(s);
    }

    public int CountWords()
    {
        words = s.Split(separator, StringSplitOptions.TrimEntries);
        for (int i = 0; i < words.Length; i++)
        {
            count++;
        }
        return count;
    }

    public string GetLongestWord()
    {
        words = s.Split(separator, StringSplitOptions.TrimEntries);
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i - 1].Length > words[i].Length)
            {
                longest = words[i - 1];
            }
            else
            {
                longest = words[i];
            }
        }
        return longest;
    }

}


class MyClass
{
    static void Main()
    {
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Sentence[] arr = new Sentence[n];
        string sentence = "", longestSentence = "", longestWord = "";
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter a sentence number {i}: ");
            sentence = Console.ReadLine();
            arr[i] = new Sentence(sentence);
        }

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1].CountWords() > arr[i].CountWords()) longestSentence = arr[i - 1].s;
            else longestSentence = arr[i].s;
            if (arr[i - 1].GetLongestWord().Length > arr[i].GetLongestWord().Length) longestWord = arr[i - 1].s;
            else longestWord = arr[i].s;
        }
        Console.WriteLine("Sentence with most words: ");
        Console.WriteLine(longestSentence);
        Console.WriteLine("Sentence with longest word: ");
        Console.WriteLine(longestWord);
    }
}
