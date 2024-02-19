using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Längst(x, y);
        }
        catch 
        {
            Console.WriteLine("Skriv det igen");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            Console.WriteLine("Längst var: " + Längst(x, y));
        }
    }
    static void Längst(int x,  int y)
    {
        string a = x.ToString();
        string b = y.ToString();
        Console.WriteLine("Längst var: "+ Längst(a, b)); 
    }
    static string Längst(string x, string y)
    {
        if(x.Length>=y.Length)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}
