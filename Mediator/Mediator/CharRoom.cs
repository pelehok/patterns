using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CharRoom
    {
        public static void ShowMessage(User user, string message){
            Console.WriteLine(new DateTime() +
                              " [ "+user.Name + " ] : "+message);
        }
    }
}
