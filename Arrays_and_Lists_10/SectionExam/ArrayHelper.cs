using System;
using System.Collections;
using System.Globalization;

namespace Arrays_and_Lists_10
{
    public class ArrayHelper
    {
        public static void RemoveStringsFromArray(ref ArrayList array)
        {
            var elementsForRemove = new ArrayList();
            
            foreach (var element in array)
            {
                try
                {
                    Int32.Parse(element.ToString());
                }
                catch
                {
                    elementsForRemove.Add(element);
                }
            }

            foreach (var element in elementsForRemove)
            {
                var indexOfRemovingElementInOriginalArray = array.IndexOf(element);
                array.RemoveAt(indexOfRemovingElementInOriginalArray);
            }
        }

        public static int SumAllNumericInArray(ArrayList array)
        {
            var sum = 0;
            RemoveStringsFromArray(ref array);
            foreach (var element in array)
            {
               sum += Convert.ToInt32(element);
            }

            return sum;
        }
    }
}