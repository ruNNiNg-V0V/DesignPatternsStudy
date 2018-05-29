using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sledge sledge = new Sledge();
            ActivateDron(new SledgeAdapter(sledge));
            Console.WriteLine(sledge.Dronning);

            Twich twich = new Twich();
            ActivateDron(new TwichAdapter(twich));
            Console.WriteLine(twich.Dronning);
        }

        private static void ActivateDron(IDronningAdapter adapter)
        {
            adapter.Dronning();
        }
    }
}
