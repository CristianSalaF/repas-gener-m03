using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix el preu seguit del preu amb descompte: ");
            Console.WriteLine($"Tenen un {MyLibrary.Math.FindDiscountPercent(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()))}% de descompte.");
        }
    }
}
