using System;
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

        [Test]
        public void Check_AbstractPerson_Driver_Relationship()
        {
            // Сannot instantiate an abstract class
            // AbstractPerson abstractPeople = new Person("1", "Ivanov", "Alex", 18);
            
            Driver ValeraDriver = new Driver("2", "Petrov", "Alex", 21, DateTime.Now,31);
            
            // it is an abstract method declared in a base class and implemented in a class descendant
            ValeraDriver.GetExerciseHabits();
        }
        
        [Test]
        public void Check_AbstractPerson_Driver_Relationship_Access_to_Person_Protected_Property()
        {
            Driver ValeraDriver = new Driver("2", "Petrov", "Alex", 21, DateTime.Now,31);
            
            // this method return protected field _dateOfBirth which declared in base class
            // Can't call ValeraDriver._dateOfBirth because this field protected
            ValeraDriver.GetDateOfBirth();
        }
    }
}