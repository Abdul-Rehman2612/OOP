using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.BL;

namespace LMS.DL
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgramBL> degreePrograms = new List<DegreeProgramBL>();
        
        public static void AddDegree(DegreeProgramBL degreeProgram)
        {
            degreePrograms.Add(degreeProgram);
        }
        public static bool IsDegreeExist(string title)
        {
            foreach(DegreeProgramBL degreeProgram in degreePrograms)
            {
                if(degreeProgram.DegreeTitle == title)
                    return true;
            }
            return false;
        }
    }
}
