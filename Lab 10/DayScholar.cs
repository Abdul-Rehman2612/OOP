using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class DayScholar:Student
    {
            private int BusNo;
            private int Distance;
            private bool isCardAvailable;
            public DayScholar(string name, string Session, double ETMarks, double HSMarks, int BusNo, int Distance, bool isCardAvailable,bool dayS) : base(name, Session, ETMarks, HSMarks,dayS)
            {
                this.BusNo= BusNo;
                this.Distance = Distance;
                this.isCardAvailable=isCardAvailable;
            }
    }
}
