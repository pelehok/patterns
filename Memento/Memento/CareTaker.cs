using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CareTaker
    {
        List<Memento> _mementoes = new List<Memento>();

        public void Add(Memento state){
            _mementoes.Add(state);
        }

        public Memento Get(int index){
            return _mementoes[index];
        }
    }
}