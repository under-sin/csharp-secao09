using System;
using Program03.Entities;
using Program03.Entities.Enums;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            // transformando um enum em string
            string txt = OrderStatus.Processing.ToString();

            // transformando uma string em um enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
