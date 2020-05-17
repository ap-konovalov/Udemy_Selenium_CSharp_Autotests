using System;

namespace Advanced_OO_Topics_11
{
    public class Driver : AbstractPerson
    {
        private int _drivingExperience;

        public Driver(string id, string lastName, string firstName, int age, DateTime dateOfBirth, int drivingExperience) 
            : base(id, lastName, firstName, age, dateOfBirth)
        {
            _drivingExperience = drivingExperience;
        }

        public override string GetExerciseHabits()
        {
            return "Zero time to exercise";
        }

        public DateTime GetDateOfBirth()
        {
            return base._dateOfBirth;
        }
    }
}