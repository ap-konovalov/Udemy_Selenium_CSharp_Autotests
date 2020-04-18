using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repetition_8.Exam
{
    [TestClass]
    public class TestItemPriceTable
    {
        [TestMethod]
        public void Show_Sale_Price_Table()
        {
            ItemPrice wholeSalePrice = new ItemPrice(20.00M);

            Console.WriteLine("Whole sale price \t Marked up percentage \t Sale price");

            for (int percentage = 5; percentage <= 10; percentage++)
            {
                var salePrice =  wholeSalePrice.ItemWholesalePrice * percentage * 0.01M + wholeSalePrice.ItemWholesalePrice;
                var salePriceString = $"{string.Format(new CultureInfo("ru-RU", false), "{0:c2}", salePrice)}";
                    
                Console.WriteLine($"{wholeSalePrice} \t\t\t\t {percentage}% \t\t\t\t {salePriceString}");
            }
        }
    }
}