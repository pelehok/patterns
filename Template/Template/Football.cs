using System;

namespace Template
{
    class Football : Game
    {
        protected override void Initilize(){
            Console.WriteLine("Football game Initialized! Start playing.");
        }

        protected override void StartPlay(){
            Console.WriteLine("Football game Started. Enjoy the game!");
        }

        protected override void EndPlay(){
            Console.WriteLine("Football game Finished!");
        }
    }
}