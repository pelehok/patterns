using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Broker
    {
        private List<Order> orders = new List<Order>();

        public void takeOrder(Order order){
            orders.Add(order);
        }

        public void placeOrders(){
            foreach (Order order in orders)
            {
                order.execute();       
            }
            orders.Clear();
        }
    }
}
