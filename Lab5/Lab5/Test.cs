using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
    sealed class Test : Session, IQuestion {

        enum En { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY }
        struct MyStruct
        {
            char field;
        };


        private string _typeOfTest;
        private int _numOfQuestions;

        List<string> list = new List<string> {
                $"Что такое .NET?",
                $"Стоимость Apple?",
                $"Столица Вейшнории?"
            };

        public string TypeOfTest { get => _typeOfTest; set => _typeOfTest = value; }
        public int NumOfQuestions { get => _numOfQuestions; set => _numOfQuestions = value; }
        //public int Count { get => count; }

        public Test(string _typeOfTest, int _numOfQuestions) {
            //count++;
            this._typeOfTest = _typeOfTest;
            this._numOfQuestions = _numOfQuestions;
        }

        public override string ToString()
        {
            return $"Type of test: {_typeOfTest}\nQuantity of questions: {_numOfQuestions}";
        }

        public int AskAnsQuest() {
            
            List<string> answer = new List<string> {
                $"Framework",
                $"903bil",
                $"Lida"
            };

            int right = 0;
            
            for (int i = 0; i < 3; i++) {

                Console.WriteLine(list[i]);
                var c = Console.ReadLine();
                if (c == answer[i]) {

                    Console.WriteLine($"Correct! Amount of right answers : {++right}");
                }
                else
                    Console.WriteLine($"Incorrect! Amount of right answers : {--right}");

            }
            return right;


        }
        

    }
}
