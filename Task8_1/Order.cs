using System;
using System.Collections.Generic;

namespace Task8_1
{
    public class Order
    {
        private readonly OrderItemCollection _orderItems;

        public OrderItemCollection OrderItems
        {
            get
            {
                return _orderItems;
            }
        }

        public Order()
        {
            _orderItems = new OrderItemCollection();
            _orderItems.OrderItemAdded += _orderItems_OrderItemAdded;
            _orderItems.OrderItemRemoved += _orderItems_OrderItemRemved;
        }

        public void AddRange(IEnumerable<OrderItem> orderItems)
        {
            if (orderItems == null)
            {
                throw new ArgumentNullException($"The input collection {nameof(orderItems)} is null.");
            }

            AddItems(orderItems);
        }

        private void AddItems(IEnumerable<OrderItem> orderItems)
        {
            foreach (var item in orderItems)
            {
                _orderItems.AddItem(item);
            }
        }

        private void _orderItems_OrderItemAdded(object sender, ItemCollectionEventArgs e)
        {
            Console.WriteLine($"The item with number {e.OrderItem.PartNumber} is added.");
        }

        private void _orderItems_OrderItemRemved(object sender, ItemCollectionEventArgs e)
        {
            Console.WriteLine($"The item with number {e.OrderItem.PartNumber} is removed.");
        }
    }
}
