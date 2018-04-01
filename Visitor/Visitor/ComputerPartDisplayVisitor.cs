using System;

namespace Visitor
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Keyoard keyoard){
            Console.WriteLine("Displaying Keyoard");
        }

        public void Visit(Monitor keyoard){
            Console.WriteLine("Displaying Monitor");
        }

        public void Visit(Mouse keyoard){
            Console.WriteLine("Displaying Mouse");
        }

        public void Visit(Computer keyoard){
            Console.WriteLine("Displaying Computer");
        }
    }
}