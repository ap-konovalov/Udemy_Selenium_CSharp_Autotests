using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods_9
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void Tuple_Test()
        {
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "cat", true);

            Assert.AreEqual(1, myTuple.Item1);
            
            Assert.AreNotEqual("dog", myTuple.Item2);
            
            Assert.IsTrue(myTuple.Item3);
        }
    }
}