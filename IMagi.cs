using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    interface IMagi<T>
    {
        void ADD(T obj);
        void Delete(T obj);
        void LookThrough();
    }
}
