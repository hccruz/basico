namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contador(1, 10, 1);
            contador(10, 0, 2);
            Console.WriteLine();

            Escrever("Agora é sua vez de personalizar a contagem!");
            Console.Write("Início: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fim: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Passo: ");
            int passo = Convert.ToInt32(Console.ReadLine());
            contador(inicio, fim, passo);
        }

        static void contador(int i, int f, int p)
        {

            Escrever($"Contagem de {i} até {f} de {p} em {p}.");
            Thread.Sleep(2000);
            if (p < 0)
            {
                p *= -1;
            }
            if (p == 0)
            {
                Console.WriteLine("Impossível contar!");
                return;
            }

            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont += p;
                }
                Console.WriteLine("Fim!");
            }
            else
            {
                int cont = i;
                while (cont >= f)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -= p;
                }
                Console.WriteLine("Fim!");
            }
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine($"{textoCentralizado}");
            Console.WriteLine(linha);
        }
    }
}
