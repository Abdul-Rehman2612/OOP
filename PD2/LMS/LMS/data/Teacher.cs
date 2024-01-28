using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace teacher.data
{
    internal class Teacher
    {
        public string teacherName;
        public string teacherID;
        public string teacherPassword;
        public Teacher(string Name,string ID,string Password)
        {
            this.teacherName = Name;
            this.teacherID = ID;
            this.teacherPassword = Password;
        }
    }
}
