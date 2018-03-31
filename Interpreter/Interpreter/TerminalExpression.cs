using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class TerminalExpression:IExpression
    {
        private string _data;

        public TerminalExpression(string data){
            this._data = data;
        }
        public bool interpret(string context){
            if (context.Contains(_data))
            {
                return true;
            }

            return false;
        }
    }
}
