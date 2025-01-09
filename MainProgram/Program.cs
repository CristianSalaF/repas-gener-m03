using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix un nombre a convertir de Kelvin a Fahrenheit: ");
            Console.WriteLine(MyLibrary.Math.KelvinToFahrenheit(float.Parse(Console.ReadLine())));
        }
    }
}
