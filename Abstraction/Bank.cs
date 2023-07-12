using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
    internal abstract class atm
    {
        public void WithdrawMoney()
        {
            Console.WriteLine("We can withdraw money from ATM machine");
        }
        public abstract void ConnectingToBackEnd();

    }
}
