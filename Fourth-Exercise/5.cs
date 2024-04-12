//Да се напише програма, която дефинира клас MPS, определящ марка, модел и година на
//производство на МПС, данните за всички автомобили се съхраняват в масив от обекти. Дефинират се и
//класове наследници на MPS – Kamion с товароносимост, Autobus с брой места и Car с вид гориво. Да се
//въведат n на брой МПС от различен тип (камион, кола или автобус). Да се изведат всички МПС от даден
//тип, чиято година е след избраната от потребителя. 

using System;

class MPS
{
    public string marka;
    public int godina;
    public string model;
    public MPS(string mar, int god, string mod)
    {
        marka = marka;
        godina = god;
        model = mod;
    }
    public virtual string Type()
    {
        return "";
    }
    public virtual int Godina()
    {
        return 0;
    }
}

class Kamion : MPS
{
    public double towaronosimost;
    public Kamion(string mar, int god, string mod, double towar) : base(mar, god, mod)
    {
        towaronosimost = towar;
    }
    public override string Type()
    {
        return "kamion";
    }
    public override int Godina()
    {
        return godina;
    }
}
class Autobus : MPS
{
    public int mesta;
    public Autobus(string mar, int god, string mod, int mest) : base(mar, god, mod)
    {
        mesta = mest;
    }
    public override string Type()
    {
        return "autobus";
    }
    public override int Godina()
    {
        return godina;
    }

}
class Car : MPS
{
    public string widGoriwo;
    public Car(string mar, int god, string mod, string wid) : base(mar, god, mod)
    {
        widGoriwo = wid;
    }
    public override string Type()
    {
        return "car";
    }
    public override int Godina()
    {
        return godina;
    }

}



class MyClass
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter year for comparison: ");
        int godinaZaSrawnenie = int.Parse(Console.ReadLine());
        string marka, model, widGoriwo, type; int godina, mesta; double towaronosimost;
        MPS[] arr = new MPS[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Marka {i}: ");
            marka = Console.ReadLine();
            Console.Write($"Godina {i}: ");
            godina = int.Parse(Console.ReadLine());
            Console.Write($"Model {i}: ");
            model = Console.ReadLine();
            Console.Write($"Type {i}: ");
            type = Console.ReadLine();
            if ("car".Equals(type.ToLower()))
            {
                Console.Write($"Wid goriwo {i}: ");
                widGoriwo = Console.ReadLine();
                arr[i] = new Car(marka, godina, model, widGoriwo);

            }
            else if ("kamion".Equals(type.ToLower()))
            {
                Console.Write($"Towaronosimost {i}: ");
                towaronosimost = double.Parse(Console.ReadLine());
                arr[i] = new Kamion(marka, godina, model, towaronosimost);

            }
            else if ("autobus".Equals(type.ToLower()))
            {
                Console.Write($"Mesta {i}: ");
                mesta = int.Parse(Console.ReadLine());
                arr[i] = new Autobus(marka, godina, model, mesta);
            }


        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i].godina > godinaZaSrawnenie)
            {
                Console.WriteLine(arr[i].Type() + " " + arr[i].Godina());

            }
        }
    }
}
