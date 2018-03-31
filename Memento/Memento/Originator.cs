﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemento(){
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento){
            State = memento.State;
        }
    }
}