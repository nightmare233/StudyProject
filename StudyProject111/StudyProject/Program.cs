using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyProject.LamdaExpress;

namespace StudyProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Application Started.");

            StudyProject.LamdaExpress.PredicateBuilderDemo pbd = new PredicateBuilderDemo();
            pbd.PredicateBuilderDemo1();
        }
    }
}
