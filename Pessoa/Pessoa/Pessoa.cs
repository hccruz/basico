using System;

public class Pessoa
{
	public string Nome;
	public int Idade;
	public char Genero;
	private bool Aprovado;
	
	public void MostrarDados()
	{
		Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Aprovado: {Aprovado}");
    }
}