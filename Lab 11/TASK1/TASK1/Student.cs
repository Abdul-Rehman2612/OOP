using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1.BL
{
    internal class Student
    {
        private string Name;
        private string Age;
        private string Marks;
        public Student(string Name,string Age,string Marks)
        {
            this.Name = Name;
            this.Age = Age;
            this.Marks = Marks;
        }
        public string GetName() {  return this.Name; }
        public string GetAge() {  return this.Age; }
        public string GetMarks() {  return this.Marks; }
        public void SetName(string Name) { this.Name=Name; }
        public void SetAge(string Age) { this.Age=Age; }
        public void SetMarks(string Marks) { this.Marks=Marks; }
    }
}
