using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
