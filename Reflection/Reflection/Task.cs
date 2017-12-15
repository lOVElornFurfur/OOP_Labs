using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Task
    {
        private int _number = 0;

        public Task()
        {
            _number = 5;
        }

        public int Number { get => _number; set => _number = value; }

        public int Method1(int num)
        {
            Console.WriteLine($"Number before changing: {num}");
            num = 10;
            Console.WriteLine($"After changing: {num}");
            return num;
        }
        
            
        

    }
}
