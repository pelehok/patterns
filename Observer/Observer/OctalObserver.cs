using System;

namespace Observer
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject){
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update(){
            Console.WriteLine("Octal string: " +
                              subject.State);
        }
    }
}