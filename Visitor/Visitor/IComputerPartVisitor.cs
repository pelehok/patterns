namespace Visitor
{
    public interface IComputerPartVisitor
    {
        void Visit(Keyoard keyoard);
        void Visit(Monitor keyoard);
        void Visit(Mouse keyoard);
        void Visit(Computer keyoard);
    }
}