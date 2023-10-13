using ModificadoresDeParametros.Entities;

namespace ModificadoresDeParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARAMNS
            int resultado = Calculator.Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine("SOMA = " + resultado);

            // REF E OUT
            int a = 10;
            int resposta;
            //Calculator.Triplicar(ref a);
            //Console.WriteLine(a);

            Calculator.Triplicar(a, out resposta);
            Console.WriteLine("RESPOSTA = " + resposta);
        }
    }
}