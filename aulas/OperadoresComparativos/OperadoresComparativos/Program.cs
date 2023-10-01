namespace OperadoresComparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Comparativos
            // MAIOR E MENOR QUE < >
            int a = 10;
            bool resultado = a < 10;
            bool resultado2 = a < 20;
            bool resultado3 = a > 10;
            bool resultado4 = a > 5;

            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            // MAIOR OU IGUAL E MENOR OU IGUAL <= >=
            bool resultado5 = a >= 10;
            bool resultado6 = a <= 10;

            Console.WriteLine(resultado5);
            Console.WriteLine(resultado6);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            // IGUAL A
            bool resultado7 = a == 10;
            Console.WriteLine(resultado7);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            // DIFERENTE DE
            bool resultado8 = a != 5;
            Console.WriteLine(resultado8);
            #endregion
        }
    }
}