using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subjects
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
