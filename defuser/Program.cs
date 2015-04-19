using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defuser
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonasManager pm = new PersonasManager();

            Persona p1 = pm.Personas["Izanagi"];
            Persona p2 = pm.Personas["Pyro Jack"];

            Persona result = pm.Fusion(p1, p2);

            Console.ReadKey();
        }
    }
}
