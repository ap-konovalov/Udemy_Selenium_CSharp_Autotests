using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace Advanced_OO_Topics_11.CodingQuiz
{
    public class BaseEventPropertiesTests
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
        public void WhenSetEvent_ThenEventPriceSet()
        {
            PlayEvent amazingGame = new PlayEvent(_price, _place, _dateOfEvent, _gameName);
            
            Assert.AreEqual(_price, amazingGame.GetPrice());
        }       
        
        [Test]
        public void WhenSetEvent_ThenEventPlaceSet()
        {
            PlayEvent amazingGame = new PlayEvent(_price, _place, _dateOfEvent, _gameName);
            
            Assert.AreEqual(_place, amazingGame.GetPlace());
        }       
        
        [Test]
        public void WhenSetEvent_ThenDateOfEventSet()
        {
            PlayEvent amazingGame = new PlayEvent(_price, _place, _dateOfEvent, _gameName);
            
            Assert.AreEqual(_dateOfEvent, amazingGame.GetDateOfEvent());
        }
        
        [Test]
        public void WhenSetEvent_ThenToStringMethodOverriden()
        {
            PlayEvent amazingGame = new PlayEvent(_price, _place, _dateOfEvent, _gameName);
            
            Assert.True(amazingGame.ToString().Contains($"Price: {_price}\nPlace: {_place}\nDate of event: {_dateOfEvent}\nEvent type: {amazingGame.EventType}"));
        }
    }
}