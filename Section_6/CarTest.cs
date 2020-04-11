using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            Car testCar = new Car("Red", 2, true);
            Assert.AreEqual("Red", testCar.Color);
        }

        [TestMethod]
        public void Car_Acceleration_Method()
        {
            Car testCar = new Car("Red", 2, true);
            testCar.Accelerate();
        }

        [TestMethod]
        public void Car_FamilyCar_Method()
        {
            Car testCar = new Car("Red", 4, true);
            var isFamilyCar = testCar.FamilyCar();
            Assert.IsTrue(isFamilyCar);
        }
    }
}
