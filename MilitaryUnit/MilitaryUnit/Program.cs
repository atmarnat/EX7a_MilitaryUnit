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
            double oldHealth1;
            double oldHealth2;
            Velites v1 = new Velites();
            Hastati h1 = new Hastati();
            Principes p1 = new Principes();
            Triarii t1 = new Triarii();

            oldHealth1 = v1.ViewHealth();
            oldHealth2 = t1.ViewHealth();
            while (v1.IsDead() == false && t1.IsDead() == false)
            {
                Console.WriteLine($"Turn {count}");
                t1.Health(v1.Attack(count));
                if(t1.ViewHealth() != oldHealth2)
                {
                    oldHealth2 = t1.ViewHealth();
                    Console.WriteLine($"\t{v1.Name()} attacks {t1.Name()}. {t1.Name()} has {t1.ViewHealth()} hp remaining.");
                }
                v1.Health(t1.Attack(count));
                if (v1.ViewHealth() != oldHealth1)
                {
                    oldHealth1 = v1.ViewHealth();
                    Console.WriteLine($"\t{t1.Name()} attacks {v1.Name()}. {v1.Name()} has {v1.ViewHealth()} hp remaining.");
                }
                
                count++;
            }
            Console.WriteLine();
            count = 1;
            oldHealth1 = h1.ViewHealth();
            oldHealth2 = p1.ViewHealth();
            while (p1.IsDead() == false && h1.IsDead() == false)
            {
                Console.WriteLine($"Turn {count}");
                p1.Health(h1.Attack(count));
                if (p1.ViewHealth() != oldHealth2)
                {
                    oldHealth2 = p1.ViewHealth();
                    Console.WriteLine($"\t{h1.Name()} attacks {p1.Name()}. {p1.Name()} has {p1.ViewHealth()} hp remaining.");
                }
                h1.Health(t1.Attack(count));
                if (h1.ViewHealth() != oldHealth1)
                {
                    oldHealth1 = h1.ViewHealth();
                    Console.WriteLine($"\t{p1.Name()} attacks {h1.Name()}. {h1.Name()} has {h1.ViewHealth()} hp remaining.");
                }
                
                count++;
            }
        }
    }
}
