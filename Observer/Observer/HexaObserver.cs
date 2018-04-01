using System;

namespace Observer
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject){
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update(){
            Console.WriteLine("Hex string: " +
                              subject.State);
        }
    }
}