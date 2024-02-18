using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.BL
{
    internal class student
    {
        public string name;
        public string rollNumber;
        public double cgpa;
        public double matricMarks;
        public double fscMarks;
        public double ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public student()
        {

        }
        public student(string SName,string rollNo,double MatricMarks,double FscMarks,string HomeTown,bool hostelite)
        {
            this.name = SName;
            this.rollNumber = rollNo;
            this.matricMarks = MatricMarks;
            this.fscMarks = FscMarks;
            this.homeTown = HomeTown;
            this.isHostelite = hostelite;
            isTakingScholarship=ScholorshipAvail();
        }
        public double calculateMerit()
        {
            return (matricMarks/1100)*40+(fscMarks/1100)*60;
        }
        public bool ScholorshipAvail()
        {
            double merit=calculateMerit();
            if(isHostelite && merit>=80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
