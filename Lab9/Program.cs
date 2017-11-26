using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        private static void Printer_OnUpgrade(int version) => Console.WriteLine($"Successfully upgraded to {version}.version");
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
                Console.WriteLine($"Try harder");
            }
            else Console.WriteLine($"I'm working!");
        }

        private static void DeletePunct(string str)
        {
            var regex = new Regex($"[.|,|!|?|_|;|:]");
            Console.WriteLine(Regex.Replace(str, $"{regex}", ""));   
        }

        static void Main(string[] args)
        {
            Boss printer = new Boss();
            printer.OnTurnOn += Printer_OnTurnOn;
            printer.OnUpgrade += Printer_OnUpgrade;

            Boss boss = new Boss();
            boss.OnTurnOn += Boss_OnTurnOn;

            printer.TurnOn(100);
            printer.Upgrade(1783);
            printer.TurnOn(230);
            printer.TurnOn(190);

            Console.WriteLine();

            boss.TurnOn(99);
            boss.TurnOn(110000);

            Console.WriteLine();

            string str = ";Hey, V:l;ad_ Loput?!";
            DeletePunct(str);

        }
        
    }
}
