using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods_9
{
    [TestClass]
    public class MathClassTest
    {
        [TestMethod]
        public void Call_Square_Static_Method()
        {
            int number = 10;
            int squareOfNumber = MathClass.Square(number);
            
            Assert.AreEqual(100, squareOfNumber);
        }

        [TestMethod]
        public void Call_Square_Static_Named_Parameters()
        {
            Assert.AreEqual(36, MathClass.Square(value:6));
        }
        
        [TestMethod]
        public void Call_Add_Static_Named_Parameters()
        {
            int sum9 = MathClass.Add(5, 4);
          
            int sum12 = MathClass.Add(number1:6, number2:6);

            int number = 5;
            int sum13 = MathClass.Add(number, number2:8);

            int sum15 = MathClass.Add(5);
        }
        
        [TestMethod]
        public void Call_Add_Static_Optional_Parameters()
        {
            int sum14 = MathClass.Add(4);

            int sum15 = MathClass.Add();

            int sum9 = MathClass.Add(number2: 4);
        }


        [TestMethod]
        public void Test_Out_Parameter()
        {
            int result;
            MathClass.SunWithOut(5,4, out result);
            Assert.AreEqual(9,result);
        }       
        
        [TestMethod]
        public void Test_Ref_Parameter()
        {
            int result = 0;
            
            MathClass.NumbersRef(ref result);
            Assert.AreEqual(7,result);
        }
    }
}
