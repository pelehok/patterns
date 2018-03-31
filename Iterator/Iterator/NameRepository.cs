using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Iterator
{
    class NameRepository:IContainer
    {
        public static string[] Names = {"Robert", "John", "Julie", "Lora"};

        public IIterator GetIterator(){
            return new NameIterator();
        }
        private class NameIterator:IIterator
        {
            private int index;

            public bool HasNext(){
                if (index < Names.Length)
                {
                    return true;
                }

                return false;
            }

            public object Next(){
                if (this.HasNext())
                {
                    return Names[index++];
                }

                return null;
            }
        }
    }
}
