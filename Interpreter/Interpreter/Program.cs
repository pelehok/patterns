using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        public static IExpression GetMaleExpression(){
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert,john);
        }
        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        static void Main(string[] args){
            IExpression isMale = GetMaleExpression();
            IExpression isMerrMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? "+ isMale.interpret("John"));
            Console.WriteLine("Julie is a married woman?" + isMerrMarriedWoman.interpret("Married Julie"));

            Console.ReadKey();
        }
    }
}
