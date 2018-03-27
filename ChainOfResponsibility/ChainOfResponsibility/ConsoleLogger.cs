using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConsoleLogger:AbstractLogger
    {
        public ConsoleLogger(int level){
            this.level = level;
        }

        protected override void write(string message){
            Console.WriteLine("Standart console::Logger "+message);
        }
    }
}
