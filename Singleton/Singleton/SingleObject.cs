using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject getInstance()
        {
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
