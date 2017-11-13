using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Session
    {
        static private List<string> credit;
        static private List<string> exams = new List<string>{ "Math", "Phys", "IT", "Philo" };
        static private string subject;
        static private List<string> examList;

        static public int count = 0; //количество тестов с заданным вопросом

        static public List<string> Credit { get => credit; set => credit = value; }
        static public List<string> Exams { get => exams; set => exams = value; }
        static public string Subject { get => subject; set => subject = value; }

        static Session()
        {
            credit = new List<string>();
            
            examList = new List<string>(4);
        }

        // public Session() { }
        

        public void FindExams()
        {
            for (int j = 0; j < exams.Count; j++)
            {
                string subject = Console.ReadLine();
                if (subject == exams[j])
                {
                    Console.WriteLine($"This subject {subject} exists in your session");
                    examList.Add(subject);
                }
                else Console.WriteLine($"This subject {subject} doesn't exist in your session");

            }

        }
        public void Summary()
        {
            Console.WriteLine($"Your examination subjects are: ");
            
                int count = 0;

                foreach (var item in examList)
                {
                    Console.Write($"{item}; ");
                    Console.WriteLine();
                    count++;
                }
               
                Console.WriteLine($"Total count of exams in your session is {count}");
        }
        
        public virtual string CountOfQuestions()
        {
            int c = int.Parse(Console.ReadLine());
            if (exams.Count == c)
            {
                count++;
                Console.WriteLine($"You entered the right count of exams");
            }
            else Console.WriteLine($"You entered the wrong count of exams");

            return $"Count of tests with entered number of questions: {count}";
        }




    }
}
