using System;

public class Produto
{
	private string nome;

	public string Nome
	{
		get
		{
			return nome;
		}
		set
		{
			if (value.Length > 1)
				nome = value;
			else
				throw new ArgumentException("Nome do produto deve er pelo menos 2 caracteres.");
		}
	}

	public double Preco { get; set; }

	public int Estoque { get; private set; }
}