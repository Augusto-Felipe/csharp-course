using System.Drawing;

namespace TiposValorEReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? a = null;
            int? b = null;
            bool? c = null;

            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            else
            {
                Console.WriteLine("Não possui valor");
            }

            double x = a ?? 6;
            Console.WriteLine("VALOR DE X = " + x);

            Console.WriteLine(b.HasValue);
            Console.WriteLine(c.HasValue);

            Point p1 = new()
            {
                X = 10,
                Y = 20
            };

            Point p2 = new()
            {
                X = 10,
                Y = 20
            };

            p1 = p2;

            Console.WriteLine(p1);

            Method1();
        }

        static void Method1()
        {
            int x = 10;
            if (x > 10)
            {
                int y = 20;
            }

            Console.WriteLine(x);
        }
    }
}