using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.data
{
    internal class Student
    {
        public Student()
        {
            studentName = "Jill";
            matricMarks=0;
            interMarks=0;
            ecatMarks=0;
            aggregate=0;
        }
        public string studentName;
        public float matricMarks;
        public float interMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
