using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                string name = (string) iter.Next();
                Console.WriteLine("Name: "+name);
            }

            Console.ReadKey();
        }
    }
}
