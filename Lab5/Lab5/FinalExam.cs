using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
    sealed class FinalExam : Exam, IQuestion { 

        private int _grade;
        private string _workPlace;

        enum En { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY }
        struct MyStruct
        {
            int field;
        };


        public int Grade { get => _grade; set => _grade = value; }
        public string WorkPlace { get => _workPlace; set => _workPlace = value; }

        


        public FinalExam(int _numOfStudents, string _difficulty, string _professor, int _date)
                        : base(_numOfStudents, _difficulty, _professor, _date) { }



        public override string ToString()
        {
            return $"Quantity of students: {_numOfStudents}\nDifficulty of exam: {_difficulty}\nProfessor: {_professor}";
        }

        //если ответы даны на все вопросы, то оценка == 10 и тд.
        //доавлять и снимать баллы за верные и неверные ответы.
        public override int AskAnsQuest() { 
            
            int mark = 0;
            int right = 0;
            List<string> list = new List<string>{
                $"1?",
                $"2?",
                $"3?"
            };
            List<string> answer = new List<string> {
                $"1",
                $"2",
                $"3"
            };

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
                var c = Console.ReadLine();
                if (c == answer[i]) {
                    ++right;
                    Console.WriteLine($"WOAW! You're right! {mark = mark + 10}");
                }
                else {
                    --right;
                    Console.WriteLine($"LOL! You're wrong! {mark = mark - 20}");
                }
            }
            if(mark == 30) {
                Console.WriteLine($"Congratulations! You answered extremely good! Your final exam mark: {10}");
            }
            else Console.WriteLine($"Gratzz! You didn't answered all questions, but still passed the final exam. Final exam mark: {((mark-right)*list.Count+5)}");


            return mark;
        }




    }
}
