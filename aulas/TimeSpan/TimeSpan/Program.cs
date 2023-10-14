namespace TimeSpanLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTRUTORES
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(2, 1, 30);
            TimeSpan t3 = new TimeSpan(90000l);
            TimeSpan t4 = new TimeSpan(1, 2, 45, 23);
            TimeSpan t5 = new TimeSpan(1, 2, 34, 23, 321);
            
            // FROM
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromSeconds(1.5);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
        }
    }
}