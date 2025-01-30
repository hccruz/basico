namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, res;

            Console.Write("Digite o primeiro valor: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            res = soma(v1, v2);
            Console.WriteLine("A soma de " + v1 + " + " + v2 + " é igual a " + res);
        }

        static void ola() 
        {
            Console.WriteLine("Olá, Mundo!");
            Console.WriteLine("Meu nome é Heraldo!");
            Console.WriteLine("Tenha um bom dia!");
        }

        static int soma(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
    }
}
