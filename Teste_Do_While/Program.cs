namespace Teste_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhaDigitada;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
            } while (senha != senhaDigitada);

            Console.WriteLine("Senha correta!");
        }
    }
}
