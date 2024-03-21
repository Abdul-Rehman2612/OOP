using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class SubjectBL
    {
        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public int SubjectFee;
        public SubjectBL() { }
        public SubjectBL(string subjectCode, int creditHours, string subjectType, int subjectFee)
        {
            SubjectCode=subjectCode;
            CreditHours=creditHours;
            SubjectType=subjectType;
            SubjectFee=subjectFee;
        }
    }
}
