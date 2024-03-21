using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class DegreeProgramBL
    {
        public string DegreeTitle;
        public int DegreeDuration;
        public int DegSeats;
        public List<SubjectBL> DegSubjects=new List<SubjectBL>();
        public DegreeProgramBL(string degreeTitle, int degreeDuration, int degSeats)
        {
            DegreeTitle=degreeTitle;
            DegreeDuration=degreeDuration;
            DegSeats=degSeats;
        }
        public void AddSubjects(SubjectBL subject)
        {
            DegSubjects.Add(subject);
        }
        public void RemoveSubjects(int idx)
        {
            DegSubjects.RemoveAt(idx);
        }
        public void UpdateSubject(int idx,SubjectBL subject)
        {
            DegSubjects[idx].SubjectCode = subject.SubjectCode;
            DegSubjects[idx].SubjectType = subject.SubjectType;
            DegSubjects[idx].SubjectFee = subject.SubjectFee;
            DegSubjects[idx].CreditHours = subject.CreditHours;
        }
        public List<SubjectBL> SubjectsReturn()
        {
            return DegSubjects;
        }
    }
}
