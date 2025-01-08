using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix una temperatura en Celsius, per convertir-la a Fahrenheit");
            Console.WriteLine($"Fahrenheit: {MyLibrary.Math.CelsiusToFrahrenheit(float.Parse(Console.ReadLine()))}");
        }
    }
}