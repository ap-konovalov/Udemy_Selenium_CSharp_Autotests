using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Can_Return_First_And_Last_Name()
        {
            Employee Sanches = new Employee(1, "Aleksandr", "Petrov");
            var firstAndLastName = Sanches.GetFirstAndLastName();
            Assert.AreEqual("Aleksandr Petrov", firstAndLastName);

        }

        [TestMethod]
        public void Can_Return_Last_And_First_Name_Comma_Separated()
        {
            Employee Alex = new Employee(1, "Alex", "Ivanov");
            var lastAndFirstName = Alex.GetLastAndFirstNameCommaSeparated();
            Assert.AreEqual("Ivanov, Alex", lastAndFirstName);
        }        
        
        [TestMethod]
        public void Set_Number_In_Constructor()
        {
            Employee Alex = new Employee(1);
            Assert.AreEqual(1, Alex.Number);
        }
        
        [TestMethod]
        public void Set_NY_As_Default_Location()
        {
            Employee Alex = new Employee(1);
            var defaultEmployeeLocation =  Alex.JobLocation();
            Assert.AreEqual("New York", defaultEmployeeLocation);
        }
        
        [TestMethod]
        public void Set_Location_In_Boston_For_Managers()
        {
            Employee Alex = new Employee(1);
            Alex.JobDescription = "Manager";
            var employeeLocation = Alex.JobLocation();
            
            Assert.AreEqual("Boston", employeeLocation);
        }
        
        [TestMethod]
        public void Can_Return_Employee_To_String()
        {
            var employeeNumber = 2;
            var employeeName = "Alex";
            var employeeJobTitle = "Manager";
            
            Employee Alex = new Employee(employeeNumber, employeeName , "Petrov");
            Alex.JobDescription = employeeJobTitle;
            
            Assert.AreEqual(
                $"{employeeNumber} {employeeName} Job Title: {employeeJobTitle}" , 
                Alex.ToString() );
        }
    }
}
