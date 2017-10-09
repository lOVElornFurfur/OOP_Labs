using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4 {
    public static class Extension {

        public static string PositionAccess(this string str) {
            
            str = str.Substring(0, 1);
            return str;
        }
        public static string Crypt(this string str) {

            Dictionary<char, int> dic = new Dictionary<char, int> { { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 }, { 'k', 11 }, { 'l', 0 }, { 'm', 12 }, { 'n', 13 }, { 'o', 14 }, { 'p', 15 }, { 'q', 16 }, { 'r', 17 }, { 's', 18 }, { 't', 19 }, { 'u', 20 }, { 'v', 21 }, { 'w', 22 }, { 'x', 23 }, { 'y', 24 }, { 'z', 25 } };
            for (int i = 0; i < str.Length; i++) {
                int val = 0;
                if (dic.TryGetValue(str[i], out val)) {
                    str = str.Replace(str[i].ToString(), val.ToString());
                }
                Console.WriteLine(str);
            }
            return str;
        }
        public static SortedSet<char> SS(this SortedSet<char> ss) {
            ss.Add('Z');
            ss.Add('X');
            ss.Add('E');
            ss.Add('R');
            ss.Add('H');
            ShowCollection(ss, "The first collection");
            return ss;
        }
        static void ShowCollection(SortedSet<char> ss, string s) {
            Console.WriteLine(s);
            foreach (char ch in ss) {
                Console.WriteLine(ch + " ");
                Console.WriteLine("\n");
            }
        }
    }
}
