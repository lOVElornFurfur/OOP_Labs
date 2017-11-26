using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Exam
    {
        private string _nameOfExam;

        public Exam(string nameOfExam)
        {
            _nameOfExam = nameOfExam;
        }

        public string NameOfExam { get => _nameOfExam; set => _nameOfExam = value; }
    }
}
