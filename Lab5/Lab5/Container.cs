using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Container
    {
        private List<Exam> examList = new List<Exam>();
        private List<Test> testList = new List<Test>();
        private List<FinalExam> finalList = new List<FinalExam>();

        public List<Exam> ExamList { get => examList; set => examList = value; }
        public List<Test> TestList { get => testList; set => testList = value; }
        public List<FinalExam> FinalList { get => finalList; set => finalList = value; }

        public List<Exam> AddExam(Exam obj)
        {
            examList.Add(obj);
            return examList;
        }
        public List<Test> AddTest(Test obj)
        {
            testList.Add(obj);
            return testList;
        }
        public List<FinalExam> AddFinal(FinalExam obj)
        {
            finalList.Add(obj);
            return finalList; 
        }

        public List<Exam> RemoveExam(Exam obj)
        {
            examList.Remove(obj);
            return examList;
        }
        public List<Test> RemoveTest(Test obj)
        {
            testList.Remove(obj);
            return testList;
        }
        public List<FinalExam> RemoveFinal(FinalExam obj)
        {
            finalList.Remove(obj);
            return finalList;
        }

        
        public void Show()
        {
            foreach (var str in examList)
            {
                Console.WriteLine(str);
                Console.WriteLine();
            }
            foreach (var str in testList)
            {
                Console.WriteLine(str);
                Console.WriteLine();
            }
            foreach (var str in finalList)
            {
                Console.WriteLine(str);
                Console.WriteLine();
            }
        }




        //public T Add<T>(T obj) where T : class
        //{

        //    if (obj.GetType() == typeof(Exam))
        //    {
        //        examList.Add(obj);
        //    }



        //    return obj;
        //}




    }
}
