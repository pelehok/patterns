using System.Collections.Generic;

namespace Observer
{
    class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();
        private int _state;

        public int State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(Observer observer){
            _observers.Add(observer);
        }

        public void NotifyAllObservers(){
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}