using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void Cant_Set_Distance_Less_That_Zero()
        {
            Trip badTrip = new Trip();
            Assert.ThrowsException<ArgumentException>(() => badTrip.Distance = -10);
        }

        [TestMethod]
        public void Cant_Set_Total_Cost_Of_Gasoline_Less_That_Zero()
        {
            Trip badTrip = new Trip();
            Assert.ThrowsException<ArgumentException>(() => badTrip.TotalCostOfGasoline = -10);
        }

        [TestMethod]
        public void Cant_Set_Number_Of_Liters_Consumed_Less_That_Zero()
        {
            Trip badTrip = new Trip();
            Assert.ThrowsException<ArgumentException>(() => badTrip.NumberOfLittersConsumed = -10);
        }

        [TestMethod]
        public void Can_Set_All_Properties_In_Constructor()
        {
            Trip tripToMoscow = new Trip("Moscow", 100, 458, 10);
            Assert.AreEqual("Moscow", tripToMoscow.Destination);
            Assert.AreEqual(100, tripToMoscow.Distance);
            Assert.AreEqual(458, tripToMoscow.TotalCostOfGasoline);
            Assert.AreEqual(10, tripToMoscow.NumberOfLittersConsumed);
        }

        [TestMethod]
        public void Can_Get_Kilometers_Per_Liter()
        {
            Trip tripToMoscow = new Trip
            {
                Distance = 100,
                NumberOfLittersConsumed = 10
            };

            var kilometersPerLitter = tripToMoscow.KilometersPerLiter();

            Assert.AreEqual(tripToMoscow.Distance / tripToMoscow.NumberOfLittersConsumed, kilometersPerLitter);
        }

        [TestMethod]
        public void Can_Get_Cost_Per_Kilometer()
        {
            const double distance = 105;
            const double totalCostOfGasoline = 480.6;


            Trip tripToMoscow = new Trip
            {
                Distance = distance,
                TotalCostOfGasoline = totalCostOfGasoline
            };

            var totalCostPerKilometer = tripToMoscow.CostPerKilometer();

            Assert.AreEqual(totalCostOfGasoline / distance, totalCostPerKilometer);
        }

        [TestMethod]
        public void Can_Get_Trip_String()
        {
            const double distance = 105;
            const double totalCostOfGasoline = 480.6;
            const string destination = "Moscow";
            const double numberOfLitersConsumed = 10;


            Trip tripToMoscow = new Trip
            {
                Distance = distance,
                TotalCostOfGasoline = totalCostOfGasoline,
                Destination = destination,
                NumberOfLittersConsumed = numberOfLitersConsumed
            };

            Console.WriteLine(tripToMoscow);
        }
    }
}