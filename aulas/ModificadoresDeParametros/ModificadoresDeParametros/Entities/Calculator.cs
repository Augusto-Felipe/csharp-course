namespace ModificadoresDeParametros.Entities
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static void Triplicar(int origin, out int result)
        {
            result = origin * 3;
        }

        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

    }
}