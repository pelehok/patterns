using Factory.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory_classes
{
    class ShapeFactory
    {
        public IShape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
