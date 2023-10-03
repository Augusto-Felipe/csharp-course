using System.Globalization;

namespace ProblemaSemPOO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidadas do triângulo X: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidadas do triângulo Y: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));
            
            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }  
}

