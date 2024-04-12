//Да се напише програма, която въвежда данните за стоките в клас стоки с полета име,
//производител, цена, нал.количество. Да се създаде втори клас за производителите с полета име, държава.
//Да се изведе за всяка стока в коя държава е произведена и на каква стойност са наличностите в склада.

using System;

class Stoka
{
    public string ime, proizwoditel;
    public double cena;
    public int nalichnost;
    private Proizwoditel proiz;

    public Stoka(string name, string maker, double cena, int nalichnost, Proizwoditel p)
    {
        ime = name;
        proizwoditel = maker;
        this.cena = cena;
        this.nalichnost = nalichnost;
        this.proiz = p;
    }

    public double PriceForQuantity()
    {
        return cena * nalichnost;
    }
    public string GetCountry()
    {
        return proiz.dyrjawa;
    }
}

class Proizwoditel
{
    public string ime, dyrjawa;

    public Proizwoditel(string ime, string dyrjawa)
    {
        this.ime = ime;
        this.dyrjawa = dyrjawa;
    }
}



class MyClass
{
    static void Main()
    {
        Proizwoditel[] pr = new Proizwoditel[3];
        pr[0] = new Proizwoditel("MAC", "USA");
        pr[1] = new Proizwoditel("Leki", "Bulgaria");
        pr[2] = new Proizwoditel("Coca-Cola", "UK");
        Console.Write($"Enter N: ");
        int n = int.Parse(Console.ReadLine());

        string ime, proiz;
        double cena;
        int nalichnost;

        Stoka[] arr = new Stoka[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter name -{i}: ");
            ime = Console.ReadLine();
            Console.Write($"Enter cena -{i}: ");
            cena = double.Parse(Console.ReadLine());
            Console.Write($"Enter nalichnost -{i}: ");
            nalichnost = int.Parse(Console.ReadLine());
            do
            {
                Console.Write($"Choose proizwoditel (Leki, MAC, Coca-Cola) -{i}: ");
                proiz = Console.ReadLine();
            } while ("mac" != proiz.ToLower() && "coca-cola" != proiz.ToLower()
            && "leki" != proiz.ToLower());
            int j;
            for (j = 0; j < pr.Length; j++)
            {
                if (pr[j].ime.ToLower() == proiz.ToLower()) break;
            }
            arr[i] = new Stoka(ime, proiz, cena, nalichnost, pr[j]);


        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Stoka {arr[i].ime} e proizwedena w {arr[i].GetCountry()} " +
                $"i struwa {arr[i].PriceForQuantity()} za nalichnostta si.");
        }

    }
}