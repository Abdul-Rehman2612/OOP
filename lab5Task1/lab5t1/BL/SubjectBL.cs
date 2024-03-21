using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class SubjectBL
    {
        private string sCode;
        private int creditHours;
        private string subjectType;
        private double subjectFee;
        public SubjectBL(string sCode, int creditHours, string subjectType, double subjectFee)
        {
            this.sCode=sCode;
            this.creditHours=creditHours;
            this.subjectType=subjectType;
            this.subjectFee=subjectFee;
        }
        public void SetsCode(string sCode) {  this.sCode=sCode; }
        public void SetCreditHours(int creditHours) {  this.creditHours=creditHours; }
        public void SetSubjectType(string subjectType) {  this.subjectType=subjectType; }
        public void SetSubjectFee(double subjectFee) {  this.subjectFee=subjectFee; }
        public string GetsCode() {  return sCode; }
        public int GetCreditHours() {  return creditHours; }
        public string GetSubjectType() {  return subjectType; }
        public double GetSubjectFee() {  return subjectFee; }
    }
}
