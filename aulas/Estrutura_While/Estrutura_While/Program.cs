using System.Globalization;

namespace Estrutura_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0.0)
            {
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro numero: ");
                n = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");
        }
    }
}