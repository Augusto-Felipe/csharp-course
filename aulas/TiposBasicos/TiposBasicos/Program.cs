using System;

namespace TiposBasicos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Tipo C# VS Tipo .NET Framework
            /* 
             Quando temos o tipo escrito com letra maiúscula estamos usando o tipo do .NET
             e por este motivo PRECISAMOS importar o System acima.
            */
            SByte x = 100;
            Console.WriteLine(x);

            /* 
             * Já Quando temos o tipo escrito com letra minúscula estamos usando o tipo do C#
             e por este motivo NÃO PRECISAMOS importar o System acima.
            */
            #endregion

            #region Overflow
            /*
             Ao extrapolar o limite que a variável do tipo byte comporta numeros de 0 a 255, o mesmo
             vai valer o seu valor oposto que no caso é 0  
            */
            byte n1 = 255;
            n1++;
            Console.WriteLine(n1);
            /*
             Ao extrapolar o limite que a variável do tipo sbyte comporta numeros de -128 a 127, o mesmo
             vai valer o seu valor oposto que no caso é -128  
            */
            sbyte n2 = 127;
            n2++;
            Console.WriteLine(n2);
            #endregion

            #region Criação de variáveis
            int n3 = 1000;
            int n4 = 2147483647;
            bool completo = false;
            char genero = 'F';
            float n5 = 4.5f;
            string nome = "Maria";
            nome = "João";
            object obj1 = "Alex";
            object obj2 = 4.5f;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(int.MinValue);
            #endregion

        }
    }
}

