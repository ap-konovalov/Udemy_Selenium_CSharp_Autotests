using System;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public abstract class BaseTicket
    {
        private double _price;
        private int _place;
        private DateTime _dateOfEvent;

        public abstract string EventType
        {
            get;
        }

        protected BaseTicket(double price, int place, DateTime dateOfEvent)
        {
            _price = price;
            _place = place;
            _dateOfEvent = dateOfEvent;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetPlace()
        {
            return _place;
        }

        public DateTime GetDateOfEvent()
        {
            return _dateOfEvent;
        }

        public override string ToString()
        {
            return $"Price: {GetPrice()}\n" +
                   $"Place: {GetPlace()}\n" +
                   $"Date of event: {GetDateOfEvent()}\n" +
                   $"Event type: {EventType}\n";
        }
    }
}