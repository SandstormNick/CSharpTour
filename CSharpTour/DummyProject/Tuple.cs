using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyProject
{
    internal class IAmATuple
    {
        public IAmATuple()
        {
            (double Sum, int Count) t1 = (4.5, 3);
            Console.WriteLine($"Sum of {t1.Count} elements is {t1.Sum}.");

            (double Sum, int Count) = (4.5, 3);
            Console.WriteLine($"Sum of {Count} elements is {Sum}.");

            Tuple<double, int> t2 = new Tuple<double, int>(4.5, 3);
            Console.WriteLine($"Sum of {t2.Item2} elements is {t2.Item1}.");

            //Output:
            //Sum of 3 elements is 4.5.
        }
    }
}
