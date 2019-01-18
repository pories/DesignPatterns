using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject sub)
        {
            subject = sub;
        }

        public void Update()
        {
            string subjectState = subject.GetState();
            Console.WriteLine(subjectState);
        }
    }
}
