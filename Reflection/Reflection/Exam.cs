using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Exam : IReflection, IRefl
    {
        public string _nameOfExam = "-";
        
        public string NameOfExam { get => _nameOfExam; set => _nameOfExam = value; }

        public Exam(string nameOfExam)
        {
            _nameOfExam = nameOfExam;
        }
        public Exam() { }

        public string Method(string str)
        {
            str = "Hello, Dima";
            return str;
        }

        

    }
}
