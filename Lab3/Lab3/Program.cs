using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3 {
    class Program {
        static void Main(string[] args) {


            Circle circle = new Circle();
            Circle circle2 = new Circle(0,0,-4);
            

            var STatic = Circle.Data;
            
            var anonymous = new { People = 73, Deaths = 0, LifeExpc = "100 years" };
            Console.WriteLine($"{anonymous.People} {anonymous.Deaths} {anonymous.LifeExpc}");

            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle2.ToString());

            Console.WriteLine($"Area of circle : {circle.Area(0)}");
            Console.WriteLine($"Length of circle : {circle.Length(1)}");

            Console.WriteLine($"Hash of 1st object: {circle.GetHashCode()}");
            Console.WriteLine($"Hash of 2nd object: {circle2.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Do objects equal? {circle.Equals(circle2)}");
          

            Console.WriteLine();
            

            //TODO: y = kx + b 

            Circle[] objs = new Circle[4];
            for(int i = 0; i < objs.Length; i++) {
                objs[i] = new Circle();
            }
            objs[0].X = 10;
            objs[1].X = 10;
            objs[2].X = 10;
            objs[3].X = 10;

            Circle.Groups(objs);

            Console.WriteLine();

            double maxArea = 0;
            double minArea = 0;
            Console.WriteLine($"Areas of 2 objeccts: {objs[0].Area(2)} & {objs[1].Area(4)}");
            Console.WriteLine($"Biggest area is: {maxArea = Math.Max(objs[0].Area(2), objs[1].Area(4))}");
            Console.WriteLine($"Smallest area is: {minArea = Math.Min(objs[0].Area(2), objs[1].Area(4))}");

            int val = 2;
            Circle.Meth(ref val);
            Console.WriteLine(val);
            Circle.Meth1(out int vl);
            Console.WriteLine(vl);

            new Circle();


        }
    }
}
