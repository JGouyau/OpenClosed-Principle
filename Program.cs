using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle
{
    class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            IEnumerable<Craftable> craftables = new List<Craftable>
            {
                new Wood(),
                new Metal()
            };

            Production production = factory.Craft(craftables);

            Console.WriteLine(production);
            Console.ReadKey();
        }
    }
}
