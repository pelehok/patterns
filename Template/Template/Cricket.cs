using System;

namespace Template
{
    class Cricket : Game
    {
        protected override void Initilize(){
            Console.WriteLine("Cricket game Initialized! Start playing.");
        }

        protected override void StartPlay(){
            Console.WriteLine("Cricket game Started. Enjoy the game!");
        }

        protected override void EndPlay(){
            Console.WriteLine("Cricket game Finished!");
        }
    }
}