using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    class Subject : ISubject
    {
        public int State { get; set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
