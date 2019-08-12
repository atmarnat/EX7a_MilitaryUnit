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
            //v1.Distance(10);
            //v1.Attack();

            Principes p1 = new Principes();
           // p1.Distance(1);
           // p1.Attack();

            //v1.About();
            Console.WriteLine("");
            //p1.About();
        }
    }
}
