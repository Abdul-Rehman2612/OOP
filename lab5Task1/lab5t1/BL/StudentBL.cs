using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class StudentBL
    {
        private string studentName;
        private double studentAge;
        private double fscMarks;
        private double ecatMarks;
        private double merit;
        private double fee;
        private List<DegreeProgramBL> Preferences;
        private DegreeProgramBL enrolledProgram;
        private List<SubjectBL> registerdSubjects;
        public StudentBL() { }
        public StudentBL(string studentName,int studentAge,double fscMarks,double ecatMarks)
        {
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            registerdSubjects=null;
            enrolledProgram=null;
            fee=0;
        }
        public void SetPreferences(DegreeProgramBL preferences)
        {
            Preferences.Add(preferences);
        }
        public void GenerateMerit() { merit = fscMarks/1100*60+ecatMarks/1100*40; }
        public void GenerateFee()
        {
            if(registerdSubjects!=null)
            {
                double Fees=0;
                foreach (SubjectBL subject in registerdSubjects)
                {
                    Fees+=subject.GetSubjectFee();
                }
                if(Fees>0)
                {
                    fee=Fees;
                }
            }
         }
        public string GetStudentName() {  return studentName; }
        public double GetStudentAge() {  return studentAge; }
        public double GetFscMarks() {  return fscMarks; }
        public double GetEcatMarks() {  return ecatMarks; }
        public double GetMerit() {  return merit; }
        public double GetFee() {  return fee; }
        public List<DegreeProgramBL> GetPreferences() {  return Preferences; }
        public DegreeProgramBL GetEnrolledProgram() {  return enrolledProgram; }
        public List<SubjectBL> GetRegisteredSubject() { return registerdSubjects; }
    }
}
