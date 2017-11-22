using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    [Serializable]
    public class ExamException : Exception
    {
        public ExamException() { }
        public ExamException(string message) : base(message) { }
        public ExamException(string message, Exception inner) : base(message, inner) { }
        protected ExamException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
