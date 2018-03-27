using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;
        protected int level { get; set; }
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger){
            this.nextLogger = nextLogger;
        }

        public void logMessage(int level, string message){
            if (this.level <= level)
            {
                write(message);
            }

            if (nextLogger != null)
            {
                nextLogger.logMessage(level,message);
            }
        }

        protected abstract void write(string message);
    }
}
