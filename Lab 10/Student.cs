namespace Challenge_1
{
    internal class Student
    {
        private string name;
        protected string session;
        protected bool isDayScholar;
        protected double ETMarks;
        protected double HSMarks;

        public Student(string name, string session, double ETMarks, double HSMarks)
        {
            this.name = name;
            this.session = session;
            this.ETMarks = ETMarks;
            this.HSMarks = HSMarks;
        }
        public Student(string name, string session, double ETMarks, double HSMarks, bool isDayScholar)
        {
            this.name = name;
            this.session = session;
            this.isDayScholar = isDayScholar;
            this.ETMarks = ETMarks;
            this.HSMarks = HSMarks;
        }
        public double CalculateMerit()
        {
            return (ETMarks * 60.0 / 400.0 + HSMarks * 44.0 / 1100);
        }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public void SetSession(string session) {  this.session = session; }
        public string GetSession() { return this.session; }
        public bool GetDayScholar() { return this.isDayScholar; }
    }
}
