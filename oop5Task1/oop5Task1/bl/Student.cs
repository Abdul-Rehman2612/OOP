using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5Task1
{
    internal class Student
    {
       
        public string Name;
        public int Age;
        public double FscMarks;
        public double EcatMarks;
        public double Aggregate;

        public static List<DegreeProgram> preferences;
        public DegreeProgram EnrolledProgram;
        public List<Subject> RegisteredSubjects;
        public Student(string name, int age, double fscMarks, double ecatMarks, double Aggregate, List<DegreeProgram> prefer ,DegreeProgram enrolledProgram, List<Subject> registeredSubjects)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
            EnrolledProgram = enrolledProgram;
            RegisteredSubjects = EnrolledProgram.Subjects;
            preferences = prefer;
        }
        public Student(string name, int age, double fscMarks, double ecatMarks)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
           
        }


        public void AddPreference(DegreeProgram preference)
        {
            preferences.Add(preference);
        }
        public double CalculateAggregate()
        {
            double agg = 0;
            agg = (FscMarks / 1100 * 60) + (EcatMarks / 1100 * 40);
            return agg;
        }

       

    }
}
