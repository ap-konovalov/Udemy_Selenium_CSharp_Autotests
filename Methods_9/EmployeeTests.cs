using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Section_6;

namespace Methods_9
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Call_PayType_Method_With_String()
        {
            Employee Alex = new Employee(1);
            Alex.JobDescription = "Manager";
            var result = Alex.PayType(Alex.JobDescription);

            Console.WriteLine(result);
        }
        
        [TestMethod]
        public void Call_PayType_Method_With_Integer()
        {
            Employee Alex = new Employee(10);

            var result = Alex.PayType(Alex.Number);

            Console.WriteLine(result);
        }
    }
}