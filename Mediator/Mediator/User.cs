using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class User
    {
        public User(string name){
            Name = name;
        }

        public string Name { get; set; }

        public void SendMessage(string message){
            CharRoom.ShowMessage(this,message);
        }
    }
}
