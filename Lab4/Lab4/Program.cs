using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    class Program {
        static void Main(string[] args) {
            Set my = new Set();
            
            my++;
            my++;
            my++;
            
            Console.WriteLine(my.ToString());
         
            Set my3 = new Set();
            Set me = new Set();
            Set me2 = new Set();
            me.Elements.Add(me.Meth());
            me2.Elements.Add(me2.Meth2());
            my3 = me + me2;
            
            Console.WriteLine(my3.ToString());

            Set set = new Set();
            Set set1 = new Set();
            
            if (set1 <= set) {
                Console.WriteLine($"1");
            }
            else {
                Console.WriteLine($"0");
            }

            Set set3 = new Set();
            Set set4 = new Set();

            Console.WriteLine(set3 % set4);

            Set set5 = new Set();
            Set.Crypto(set5);

            SortedSet<char> ss = new SortedSet<char>();
            SortedSet<char> ss2 = new SortedSet<char>();
            ss.Add('Z');
            ss.Add('X');
            ss.Add('E');
            ss.Add('R');
            ss.Add('H');
            Set.ShowCollection(ss, "The first collection");

            Owner owner = new Owner(2, "Dima", "BSTU");
            Date date = new Date("08.07.1999");
            Console.WriteLine($"{owner.ID}\n{owner.Name}\n{owner.Organisation}\n{date.DateOfCreation}");

        }
    }
}
