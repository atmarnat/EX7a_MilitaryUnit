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

            h1.About();
            Console.WriteLine();

            h1.Attack(1);
            h1.About();
            h1.Attack(2);
            h1.About();
            h1.Attack(3);
            h1.About();

        }
    }
}
