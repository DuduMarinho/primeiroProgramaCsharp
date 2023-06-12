internal class Program
{
    private static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);

        do
        {
            Console.WriteLine("Digite um número entre 1 e 100");
            int chute = int.Parse(Console.ReadLine());

            if (chute == numeroSecreto)
            {
                Console.WriteLine("Parabéns, você acertou");
                break;
            }
            else if (chute < numeroSecreto)
            {
                Console.WriteLine("O número é maior que o que você digitou.");
            }
            else
            {
                Console.WriteLine("O número é menor.");
            }
        } while (true);
    }
}