using System;
using System.Collections;
using NUnit.Framework;

namespace Arrays_and_Lists_10
{
    public class SectionExamTests
    {
        private ArrayList _testArray;

        [SetUp]
        public void GivenArray()
        {
            _testArray = new ArrayList();
            _testArray.Add("Someday");
            _testArray.Add(2);
            _testArray.Add("app");
            _testArray.Add("13.5");
            _testArray.Add("red");
            _testArray.Add(8);
            _testArray.Add(99);
            _testArray.Add("6");
            _testArray.Add("Meatball soup");
            _testArray.Add(18M);
            _testArray.Add("pieces");
            _testArray.Add("14");
        }

        [Test]
        public void WhenRemoveStringsFromArray_ThenArrayDoesntContainStrings()
        {
            ArrayHelper.RemoveStringsFromArray(ref _testArray);

            Assert.AreEqual(6, _testArray.Count);
        }

        [Test]
        public void WhenTryToSumNumberInArray_ThenReturnTheirSum()
        {
            var sumOfArrayNumbers = ArrayHelper.SumAllNumericInArray(_testArray);
            Assert.AreEqual(147, sumOfArrayNumbers);
        }
    }
}