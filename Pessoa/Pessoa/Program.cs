using System;

class MainClass
{
    public static void Main (string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Heraldo";
        p1.Idade = 52;
        p1.Genero = 'M';
        // p1.Aprovado = false
        p1.MostrarDados();
    }
}