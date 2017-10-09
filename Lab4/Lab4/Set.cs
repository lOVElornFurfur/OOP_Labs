using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    class Set {

        private List<string> elements;

        public List<string> Elements {
            get { return elements; }
            set { elements = value; }
        }
        public List<string> Data {
            get
            {
                return elements;
            }
        }

        public Set() {
            elements = new List<string>();
        }

        public string Meth() {
            Random rn = new Random();
            var a = rn.Next(200).ToString();
            return a;
        }
        public string Meth1() {
            Random rn = new Random();
            var a = rn.Next(100).ToString();
            return a;
        }
        public string Meth2() {
            Random rn = new Random();
            var a = rn.Next(100).ToString();
            return a;
        }

        public static Set operator ++(Set Sarr) {
            Sarr.elements.Add(Sarr.Meth2());
            return Sarr;
        }
        public static Set operator +(Set Darr, Set Farr) {
            foreach (var str in Farr.elements) {
                Darr.elements.Add(str);
            }
            return Darr;
        }
        public static bool operator <=(Set A, Set B) {

            A.elements.Add(A.Meth2());
            B.elements.Add(B.Meth());
            A.Show();
            B.Show();
            if (A.elements == B.elements) {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool operator >=(Set A, Set B) => true;
        public static Set operator %(Set A, Set B) {
            string str = "lightning loves her";
            A.elements.Add(str.PositionAccess());
            return A;
        }
        public static Set Crypto(Set A) {
            string st = "hellomazafaka";
            A.elements.Add(st.Crypt());
            return A;
        }

        public void Show() {
            foreach (var str in elements) {
                Console.WriteLine(str);
            }
        }

        public override string ToString() {
            var c = " ";

            foreach (var str in elements) {
                c += str + " ";
            }

            return $"c: {c} ";
        }

        public static void ShowCollection(SortedSet<char> ss, string s) {
            Console.WriteLine(s);
            foreach (char ch in ss) {
                Console.WriteLine(ch + " ");
                Console.WriteLine("\n");
            }

        }

    }
    public class Owner {
        private int id;
        private string name;
        private string organisation;

        public Owner(int id, string name, string organisation) {
            this.id = id;
            this.name = name;
            this.organisation = organisation;
        }

        public int ID {
            get
            {
                return id;
            }
        }

        public string Name {
            get
            {
                return name;
            }
        }
        public string Organisation {
            get
            {
                return organisation;
            }
        }


    }

    public class Date {
        private string dateOfCreation;

        public string DateOfCreation {
            get
            {
                return dateOfCreation;
            }
        }

        public Date(string dateOfCreation) {
            this.dateOfCreation = dateOfCreation;
        }
    }
}



    //TODO: Try with interfaces

