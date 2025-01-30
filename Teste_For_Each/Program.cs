namespace Teste_For_Each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3] { 11, 22, 33 };

            /*for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }*/

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            string[] nomes = new string[3] { "João", "Maria", "José" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
