using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subjects
{
    internal interface IObserver
    {
        void Update(ISubject subject);    
    }
}
