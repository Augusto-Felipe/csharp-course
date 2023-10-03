using System.Globalization;

namespace Exercicios_Classes.Entities
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Altura + Largura);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }

        public override string ToString()
        {
            return $"AREA: {Area().ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"PERIMETRO: {Perimetro().ToString("F2", CultureInfo.InvariantCulture)} " +
                   $"DIAGONAL: {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
