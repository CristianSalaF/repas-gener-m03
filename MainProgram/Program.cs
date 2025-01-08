using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix els costats A, B, i l'alçada d'un triangle: ");
            Console.WriteLine(MyLibrary.Math.AreaToTriangle(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
        }
    }
}
