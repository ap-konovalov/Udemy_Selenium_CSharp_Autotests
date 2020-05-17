namespace Advanced_OO_Topics_11
{
    public class Student : Person
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
    }
}