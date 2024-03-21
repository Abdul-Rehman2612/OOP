using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class DegreeProgramDL
    {
        private static List<DegreeProgramBL> degreePrograms = new List<DegreeProgramBL>();
        public static void AddDegree(DegreeProgramBL degreeProgram)
        {
            degreePrograms.Add(degreeProgram);
        }
        public static bool IsDegreeExist(string title)
        {
            foreach (DegreeProgramBL degreeProgram in degreePrograms)
            {
                if (degreeProgram.GetDegreeTitle() == title) return true;
            }
            return false;
        }
        public static int DegreesCount()
        {
            return degreePrograms.Count();
        }
    }
}
