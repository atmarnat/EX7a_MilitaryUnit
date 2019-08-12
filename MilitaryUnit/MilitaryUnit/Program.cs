using System;
using MilitaryUnits;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are the Roman Legion!");
            int count = 1;
            Velites v1 = new Velites();
            Triarii t1 = new Triarii();

            while (v1.IsDead() == false && t1.IsDead() == false)
            {
                t1.Health(v1.Attack(count));
                t1.ViewHealth();
                v1.Health(t1.Attack(count));
                v1.ViewHealth();
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
