using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Hostellite: Student
    {
        private int RoomNumber;
        private bool isFridgeAvailable;
        private bool isInternetAvailable;
        public Hostellite(string name,string Session,double ETMarks,double HSMarks,int RoomNumber,bool isFridgeAvailable,bool isInternetAvailable,bool dayS): base (name,Session,ETMarks,HSMarks,dayS)
        {
            this.RoomNumber = RoomNumber;
            this.isFridgeAvailable = isFridgeAvailable;
            this.isInternetAvailable = isInternetAvailable;
        }
    }
}
