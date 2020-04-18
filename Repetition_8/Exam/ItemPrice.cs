using System.Globalization;

namespace Repetition_8.Exam
{
    public class ItemPrice
    {
        public decimal ItemWholesalePrice { get ; set ;}

        public ItemPrice(decimal wholesalePrice)
        {
            ItemWholesalePrice = wholesalePrice;
        }

        public override string ToString()
        {
            return $"{string.Format(new CultureInfo("ru-RU",false),"{0:c2}", ItemWholesalePrice)}";
        }
    }
}