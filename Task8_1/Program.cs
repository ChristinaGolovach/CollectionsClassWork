using System;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var orderItems = new OrderItemCollection
            {
                new OrderItem(110072674, "Widget", 400, 45.17),
                new OrderItem(110072675, "Sprocket", 27, 5.3),
                new OrderItem(101030411, "Motor", 10, 237.5),
                new OrderItem(110072684, "Gear", 175, 5.17)
            };

            order.AddRange(orderItems);

            var newItem = new OrderItem(110072674, "Widget", 400, 45.17);

            order.OrderItems.AddItem(newItem);

            order.OrderItems.RemoveItem(newItem);

            Console.ReadLine();
        }
    }
}
