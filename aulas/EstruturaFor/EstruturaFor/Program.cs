namespace EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int qnt = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 0; i < qnt; i++)
            {
                Console.Write($"Valor #{i+1}: ");
                int n = int.Parse(Console.ReadLine());
                soma += n;
            }

            Console.WriteLine("SOMA = " + soma);
        }
    }
}