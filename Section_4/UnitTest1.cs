using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Section_4
{
    [TestClass]
    [TestCategory("Quiz")]
    public class UnitTest1
    {
        private int a;
        private static TestContext _testContext;

        [TestInitialize]
        public void RunBeforeEverTest()
        {
            a = 1;
            Trace.WriteLine("TestIntialize trace write");
        }

        [TestCleanup]
        public void RunAfeterEverTest()
        {
            Trace.WriteLine("TestCleanup trace write");
        }

        [ClassInitialize]
        public static void RunBeforeAllOfTheTestMethodStarted(TestContext testContext)
        {
            _testContext = testContext;
            Trace.WriteLine("ClassIntialize trace write");
        }

        [ClassCleanup]
        public static void RunAfterEveryTestClass()
        {
            Trace.WriteLine("ClassCleanup trace write");
        }

        [TestMethod]
        [Description("there are demo unit test")]
        public void TestMethod1()
        {
            var b = 1;
            Assert.AreEqual(2, a + b);
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("Fail it now");
        }


        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
