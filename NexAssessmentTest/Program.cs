using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexAssessmentTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student a;
            Student b = new Student();
            a = b;

            a.Name = "Michael";
            Console.WriteLine(b.Name);

            Console.ReadKey();

        }

        public class Student
        {
            public string Name { get; set; }
        }
    }
}
