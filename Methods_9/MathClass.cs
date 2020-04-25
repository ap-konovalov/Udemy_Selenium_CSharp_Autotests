namespace Methods_9
{
    public class MathClass
    {
        public static int Square(int value)
        {
            return value * value;
        }

        public static int Add(int number1 = 5, int number2 = 10)
        {
            return number1 + number2;
        }

        public static void SunWithOut(int a, int b, out int result)
        {
            result = a + b;
        }

        public static void NumbersRef(ref int value)
        {
            value = 7;
        }
    }
}