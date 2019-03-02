using System;
using System.Collections.ObjectModel;

namespace Task_8_2
{
    public class OrderItemCollection : Collection<OrderItem>
    {
        public event EventHandler<ItemCollectionEventArgs> OrderItemAdded = delegate { };

        public event EventHandler<ItemCollectionEventArgs> OrderItemRemoved = delegate { };

        public void AddItem(OrderItem orderItem)
        {
            base.Add(orderItem);

            OnOrderItemAdded(new ItemCollectionEventArgs(orderItem));
        }

        public void RemoveItem(OrderItem orderItem)
        {
            base.Remove(orderItem);

            OnOrderItemRemoved(new ItemCollectionEventArgs(orderItem));
        }

        protected virtual void OnOrderItemAdded(ItemCollectionEventArgs eventArgs)
        {
            OrderItemAdded.Invoke(this, eventArgs);
        }

        protected virtual void OnOrderItemRemoved(ItemCollectionEventArgs eventArgs)
        {
            OrderItemRemoved.Invoke(this, eventArgs);
        }
    }

    public class ItemCollectionEventArgs : EventArgs
    {
        public OrderItem OrderItem { get; }

        public ItemCollectionEventArgs(OrderItem orderItem)
        {
            OrderItem = orderItem;
        }
    }
}
