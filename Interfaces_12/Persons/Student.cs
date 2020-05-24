namespace Interfaces_12
{
    public class Student : Person, ITraveler
    {
        private string _major;
        private string _studentId;

        public Student(string id, string lastName, string firstName, int age, string major, string studentId) 
        : base(id,lastName,firstName,age)
        {
            _major = major;
            _studentId = studentId;
        }

        public override string HoursOfSleep()
        {
            return "A student gets 6 hours of sleep";
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";
        }

        public double DetermineMiles()
        {
            return 24.0;
        }
    }
}