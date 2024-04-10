//Ще ви бъде даден брой вагони във влак n. На следващите n реда ще получите колко души
//ще се качат на всеки вагон(писане на конзолата).В края отпечатайте целия влак (масива) и след това, а на
//следващия ред, сбора на хората във влак. 
using System;

class MyClass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0, num = 0;
        Console.WriteLine($"Enter num of people {n} times");
        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            arr[i] = num;
            sum += num;
        }
        foreach (int el in arr)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine($"Sum of all people is {sum}");

    }

}

