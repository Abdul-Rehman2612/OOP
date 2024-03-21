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
        public static List<DegreeProgramBL> DegreePrograms=new List<DegreeProgramBL>();
        public static void AddDegree(DegreeProgramBL DegPrg)
        {
            DegreePrograms.Add(DegPrg);
        }
        public static void RemDegree(DegreeProgramBL DegPrg)
        {
            DegreePrograms.Remove(DegPrg);
        }
    }
}
