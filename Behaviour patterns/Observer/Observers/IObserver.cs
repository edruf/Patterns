using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    internal interface IObserver
    {
        void Update(ISubject subject);    
    }
}
