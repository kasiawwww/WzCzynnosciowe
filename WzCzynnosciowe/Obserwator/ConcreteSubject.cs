using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Obserwator
{
    class ConcreteSubject : Subject
    {
        public ConcreteSubject(string subjectState)
        {
            SubjectState = subjectState;
        }
        public string SubjectState { get; set; }
    }
}
