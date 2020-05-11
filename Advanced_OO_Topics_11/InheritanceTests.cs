using NUnit.Framework;

namespace Advanced_OO_Topics_11
{
    public class InheritanceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Check_Person_Student_Relationship()
        {
            Person Alex = new Person("1", "Ivanov", "Alex", 18);
            Student DanStudent = new Student("2", "Petrov", "Alex", 21, "Computer Science", "31");
        }
    }
}