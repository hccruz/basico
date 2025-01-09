using System;

class MainClass
{
    public static void Main (string[] args)
    {
        int n1 = 5;
        double n2 = 3.4;
        string s1 = "Heraldo Candido da Cruz";
        char c1 = '@';
        Console.WriteLine ($"{n1}, {n2}, {s1}, {c1}");
        double n3 = n1 + n2;
        Console.WriteLine($"A soma é {n3:F4}.");
        bool ehPar = (n1 % 2 == 0);
        if (ehPar)
        {
            Console.WriteLine("O número é par.");
        }
        else {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
