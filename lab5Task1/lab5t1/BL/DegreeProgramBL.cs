using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class DegreeProgramBL
    {
        private string degreeTitle;
        private double duration;
        private int seats;
        private List<SubjectBL> Subjects;
        public DegreeProgramBL() { }
        public DegreeProgramBL(string degreeTitle, double duration,int seats, List<SubjectBL> subjects)
        {
            this.degreeTitle=degreeTitle;
            this.duration=duration;
            this.seats=seats;
            foreach(SubjectBL subject in subjects)
            {
                Subjects.Add(subject);
            }
        }
        public bool AllotSeat()
        {
            if(seats>0)
            {
                seats--;
                return true;
            }
            return false;
        }
        public int GetSeats() { return seats; }
        public string GetDegreeTitle() { return degreeTitle; }
        public double GetDuration() { return duration; }
        public List<SubjectBL> GetSubjects() {  return Subjects; }
    }
}