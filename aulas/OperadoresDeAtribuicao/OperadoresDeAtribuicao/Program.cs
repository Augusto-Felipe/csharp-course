namespace OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores de Atribuição
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string nome = "Felipe";
            nome += "Augusto";

            Console.WriteLine(nome);
            #endregion

            #region Operador Aritméticos de Atribuição
            int b = 10;
            b++;
            Console.WriteLine(b);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 15;
            Console.WriteLine(++e);
            #endregion

        }
    }
}