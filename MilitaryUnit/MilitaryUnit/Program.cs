using System;
using MilitaryUnits;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are the Roman Legion!");
            Velites v1 = new Velites();
            Hastati h1 = new Hastati();
            Principes p1 = new Principes();
            Triarii t1 = new Triarii();

            v1.About();
            Console.WriteLine("");
            h1.About();
            Console.WriteLine();
            p1.About();
            Console.WriteLine("");
            t1.About();
        }
    }
}
