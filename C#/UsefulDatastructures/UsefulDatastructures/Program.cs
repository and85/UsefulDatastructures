using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulDatastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickUnionUFUsage();

            Console.ReadLine();
        }

        private static void QuickUnionUFUsage()
        {
            Console.WriteLine("QuickUnionUF stated...");
            var uf = new QuickUnionUF(5);
            
            Console.WriteLine($"Number of separaterd components: {uf.Count}");

            int p = 0;
            int q = 1;

            // if not in the same component, then union
            if (uf.Find(p) != uf.Find(q))
            {
                uf.Uunion(p, q);
            }

            Console.WriteLine($"Number of separaterd components: {uf.Count}");

            Console.WriteLine("QuickUnionUF finished");
        }
    }
}
