using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static double Pi = 3.14;

        public static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Pi);
        }

        static double Circunferencia(double raio)
        {
            return Pi * raio * 2.0;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}

