using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitParentClasses;

namespace MilitaryUnitWeapons
{
    public class Gladius : WeaponStats
    {
        double armor;
        public Gladius()
        {
            power = 1.0;
            reach = 1.0;
            armor = 5.0;
        }
        public override double Attack()
        {
            return power;
        }
        public double Armor()
        {
            return armor;
        }
    }

    public class Spear : WeaponStats
    {
        public Spear()
        {
            power = 6.0;
            reach = 3.0;
        }
        public override double Attack()
        { 
            return power;
        }
    }

    public class Pilum : WeaponStats
    {
        int count;
        double accuracy;

        public Pilum()
        {
            power = 30.0;
            reach = 25.0;
            count = 6;
            accuracy = 0.8;
        }
        public override double Attack()
        {
            Random r = new Random();
            count--;
            if (r.NextDouble() <= accuracy && count > 0)
            {
                return power;
            }
            if(r.NextDouble() > accuracy && count > 0)
            {
                Console.WriteLine("You missed.");    
            }
            else if (count == 0)
            {
                Console.WriteLine("You have no more Pilums.");
            }
            return 0;
        }
    }
}
