using System.Globalization;

namespace TopicosEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INFERÊNCIA DE TIPOS -> PALAVRA VAR
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            var a = 'M';

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);

            // SWITCH CASE
            var resultado = 5;

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("3");
                    break;
            }

            // OPERADOR TERNÁRIO
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double desconto = (preco > 20.0) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);

            // FUNÇÕES PARA STRING
            string original = " abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(5, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xs");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf(''bc): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3): " + s5);
            Console.WriteLine("Replace('a', 'x'): " + s6);
            Console.WriteLine("Replace('abc', 'xs'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}