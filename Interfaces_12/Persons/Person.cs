namespace Interfaces_12
{
    public abstract class Person
    {
        private string _id;
        private string _lastName;
        private string _firstName;
        private int _age;

        public Person()
        {
            
        }
        
        public Person(string id, string lastName, string firstName, int age)
        {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            _age = age;
        }

        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of sleep";
        }
    }
}