//Да се напише програма, която дефинира клас Cat. Класът да съхранява данни за паспорт,
//име, порода, възраст, стопанин, пол. Да се извеждат данните за всички котки от определeна въведена
//порода и пол, които са под определена възраст

using System;

class Cat
{
    private string name, breed, owner, gender;
    private int age;

    public Cat(string ime, string poroda, int wyzrast, string stopanin, string pol)
    {
        name = ime;
        breed = poroda;
        age = wyzrast;
        owner = stopanin;
        gender = pol;
    }

    public string getBreed()
    {
        return breed;
    }
    public string getGender()
    {
        return gender;
    }
    public int getAge()
    {
        return age;
    }
}


class MyClass
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter age for comparison: ");
        int ageForComparison = int.Parse(Console.ReadLine());
        Cat[] arr = new Cat[n];
        string name, breed, owner, gender; int age;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter a name -{i}: ");
            name = Console.ReadLine();
            Console.Write($"Enter a breed -{i}: ");
            breed = Console.ReadLine();
            Console.Write($"Enter the owner -{i}: ");
            owner = Console.ReadLine();
            Console.Write($"Enter its gender -{i}: ");
            gender = Console.ReadLine();
            Console.Write($"Enter age -{i}: ");
            age = int.Parse(Console.ReadLine());
            arr[i] = new Cat(name, breed, age, owner, gender);
        }
        Console.WriteLine($"Cats under the age of {ageForComparison}:");
        for (int i = 0; i < n; i++)
        {
            if (arr[i].getAge() < ageForComparison)
            {
                Console.WriteLine($"Breed: {arr[i].getBreed()}, Gender: {arr[i].getGender()}");
            }
        }
    }
}