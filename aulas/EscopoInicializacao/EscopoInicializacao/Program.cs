namespace EscopoInicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Podemos declarar uma variável e depois inicializa-la com um valor
            int x;
            x = 10;

            // Podemos declarar uma variável e inicializa-la na mesma linha
            int y = 20;

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}