namespace MyLibrary
{
    public class Math
    {
        public static float KelvinToFahrenheit(float kelvin) 
        {
            return (kelvin - 273.15f) * 9 / 5 + 32f;
        }
    }
}
