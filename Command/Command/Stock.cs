using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Stock
    {
        private string _name = "ABS";
        private int _quantity = 10;

        public void buy(){
            Console.WriteLine("Stock [ Name : " + _name + "," +
                              "Quantity : " + _quantity + " ] bought");
        }

        public void sell(){
            Console.WriteLine("Stock [ Name : " + _name + "," +
                              "Quantity : " + _quantity + " ] sold");
        }
    }
}