using ProblemaComPOO.Entities;

namespace ProblemaComPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x;
            Triangulo y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.calcularArea();
            double areaY = y.calcularArea();

            if (areaX > areaY)
            {
                Console.WriteLine("Maior é X");
            }
            else
            {
                Console.WriteLine("Maior é Y");
            }
        }
    }
}