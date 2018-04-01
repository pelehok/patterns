﻿using System;

namespace Observer
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject){
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update(){
            Console.WriteLine("Binary string: " +
                              subject.State);
        }
    }
}