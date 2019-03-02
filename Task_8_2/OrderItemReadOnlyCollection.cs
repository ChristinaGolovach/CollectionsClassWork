using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_8_2
{
    public class OrderItemReadOnlyCollection : ReadOnlyCollection<OrderItem>
    {
        public OrderItemReadOnlyCollection(IList<OrderItem> orderItems) : base(orderItems)
        {

        }
    }
}
