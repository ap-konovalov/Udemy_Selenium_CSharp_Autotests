using NUnit.Framework;

namespace Interfaces_12_Tests.SectionExam
{
    public class ExamTests
    {
        [Test]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual("Page Name 1",pageObject1.PageName);
        }      
        
        [Test]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual("Page Name 2",pageObject2.PageName);
        }
    }
}