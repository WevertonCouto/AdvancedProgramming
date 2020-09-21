using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new TeamMember("José", 140.0);
            Employee em2 = new TeamMember("Marcos", 150.0);

            Employee team = new TeamLead("TeamOne", 501.0);
            team.Add(em1);
            team.Add(em2);

            Console.WriteLine(team.GetData());
        }
    }
}
