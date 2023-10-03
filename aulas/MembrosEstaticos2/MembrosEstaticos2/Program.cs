using MembrosEstaticos2.Entities;
using System.Globalization;

namespace MembrosEstaticos2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Calculadora.Pi);
        }
    }
}