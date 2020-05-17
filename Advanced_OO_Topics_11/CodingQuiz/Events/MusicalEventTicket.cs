using System;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public class MusicalEvent : BaseTicket
    {
        public string performer;
        
        public MusicalEvent(double price, int place, DateTime dateOfEvent, string performer) : base(price, place, dateOfEvent)
        {
            this.performer = performer;
        }

        public override string EventType => "Musical event";

        public override string ToString()
        {
            return base.ToString() + $"Performer: {performer}";
        }
    }
}