using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymarphism
{
    class Addition
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Sum: " + z);
        }

        //
        public static void Add(int x, int y, int z)
        {
            int res = x + y;
            Console.WriteLine("Sum" + res);
        }

        //
        public static void Add(int x, int y, double z)
        { 
            double res = x + y + z;
            Console.WriteLine("Sum" + res);
        }

        public static void Add(int x, long y, int z)
        {
            long res = x + y + z;
            Console.WriteLine("Sum" + res);
        }
    }
}
        
