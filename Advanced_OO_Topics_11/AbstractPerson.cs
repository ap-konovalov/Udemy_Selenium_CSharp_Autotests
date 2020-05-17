using System;

namespace Advanced_OO_Topics_11
{
    public abstract class AbstractPerson
    {
        private string _id;
        private string _lastName;
        private string _firstName;
        private int _age;
        protected DateTime _dateOfBirth;

        public AbstractPerson(string id, string lastName, string firstName, int age, DateTime dateOfBirth)
        {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            _age = age;
            _dateOfBirth = dateOfBirth;
        }

        public abstract string GetExerciseHabits();
    }
}