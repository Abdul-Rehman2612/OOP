using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.data
{
    internal class Courses
    {
        public string courseID;
        public string courseName;
        public Courses(string courseID, string courseName)
        {
            this.courseID=courseID;
            this.courseName=courseName;
        }
    }
}
