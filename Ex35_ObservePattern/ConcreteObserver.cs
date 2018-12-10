using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObservePattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int observerState;

        public int State
        {

            get { return observerState; }
            set { observerState = value; }

        }

        public ConcreteObserver(ConcreteSubject subject)
        {
           this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.State;         
        }
    }
}
