using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix un nombre: ");
            Console.WriteLine(MyLibrary.Math.SecondsToTime(int.Parse(Console.ReadLine())));
        }
    }
}
