using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "My name is Aleksandr";
            Console.WriteLine(str);
            string subString = str.Substring(11);
            Console.WriteLine(subString);

        }

        [TestMethod]
        public void Joing_Strings_Together()
        {
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string name = new string(chars);
            Console.WriteLine(name);
        }
    }
}
