using System;
using System.Collections.Generic;
using System.Text;

namespace Observable
{
    class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return this._subjectState; }
            set { this._subjectState = value; }
        }
    }
}
