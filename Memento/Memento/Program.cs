using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Teste";
            s.Phone = "(00) 00000-0000";
            s.Budget = 25000.0;


            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Teste 2";
            s.Phone = "(00) 0000-0000";
            s.Budget = 1000000.0;

            s.RestoreMemento(m.Memento);


            Console.ReadKey();
        }
    }
}
