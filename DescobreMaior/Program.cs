namespace DescobreMaior
{
    internal class Program
    {
        static void DescobreMaior(List<int> lista)
        {
            int cont, maior;
            cont = maior = 0;
            Console.WriteLine("Analisando os valores passados...");
            foreach (int valor in lista)
            {
                Console.Write(valor + " ");
                Thread.Sleep(500);
                if (cont == 0)
                {
                    maior = valor;
                }
                else
                {
                    if (valor > maior)
                    {
                        maior = valor;
                    }
                }
                cont++;
            }
            Console.WriteLine($"\nForam informados {cont} valores ao todo.");
            Console.WriteLine("\nO maior valor informado foi " + maior);
        }

        static void Main(string[] args)
        {
            List<int> numeros = [2, 9, 4, 5, 7, 1];
            numeros.Add(10);
            DescobreMaior(numeros);
            List<int> num = [ 4, 7, 0 ];
            DescobreMaior(num);
            List<int> n = [ 1, 2 ];
            DescobreMaior(n);
            List<int> ns = [ ];
            DescobreMaior(ns);
        }
    }
}
