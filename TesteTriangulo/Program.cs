namespace TesteTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32((Console.ReadLine()));

            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
        }
    }
}
