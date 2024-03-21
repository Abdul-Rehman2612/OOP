using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BL
{
    internal class StudentBL
    {
        public string StudentID;
        public string StudentName;
        public int Age;
        public double FscMarks;
        public double EcatMarks;
        public double Merit;
        public List<DegreeProgramBL> Preferences = new List<DegreeProgramBL>();
        public DegreeProgramBL DegreeProgram;
        public List<SubjectBL> SubjectsReg = new List<SubjectBL>();
        public StudentBL() { }
        public StudentBL(string studentID, string studentName, int age, double fscMarks, double ecatMarks, double merit, List<DegreeProgramBL> preferences)
        {
            StudentID=studentID;
            StudentName=studentName;
            Age=age;
            FscMarks=fscMarks;
            EcatMarks=ecatMarks;
            Merit=merit;
            Preferences=preferences;
        }
        public void UpdateStudentData(string studentID, string studentName, int age, double fscMarks, double ecatMarks, double merit, List<DegreeProgramBL> preferences)
        {
            StudentID=studentID;
            StudentName=studentName;
            Age=age;
            FscMarks=fscMarks;
            EcatMarks=ecatMarks;
            Merit=merit;
        }
        public void AddPreferences(List<DegreeProgramBL> Pref)
        {
            foreach (DegreeProgramBL degreeProgramBL in Pref)
            {
                Preferences.Add(degreeProgramBL);
            }
        }
        public void RemovePreference(int idx)
        {
            Preferences.RemoveAt(idx);
        }
    }
}
