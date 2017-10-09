using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    partial class Circle  {
        static Circle() {
            Console.WriteLine("Static constr was called");
        }
        public override string ToString() {
            return $"Coord 1: {x} | Coord 2: {y} | radius: {radius} | ID: {Id}";
        }

        public double Area(double rad) {
            return pi * Math.Pow(rad, 2);
        }
        public double Length(double rad) {
            return 2 * pi * rad;
        }
        
    }

    
}

