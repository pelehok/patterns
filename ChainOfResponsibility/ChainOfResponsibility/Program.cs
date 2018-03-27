using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);
            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);
            return errorLogger;
        }
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainOfLoggers();
            loggerChain.logMessage(AbstractLogger.INFO,
                "This is an information.");
            loggerChain.logMessage(AbstractLogger.DEBUG,
            "This is a debug level information.");
            loggerChain.logMessage(AbstractLogger.ERROR,
                "This is an error information.");
            Console.ReadKey();
        }
    }
}
