using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix els graus Celsius a convertir a Kelvin: ");
            Console.WriteLine(MyLibrary.Math.CelsiusToKelvin(float.Parse(Console.ReadLine())));
        }
    }
}
