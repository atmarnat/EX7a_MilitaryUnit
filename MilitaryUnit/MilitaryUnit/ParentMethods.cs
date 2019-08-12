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
        protected bool range;

        public WeaponStats()
        {
            power = 0.0;
            reach = 0.0;
            range = false;
        }

        virtual public double Attack()
        {
            return power;
        }

        virtual public bool InRange(double distance)
        {
            range = true;
            return range;
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
        protected double speed;
        protected double myTurn;
        protected double attack;
        protected double healthPoints;
        protected double distance;

        public Unit()
        {
            name = "Civilian";
            armorLevel = 0.0;
            speed = 0.1;
            myTurn = 0.0;
            attack = 0.0;
            healthPoints = 1.0;
            distance = Distance();
        }
        public double Distance(double d = 10)
        {
            return d;
        }
        public bool IsDead()
        {
            if (healthPoints <= 0.0)
                return true;
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
        public double Turn()
        {
            if (myTurn <= 1)
            {
                myTurn += speed;
                return myTurn;
            }
            else if(myTurn > 1 )
            {
                myTurn -= 1 + speed;
                return myTurn;
            }
            return myTurn;
        }
        virtual public void Defense()
        {
            armorLevel = 0.0;
        }
        public double Health(double damage)
        {
            double damageReduction = 1 - ((armorLevel * 10) / 2) / 100;
            healthPoints -= damage * damageReduction;
            return healthPoints;
        }
        public void About()
        {
            Console.WriteLine($"unit type is {name}");
            Console.WriteLine($"unit speed is {speed}");
            Console.WriteLine($"unit turn meter is {myTurn}");
            Console.WriteLine($"unit attack power is {attack}");
            Console.WriteLine($"unit health is {healthPoints}");
            Console.WriteLine($"unit armor is {armorLevel}");
    }
    }
}
