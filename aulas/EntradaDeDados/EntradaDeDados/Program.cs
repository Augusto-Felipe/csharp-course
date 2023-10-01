using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Entrada de Dados
            Console.WriteLine("Digite seus dados: ");
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("Você digitou: " + x);
            Console.WriteLine("Você digitou: " + y);
            Console.WriteLine("Você digitou: " + z);
            #endregion

            #region Comando Split
            Console.WriteLine("Digite as frutas");
            string[] lista1 = Console.ReadLine().Split(' ');

            string a = lista1[0];
            string b = lista1[1];
            string c = lista1[2];

            Console.WriteLine(a + " " + b + " " + c);
            #endregion

            #region Treinando
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string[] lista = Console.ReadLine().Split(' ');

            string nome = lista[0];
            char genero = char.Parse(lista[1]);
            int idade = int.Parse(lista[2]);
            double altura = double.Parse(lista[3]);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome + " " + genero + " " + idade + " " + altura);
            #endregion
        }
    }
}