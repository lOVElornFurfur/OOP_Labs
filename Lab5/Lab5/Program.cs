using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Lab5 {
    class Program {
        static void Main(string[] args) {

            Exam exam = new Exam(13, "Massacre", "Patsei", 10);


            FinalExam finals = new FinalExam(13, "easy", "German", 19);

            Test test = new Test();

            test.AskAnsQuest();
            exam.AskAnsQuest();
            finals.AskAnsQuest();

            Printer print = new Printer();
            Exam obj1 = new Exam(12, "HARD", "Patsei", 10);

            FinalExam obj3 = new FinalExam(100, "EASY", "SMELOV", 5);

            Assay[] ass = new Assay[2];
            //ass[0] = obj1;
            //ass[1] = obj3;
            print.IamPrinting(ass[0]);
            Console.WriteLine();
            print.IamPrinting(ass[1]);

            Exam ex = new Exam();
            FinalExam fn = ex as FinalExam;
            if (ex != null)
            {
                Console.WriteLine("GOOD");
            }
            else Console.WriteLine("BAD");


            Session session = new Session();
            session.FindExams();
            session.Summary();

            Console.WriteLine(session.CountOfQuestions());

            Console.WriteLine();

            Test test1 = new Test("JEPA", 100);
            FinalExam final = new FinalExam(4, "easy", "Patsei", 30);
            Console.WriteLine(test.CountOfQuestions());
            Exam exam1 = new Exam(12, "hard", "Smelov", 15);
            Console.WriteLine(exam.CountOfQuestions());

            Container container = new Container();

            Console.WriteLine(container.AddExam(exam));
            Console.WriteLine(container.ExamList.Count);
            Console.WriteLine(container.RemoveExam(exam));
            Console.WriteLine(container.ExamList.Count);

            Console.WriteLine(container.AddFinal(final));
            Console.WriteLine(container.FinalList.Count);
            Console.WriteLine(container.RemoveFinal(final));
            Console.WriteLine(container.FinalList.Count);

            Console.WriteLine(container.AddTest(test));
            Console.WriteLine(container.TestList.Count);
            Console.WriteLine(container.RemoveTest(test));
            Console.WriteLine(container.TestList.Count);

            Console.WriteLine();

            container.Show();
            Exam exam2 = new Exam();
            exam1.AskAnsQuest();

            try
            {
                Exam exam3 = new Exam();
                exam.NumOfStudents = 101;
            }
            catch (ExamException exe)
            {
                Console.WriteLine($"Failed: {exe.Message}, {exe.Source}, {exe.HResult}, {exe.StackTrace}, {exe.TargetSite}");   
            }
            finally
            {
                Console.WriteLine($"This is a finally block");
            }

            


        }
    }
}
