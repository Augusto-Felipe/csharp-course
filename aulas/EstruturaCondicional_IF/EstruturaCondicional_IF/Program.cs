namespace EstruturaCondicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF 
            /*
            int x = 10;

            Console.WriteLine("Bom dia");

            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }


            Console.WriteLine("Boa noite");
            */
            #endregion

            #region IF ELSE
            /*
            Console.Write("Entre com um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */
            #endregion

            #region Encadeamentos
            Console.Write("Digite a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora <= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            #endregion
        }
    }
}