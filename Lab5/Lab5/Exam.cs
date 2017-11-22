using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
    class Exam : Session, IQuestion {
        //Fields
        protected int _numOfStudents;
        protected string _difficulty;
        protected string _professor;
        protected int _date;

        List<string> list = new List<string> {
                $"В каком году была принята конституция РБ?",
                $"В каком штате находится Вашингтон?",
                $"Что такое Солнце?"
        };


        enum En{SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY}
        struct MyStruct
        {
            string field;
        };
        public override string ToString()
        {
            return $"Quantity of students: {_numOfStudents}\nDifficulty of exam: {_difficulty}\nProfessor: {_professor}";
        }

      public Exam() { }

        //Properties
        public int NumOfStudents { get => _numOfStudents;
            set
            {
                if (value > 100)
                {
                    throw new ExamException("Wrong number of students");
                }
                else _numOfStudents = value;
            }

        }


        public string Difficulty { get => _difficulty; set => _difficulty = value; }
        public string Professor { get => _professor; set => _professor = value; }
        public int Date { get => _date; set => _date = value; }

        //public int Count { get => count;  }
        
        //public override void GetDate() {

        //    if (DateTime.Now.Date.Day > _date) {
        //        Console.WriteLine($"It's high time to go to army!");
        //    }
        //    else
        //        Console.WriteLine($"Relax, maslyatok, it's not time yet.");

        //}

        
        //Constructor   

        public Exam(int _numOfStudents, string _difficulty, string _professor, int _date) {
            this._numOfStudents = _numOfStudents;
            this._difficulty = _difficulty;
            this._professor = _professor;
            Date = _date;
            
            
        }
        //TODO: QUESTIONS
        public virtual int AskAnsQuest() {
            
            int right = 0;
            
            List<string> answer = new List<string> {
                $"1991",
                $"none",
                $"Star"
            };

            
            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine($"Choose your difficulty: 0-EASY  |  1-NORMAL  |  2-HARD");
                int diff;

                try
                {
                    diff = Convert.ToInt32(Console.ReadLine());
                    if (diff == 0)
                    {
                        Console.WriteLine(list[diff]);
                        var c = Console.ReadLine();
                        if (c == answer[diff])
                        {

                            Console.WriteLine($"Correct! Amount of right answers : {++right}");
                        }
                        else
                            Console.WriteLine($"Incorrect! Amount of right answers : {--right}");
                    }
                    else if (diff == 1)
                    {
                        Console.WriteLine(list[diff]);
                        var c = Console.ReadLine();
                        if (c == answer[diff])
                        {

                            Console.WriteLine($"Correct! Amount of right answers : {++right}");
                        }
                        else
                            Console.WriteLine($"Incorrect! Amount of right answers : {--right}");
                    }
                    else if (diff == 2)
                    {
                        Console.WriteLine(list[diff]);
                        var c = Console.ReadLine();
                        if (c == answer[diff])
                        {

                            Console.WriteLine($"Correct! Amount of right answers : {++right}");
                        }
                        else
                            Console.WriteLine($"Incorrect! Amount of right answers : {--right}");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"U cant enter that! {e.Message}");
                    
                }

                
                
                
            }
            return right;
        }

        public override string CountOfQuestions()
        {
            int c = int.Parse(Console.ReadLine());
            if (list.Count == c)
            {
                count++;
                Console.WriteLine($"You entered the right count of exams");
            }
            else Console.WriteLine($"You entered the wrong count of exams");

            return $"Count of tests with entered number of questions: {count}";
        }




    }
}
       
       
 
