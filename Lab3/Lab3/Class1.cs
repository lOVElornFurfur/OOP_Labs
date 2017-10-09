using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    partial class Circle {
        private int x;
        private int y;
        private int radius;
        private const double pi = Math.PI;
        private readonly int Id;

        public static string Data { get { return "Some data"; } set { } }

        public int Radius {
            get { return radius; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Incorrect");
                else
                    radius = value;
            }
        }
        public int X {
            get { return x; }
            set { x = value; }
        }
        public int Y {
            get { return y; }
            set { y = value; }
        }


        public Circle(int x, int y, int radius) {
            this.x = x;
            this.y = y;
            Id = this.GetHashCode();
            Radius = radius;
        }
        public Circle() {
            Console.WriteLine("a ");
        }

        public static void Groups(Circle[] arr) {

            const int k = 4;
            const int b = 4;


            arr[0].Y = k * arr[0].X + b;
            arr[1].Y = k * arr[1].X + b;
            arr[2].Y = k * arr[2].X + b;
            arr[3].Y = k * arr[3].X + b;

            if (arr[0].Y == arr[1].Y && arr[2].Y == arr[3].Y && arr[0].X == arr[1].X && arr[2].X == arr[3].X ) 
                Console.WriteLine("The coordinates are the same!");
            else
                Console.WriteLine("Ain't same");

            int n = arr[0].Y;
            int n2 = arr[1].Y;
            Console.WriteLine(n+" "+n2);
            int m = arr[2].Y;
            int m2 = arr[3].Y;
            Console.WriteLine(m + " " + m2);
        }
        public static void Meth(ref int i) {
            i = 44 + i;
        }
        public static void Meth1(out int i) {
            i = 2;
        }

    }
}
