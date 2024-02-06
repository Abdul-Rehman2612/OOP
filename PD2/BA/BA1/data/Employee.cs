using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA1.data
{
    internal class Employee
    {
        public string employeeName;
        public string employeeID;
        public string employeeIDPassword;
        public string employeeCnic;
        public Employee(string empName,string empID,string empPassword,string empCNIC) { 
            this.employeeName = empName;
            this.employeeID = empID;
            this.employeeIDPassword = empPassword;
            this.employeeCnic=empCNIC;
        }

    }
}
