using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<OrderItem> Items { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
