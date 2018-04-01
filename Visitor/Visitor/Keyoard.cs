namespace Visitor
{
    public class Keyoard:IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor){
            computerPartVisitor.Visit(this);
        }
    }
}
