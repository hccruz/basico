using System;

class MainClass
{
    public static void Main (string[] args)
    {
        Console.Write("Digite seu nome: ");
        string r1 = Console.ReadLine();
        Console.WriteLine($"O seu nome é {r1} e possui {ContarLetras(r1)} letras.");
        MostrarDados();
    }

    public static void MostrarDados()
    {
        Console.WriteLine("Estes são os dados:");
        Console.WriteLine("Rua Apalaches, 1612");
        Console.WriteLine("Santo André - SP");
        Console.WriteLine("CEP: 09270-470");
    }

    public static int ContarLetras(string palavra)
    {
        return palavra.Length;
    }
}