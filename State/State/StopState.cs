using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class StopState:IState
    {
        public void DoAction(Context context){
            Console.WriteLine("Player is in stop state");
            context.State = this;
        }

        public override string ToString(){
            return "Stop State";
        }
    }
}
