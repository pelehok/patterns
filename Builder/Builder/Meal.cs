using Builder.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Meal
    {
        private List<IItem> items = new List<IItem>();
        public void addItem(IItem item)
        {
            items.Add(item);
        }
        public double getCost()
        {
            double cost = 0.0;
            foreach(IItem item in items)
            {
                cost += item.price();
            }
            return cost;
        }
        public void showItems()
        {
            foreach(IItem item in items)
            {
                Console.Write("Item : " + item.name());
                Console.Write(", Packing : " + item.packing().pack());
                Console.WriteLine(", Price : " + item.price());
            }
        }
    }
}
