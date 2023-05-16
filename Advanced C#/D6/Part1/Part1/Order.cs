using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public float Price { get; set; }
        public List<OrderItem> Items { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID:{Id}, Name: {Customer.Name}, Price: {Price}");
            sb.Append(Environment.NewLine);
            sb.Append("Items: ");
            sb.Append(Environment.NewLine);
            foreach (OrderItem item in Items)
            {
                sb.Append($"\t {item.Item.Name}, {item.Quantity}");
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
