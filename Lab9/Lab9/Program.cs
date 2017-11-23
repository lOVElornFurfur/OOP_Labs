using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        private static void Printer_OnUpgrade(int upgradeToINT) => Console.WriteLine($"Successfully upgraded to {upgradeToINT}.version");
        private static void Printer_OnTurnOn(int voltage)
        {
            if (voltage < 150)
            {
                Console.WriteLine($"Not enough voltage to run printer!");
            }
            else if (voltage > 220)
            {
                Console.WriteLine($"Look! You've broken this printer!");
            }
            else Console.WriteLine($"Printer is working!");
        }
        private static void Boss_OnTurnOn(int voltage)
        {
            if (voltage < 100)
            {
                Console.WriteLine($"Try harder, boy'eeee");
            }
            else Console.WriteLine($"The ting goes SKKKRRRRRAAAAA, I'm working!");
        }

        private static string ToUPPER(string str)
        {
            return str.ToUpper();
        }
        private static string ToLOWER(string str)
        {
            return str.ToLower();
        }
        private static string DeletePunct(string str)
        {
            List<char> dictionary = new List<char>();

            #region Dictionary
            dictionary.Add('Q');
            dictionary.Add('W');
            dictionary.Add('E');
            dictionary.Add('R');
            dictionary.Add('T');
            dictionary.Add('Y');
            dictionary.Add('U');
            dictionary.Add('I');
            dictionary.Add('O');
            dictionary.Add('P');
            dictionary.Add('A');
            dictionary.Add('S');
            dictionary.Add('D');
            dictionary.Add('F');
            dictionary.Add('G');
            dictionary.Add('H');
            dictionary.Add('J');
            dictionary.Add('K');
            dictionary.Add('L');
            dictionary.Add('Z');
            dictionary.Add('X');
            dictionary.Add('C');
            dictionary.Add('V');
            dictionary.Add('B');
            dictionary.Add('N');
            dictionary.Add('M');

            dictionary.Add('q');
            dictionary.Add('w');
            dictionary.Add('e');
            dictionary.Add('r');
            dictionary.Add('t');
            dictionary.Add('y');
            dictionary.Add('u');
            dictionary.Add('i');
            dictionary.Add('o');
            dictionary.Add('p');
            dictionary.Add('a');
            dictionary.Add('s');
            dictionary.Add('d');
            dictionary.Add('f');
            dictionary.Add('g');
            dictionary.Add('h');
            dictionary.Add('j');
            dictionary.Add('k');
            dictionary.Add('l');
            dictionary.Add('z');
            dictionary.Add('x');
            dictionary.Add('c');
            dictionary.Add('v');
            dictionary.Add('b');
            dictionary.Add('n');
            dictionary.Add('m');
            dictionary.Add(' ');
            #endregion


            StringBuilder temp = new StringBuilder(str);
            for (int i = 0; i < temp.Length ; i++)
            {
                if (!dictionary.Contains(temp[i]))
                {
                    str.Remove(i,0);
                }
            }

            return str;

        }

        



        static void Main(string[] args)
        {
            //Boss printer = new Boss();
            //printer.OnTurnOn += Printer_OnTurnOn;
            //printer.OnUpgrade += Printer_OnUpgrade;

            //Boss boss = new Boss();
            //boss.OnTurnOn += Boss_OnTurnOn;

            //printer.TurnON(100);
            //printer.Upgrade(1783);
            //printer.TurnON(230);
            //printer.TurnON(190);

            //Console.WriteLine();

            //boss.TurnON(99);
            //boss.TurnON(110000);

            //Console.WriteLine();

            string str = "Hey, Vlad Loput! Che? ne Zvonyat? :D";    
            Console.WriteLine(DeletePunct(str));

        }
        
    }
}
