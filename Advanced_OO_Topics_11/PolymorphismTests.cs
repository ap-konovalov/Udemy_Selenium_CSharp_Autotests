using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Advanced_OO_Topics_11
{
    public class PolymorphismTests
    {
        [Test]
        public void Test_Student_As_Person()
        {
            ArrayList PersonList = new ArrayList();
            
            Person personaVitalik = new Person("1", "Ivanov","Vitalik", 21);
            PersonList.Add(personaVitalik);   
            
            Assert.True(PersonList[0] is Person);
            //Not a student because this is a base class
            Assert.False(PersonList[0] is Student);
            
            
            Student studentBob = new Student("2", "Klinton", "Bob", 22, "Comp Sciense", "21");
            PersonList.Add(studentBob);
            Assert.True(PersonList[1] is Student);
            // is person because it is derived from person
            Assert.True(PersonList[1] is Person);

            // Student is inherited from a Person but has overriden method HoursOfSleep
            // We can iterate PersonList and call different implementation of method HoursOfSleep()
            foreach (Person people in PersonList)
            {
                Console.WriteLine(people.HoursOfSleep());
            }
            
            //Person and student has different HoursOfSleep() overloads 
            Assert.AreEqual("A person gets 8 hours of sleep", (PersonList[0] as Person).HoursOfSleep() );
            Assert.AreEqual("A student gets 6 hours of sleep", (PersonList[1] as Person).HoursOfSleep() );
        }
    }
}