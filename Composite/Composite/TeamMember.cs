using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TeamMember : Employee

    {
        public TeamMember(string name, double salary) : base(name, salary) { }
        public override void Add(Employee employee){}
        public override void Remove(Employee employee){}
        public override string GetData() => "Name: " + name + "\tSalary: " + salary.ToString("N2");

    }
}
