//Да се напише програма, която дефинира клас Gilishte, определящ адрес, площ и цена на
//жилище, данните за всички жилища се съхраняват в масив от обекти. Дефинират се и класове Apartament
//с етаж и Kashta с размер на двор, наследници на Gilishte. Да се въведат n жилища от различен тип
//(апартамент или къща). Да се изведат всички жилища от даден тип, чиято цена е под дадена въведена
//стойност


using System;


class Jilishte
{
    public string address;
    public double plosht;
    public float price;
    public Jilishte(string x, double y, float z)
    {
        address = x;
        plosht = y;
        price = z;
    }
    public virtual string Type()
    {
        return "";
    }
    public virtual float Price()
    {
        return 0;
    }
    public virtual double Plosht()
    {
        return 0;
    }
}

class Apartment : Jilishte
{
    public int floor;
    public Apartment(string address, double plosht, float price, int floor) :
        base(address, plosht, price)
    {
        this.floor = floor;
    }
    public override string Type()
    {
        return "apartment";
    }
    public override float Price()
    {
        return price;
    }
    public override double Plosht()
    {
        return plosht;
    }

}

class House : Jilishte
{
    public float dworRazmer;
    public House(string address, double plosht, float price, float dworRazmer) :
        base(address, plosht, price)
    {
        this.dworRazmer = dworRazmer;
    }
    public override string Type()
    {
        return "house";
    }
    public override float Price()
    {
        return price;
    }
    public override double Plosht()
    {
        return plosht;
    }
}


class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        float cenaZaSrawnenie = float.Parse(Console.ReadLine());
        string address, type; double plosht; float price, dworRazmer; int floor;
        Jilishte[] arr = new Jilishte[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Address {i}: ");
            address = Console.ReadLine();
            Console.Write($"Plosht {i}:");
            plosht = double.Parse(Console.ReadLine());
            Console.Write($"Price {i}:");
            price = float.Parse(Console.ReadLine());
            Console.Write($"House or apartment? {i}:");
            type = Console.ReadLine();
            if ("house".Equals(type.ToLower()))
            {
                Console.Write($"Razmer na dwor {i}:");
                dworRazmer = float.Parse(Console.ReadLine());
                arr[i] = new House(address, plosht, price, dworRazmer);
            }
            else
            {
                Console.Write($"Etaj {i}:");
                floor = int.Parse(Console.ReadLine());
                arr[i] = new Apartment(address, plosht, price, floor);
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i].price < cenaZaSrawnenie)
            {
                Console.WriteLine(arr[i].Type() + " " + arr[i].Price());
            }
        }
    }
}
