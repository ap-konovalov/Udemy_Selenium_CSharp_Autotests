using System;
using NUnit.Framework;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public class PlayEventTicketTests
    {
        private double _price;
        private int _place;
        private DateTime _dateOfEvent;
        private string _gameName;

        [SetUp]
        public void EventSetup()
        {
            _price = 99.9;
            _place = 1;
            _dateOfEvent = DateTime.Today;
            _gameName = "CS 1.6";
        }
        
        [Test]
        public void WhenSetPlayEvent_ThenEventTypeIsPlayEvent()
        {
            PlayEventTicket amazingGame = new PlayEventTicket(_price, _place, _dateOfEvent, _gameName);

            Assert.AreEqual("Play event", amazingGame.EventType);
        }

        [Test]
        public void WhenSetPlayEvent_ThenGameNameSet()
        {
            PlayEventTicket amazingGame = new PlayEventTicket(_price, _place, _dateOfEvent, _gameName);

            Assert.AreEqual(_gameName, amazingGame.gameName);
        }

        [Test]
        public void WhenSetPlayEvent_ThenToStringMethodOverriden()
        {
            PlayEventTicket amazingGame = new PlayEventTicket(_price, _place, _dateOfEvent, _gameName);

            Assert.True(amazingGame.ToString().Contains("Game name: CS 1.6"));
        }
    }
}