using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(2);
            list.Add(2);
            list.Add(3);
            list.Add(4);
           var a= list.GetVal(4);
            var max = list.Max();
        }
    }
}
