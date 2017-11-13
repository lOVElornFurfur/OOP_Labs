using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Printer
    {
       
        enum En { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY }
        struct MyStruct
        {
            string field;
        };

        

        public virtual void IamPrinting(Assay obj)
        {
            
            
            
            if (obj is FinalExam)
            {
                Console.WriteLine($"This is FinalExam: {obj.ToString()}");
                return;
            }
            
            
           
            
            if (obj is Exam)
            {
                Console.WriteLine($"This is Exam: {obj.ToString()}");
                return;
            }


        }
    }
}
