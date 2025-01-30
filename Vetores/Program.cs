namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;

            int[] n = new int[5];

            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;

            Console.WriteLine(n[0]);

            double[] num = new double[3] { 2.4, 4.5, 6.7 };

            Console.WriteLine(num[2]);

            string[] nomes = {"Heraldo", "Renata", "Giovane"};

            Console.WriteLine(nomes[1]);

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = i + 1;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            string[] frutas = new string[10] {"banana", "laranja", "abacaxi", "manga", "limão", "melancia", "goiaba", "mamão", "abacate", "pera"};

            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    Console.Write(frutas[i] + ", ");
                }
                else
                {
                    Console.WriteLine(frutas[i] + ".");
                }
            }

            double num_maior = num.Max();
            double num_menor = num.Min();

            Console.WriteLine("Maior número: " + num_maior);
            Console.WriteLine("Menor número: " + num_menor);

            string fruta_maior = frutas.Max();
            string fruta_menor = frutas.Min();

            Console.WriteLine("Maior fruta: " + fruta_maior);
            Console.WriteLine("Menor fruta: " + fruta_menor);

            frutas.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
