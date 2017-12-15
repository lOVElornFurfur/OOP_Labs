using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Exam exam = new Exam();
            Task task = new Task();

            Reflector<Exam> reflector = new Reflector<Exam>();
            reflector.ShowAll(exam);
            reflector.GetPublicMethods(exam);
            reflector.GetPropField(exam);
            reflector.GetInterfaces(exam);
            reflector.GetUserMethod(exam);

            Reflector<Task> reflector2 = new Reflector<Task>();

            reflector2.GetUserMethod(task);
            reflector2.CallAnyMethod(task);

            
            
        }
    }
}
