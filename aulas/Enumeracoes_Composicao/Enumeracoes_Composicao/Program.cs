using Enumeracoes_Composicao.Entitites;
using Enumeracoes_Composicao.Entitites.Enums;

namespace Enumeracoes_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(127, DateTime.Now, OrderStatus.Processing);

            Order order2 = new Order
            {
                Id = 128,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
            Console.WriteLine(order2);

            // ENUM PARA STRING
            string enumTxt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(enumTxt);

            // STRING PARA ENUM
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            
        }
    }
}