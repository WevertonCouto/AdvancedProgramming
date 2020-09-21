using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TeamLead : Employee
    {
        List<Employee> employees = new List<Employee>();

        public TeamLead(string name, double salary) : base(name, salary) { }

        public override void Add(Employee employee) => employees.Add(employee);
        public override string GetData()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var emp in employees)
            {
                sb.Append(emp.GetData() + "\n");
            }
            return sb.ToString();
        }

        public override void Remove(Employee employee) => employees.Remove(employee);
    }
}
