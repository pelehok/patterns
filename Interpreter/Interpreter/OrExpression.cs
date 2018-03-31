using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class OrExpression:IExpression
    {
        private IExpression _expr1 = null;
        private IExpression _expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2){
            this._expr1 = expr1;
            this._expr2 = expr2;
        }

        public bool interpret(string context){
            return _expr1.interpret(context) || _expr2.interpret(context);
        }
    }
}
