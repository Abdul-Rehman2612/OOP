using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.data
{
    internal class Students
    {
        public string name;
        public float matricMarks;
        public float interMarks;
        public float ecatMarks;
        public double aggregate;
        public Students(string name, float matricMarks, float interMarks, float ecatMarks)
        {
            this.name=name;
            this.matricMarks=matricMarks;
            this.interMarks=interMarks;
            this.ecatMarks=ecatMarks;
            this.aggregate=0.0;
        }
        public void CalculateAgg(Students s)
        {
            this.aggregate=s.matricMarks*25.0/1100.0+s.interMarks*45.0/1100.0+s.ecatMarks*30.0/400.0;
        }
  }
}
