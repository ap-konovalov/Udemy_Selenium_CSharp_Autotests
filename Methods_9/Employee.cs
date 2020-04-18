using System;
namespace Section_6
{
    public class Employee
    {
        private int _number;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfHire;
        private string _jobDescription;
        private string _department;
        private double _monthlySalary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value;}
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }      
        
        public string JobDescription
        {
            get { return _jobDescription; }
            set { _jobDescription = value; }
        }

        public Employee(int employeeNumber,string firstName, string lastName)
        {
            Number = employeeNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee()
        {
        }
        
        public Employee(int number)
        {
            Number = number;
        }

        public string GetFirstAndLastName()
        {
            return $"{FirstName} {LastName}"; 
        }

        public string GetLastAndFirstNameCommaSeparated()
        {
            return $"{LastName}, {FirstName}";
        }

        public string JobLocation()
        {
            if (JobDescription == "Manager")
            {
                return "Boston";
            } 
            
            if (JobDescription == "Staff")
            {
                return "Chicago";
            }

            return "New York";
        }
        
        public string PayType(string type)
        {
            if (type == "Manager")
            {
                return "Salary";
            } 
            
            if (type == "Staff")
            {
                return "Hourly";
            }

            return "Hourly";
        }
        
        public string PayType(int id)
        {
            if (id == 5)
            {
                return "Salary";
            } 
            
            if (id == 10)
            {
                return "Hourly";
            }

            return "Hourly";
        }

        public override string ToString()
        {
            return Number + " " + FirstName + " Job Title: " + JobDescription;
        }
    }
}
