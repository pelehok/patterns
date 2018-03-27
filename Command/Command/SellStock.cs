using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class SellStock : Order
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock){
            _abcStock = abcStock;
        }

        public void execute(){
            _abcStock.sell();
        }
    }
}