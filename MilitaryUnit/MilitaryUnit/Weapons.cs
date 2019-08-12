﻿using System;
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
            power = 2.0;
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
            power = 5.0;
            reach = 25.0;
            count = 6;
            accuracy = 0.8;
        }
        public override double Attack()
        {
            Random r = new Random();

            if (r.NextDouble() <= accuracy && count > 0)
            {
                count--;
                return power;
            }
            else if (count == 0)
            {
                Console.WriteLine("You have no more Pilums.");
            }
            return 0;
        }
    }
}
