namespace Visitor
{
    public class Computer : IComputerPart
    {
        private readonly IComputerPart[] _parts;

        public Computer(){
            this._parts = new IComputerPart[] {new Mouse(), new Keyoard(), new Monitor()};
        }

        public void Accept(IComputerPartVisitor computerPartVisitor){
            foreach (IComputerPart computerPart in _parts)
            {
                computerPart.Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}