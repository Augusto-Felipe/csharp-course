
namespace ConversaoImplicitaECasting
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // CONVERSÃO IMPLÍCITA   
            /*
             A linguagem aceita que você atribua um valor do tipo float que vale 4 bytes
             dentro de uma variável do tipo double que vale 8 bytes.
            */
            float x = 4.5f; // -> 4 bytes
            double y = x; // -> 8 bytes

            Console.WriteLine(y);
            
            // CASTING -> Conversão Explícita
            /*
             Já para o contrário precisamos fazer uma conversão forçada com risco de perder
             infomrações.
            */
            double a = 6.7; // -> 8 bytes
            float b = (float)a; // -> 4 bytes

            Console.WriteLine(b);

            /*
             Isso também vale caso estejamos trabalhando com inteiros pois esperamos números
             quebrados.
            */
            double c = 3.2;
            int d = (int)c;

            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double)e / f;
            Console.WriteLine(resultado);

        }
    }
}

