using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Magic<string> magic = new Magic<string>();
            var c = Console.ReadLine();

            magic.ADD(c);
            Console.WriteLine($"Your class magic:");
            magic.LookThrough();

            Console.WriteLine();

            c = Console.ReadLine();

            magic.ADD(c);
            Console.WriteLine($"Your class magic:");
            magic.LookThrough();
            magic.Delete("Legendary");
        }
    }
}
