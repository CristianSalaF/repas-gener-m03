namespace MyLibrary
{
    public class Math
    {
        public static float FindDiscountPercent(float price, float discount)
        {
            return (discount / price) * 100;
        }
    }
}
