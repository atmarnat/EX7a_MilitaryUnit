using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnitParentClasses
{
    public enum Slot {Helm, Body, Arms, Legs }
    public enum Body { Ringmail, Scalemail, Plate }
    public class WeaponStats
    {
        protected double power;
        protected double reach;

        public WeaponStats()
        {
            power = 0.0;
            reach = 0.0;
        }

        virtual public double Attack()
        {
            return power;
        }

    }
    public class Armor
    {
        protected double armor;
        protected Slot thisSlot;
        protected Body thisBody;

        public Armor()
        {
            armor = 0.0;
            thisSlot = Slot.Body;
        }
    }
    public class Unit
    {
        protected string name;
        protected double armorLevel;
        protected int speed;
        protected double attack;
        protected double healthPoints;

        public Unit()
        {
            name = "Civilian";
            armorLevel = 0.0;
            speed = 10;
            attack = 0.0;
            healthPoints = 1.0;
        }
        public bool IsDead()
        {
            if (healthPoints <= 0.0)
            {
                Console.WriteLine($"{name} has died.");
                return true;
            }
            return false;
        }
        virtual public void Description()
        {
            Console.WriteLine("A non-military unit.");
        }
        public void Name()
        {
            Console.WriteLine(name);
        }
        virtual public void Defense()
        {
            armorLevel = 0.0;
        }
        public void Health(double damage)
        {
            double damageReduction = 1 - ((armorLevel * 10) / 2) / 100;
            healthPoints -= damage * damageReduction;
        }
        public void ViewHealth()
        {
            Console.WriteLine(healthPoints);
        }
        public void About()
        {
            Console.WriteLine($"unit type is {name}");
            Console.WriteLine($"unit speed is {speed}");
            //Console.WriteLine($"unit turn meter is {myTurn}");
            Console.WriteLine($"unit attack power is {attack}");
            Console.WriteLine($"unit health is {healthPoints}");
            Console.WriteLine($"unit armor is {armorLevel}");
    }
    }
}
