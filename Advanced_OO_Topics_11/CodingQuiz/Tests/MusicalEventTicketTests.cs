using System;
using NUnit.Framework;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public class MusicalEventTicketTests
    {
        private double _price;
        private int _place;
        private DateTime _dateOfEvent;
        private string _performer;

        [SetUp]
        public void EventSetup()
        {
            _price = 99.9;
            _place = 1;
            _dateOfEvent = DateTime.Today;
            _performer = "AC/DC";
        }
        
        [Test]
        public void WhenSetMusicalEvent_ThenToStringMethodOverriden()
        {
            MusicalEvent concert = new MusicalEvent(_price, _place, _dateOfEvent, _performer);

            Assert.True(concert.ToString().Contains("Performer: AC/DC"));
        }

        [Test]
        public void WhenSetMusicalEvent_ThenEventTypeIsMusicalEvent()
        {
            MusicalEvent concert = new MusicalEvent(_price, _place, _dateOfEvent, _performer);

            Assert.AreEqual("Musical event", concert.EventType);
        }
        
        [Test]
        public void WhenSetMusicalEvent_ThenPerformerSet()
        {
            MusicalEvent concert = new MusicalEvent(_price, _place, _dateOfEvent, _performer);

            Assert.AreEqual(_performer, concert.performer);
        }
    }
}