using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class StartState:IState
    {
        public void DoAction(Context context){
            Console.WriteLine("Player is in start state");
            context.State = this;
        }

        public override String ToString(){
            return "Start State";
        }
    }
}
