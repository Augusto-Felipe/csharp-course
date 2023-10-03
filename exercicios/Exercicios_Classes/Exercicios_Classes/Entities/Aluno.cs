using System.Globalization;

namespace Exercicios_Classes.Entities
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public void CalcularMedia()
        {
            double notaFinal = N1 + N2 + N3;

            if (notaFinal >= 60)
            {
                Console.WriteLine("NOTA FINAL: " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {60.00 - notaFinal} PONTOS");
            }
        }
    }
}
