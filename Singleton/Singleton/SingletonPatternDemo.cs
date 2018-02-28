using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonPatternDemo
    {
        static void Main(string[] args)
        {
            SingleObject obj = SingleObject.getInstance();

            obj.ShowMessage();
            Console.ReadKey(); 
        }
    }
}
