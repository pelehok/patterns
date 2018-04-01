namespace Template
{
    abstract class Game
    {
        protected abstract void Initilize();
        protected abstract void StartPlay();
        protected abstract void EndPlay();

        public void Play(){
            Initilize();
            StartPlay();
            EndPlay();
        }
    }
}