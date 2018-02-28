using Factory.Factory_classes;
using Factory.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class FactoryPatternDemo
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.getShape("Circle");
            shape1.draw();

            IShape shape2 = shapeFactory.getShape("Rectangle");
            shape2.draw();

            IShape shape3 = shapeFactory.getShape("Square");
            shape3.draw();
            Console.ReadKey();
        }
    }
}
