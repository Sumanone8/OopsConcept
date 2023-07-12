using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
    internal class SBIAtm : atm
    {
        public override void ConnectingToBackEnd()
        {
            // Implementation specific to SBIAtm
            Console.WriteLine("Connecting to SBI back-end system...");
        }
    }
}

