using System;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public class PlayEvent : Ticket
    {
        public string gameName;
        public PlayEvent(double price, int place, DateTime dateOfEvent, string gameName) : base(price, place, dateOfEvent)
        {
            this.gameName = gameName;
        }
        public override string EventType => "Play event";

        public override string ToString()
        {
            return base.ToString() + $"Game name: {gameName}";
        }
    }
}