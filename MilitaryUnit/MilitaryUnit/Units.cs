using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitParentClasses;
using MilitaryUnitArmor;
using MilitaryUnitWeapons;

namespace MilitaryUnits
{
    public class Velites : Unit
    {
        Pilum p;
        public Velites() : base()
        {
            p = new Pilum();
            name = "Velites";
            armorLevel = 5.0;
            attack = p.Attack();
            speed = 3;
            healthPoints = 8;
        }
        public override void Description()
        {
            Console.WriteLine("The velites were mainly poorer citizens who could not afford to equip themselves properly. Their primary function was to act as skirmishers – javelin-throwers, who would engage the enemy early in order either to harass them or to cover the movement of troops behind them. After throwing their javelins, they would retreat through the gaps between the maniples, screened from the attack of the enemy by the heavy infantry lines.");
        }
        public override void Defense()
        {
            armorLevel = 5.0;
        }
        public double Attack(int count)
        {
            if (count % speed == 0)
            {
                return attack;
            }
            return 0;
        }

    }
    public class Legionnaire : Unit
    {
        protected Equip head = new Equip(Slot.Helm);
        protected BodyArmor body;
        protected Equip arms = new Equip(Slot.Arms);
        protected Equip legs = new Equip(Slot.Legs);

        public Legionnaire() : base()
        {
            name = "Legionnaire";
            body = new BodyArmor(Body.Ringmail);
            Defense();
            speed = 2;
            attack = 1.0;
            healthPoints = 10;
        }
        public override void Description()
        {
            Console.WriteLine("This was the principal unit of the legion. The heavy infantry was composed of citizen legionaries that could afford the equipment composed of an iron helmet, shield, armour and pilum.");
        }
        public override void Defense()
        {
            armorLevel = head.SetArmor() + body.SetArmor() + arms.SetArmor() + legs.SetArmor();
        }
    }
    public class Hastati : Legionnaire
    {
        Spear s;
        public Hastati() : base()
        {
            s = new Spear();
            name = "Hastati";
            speed = 2;
            Defense();
            attack = s.Attack();
        }
        public override void Description()
        {
            Console.WriteLine("Inexperienced soldiers considered to be less reliable than other Legionnaires.");
        }
        public double Attack(int count)
        {
            if (count % speed == 0)
            {
                return attack;
            }
            return 0;
        }
    }
    public class Principes : Legionnaire
    {
        Gladius g;
        public Principes() : base()
        {
            body = new BodyArmor(Body.Scalemail);
            g = new Gladius();
            name = "Principes";
            Defense();
            armorLevel += g.Armor();
            attack = g.Attack();
            speed = 1;
            healthPoints = 15.0;
        }
        public override void Description()
        {
            Console.WriteLine("These were the more experienced soldiers, often better equipped than the Hastati, and having more experience on the battlefield.");
        }
        public double Attack(int count)
        {
            if (count % speed == 0)
            {
                return attack;
            }
            return 0;
        }
    }
    public class Triarii : Legionnaire
    {
        Gladius g;
        public Triarii() : base()
        {
            body = new BodyArmor(Body.Plate);
            g = new Gladius();
            name = "Triarii";
            Defense();
            armorLevel += g.Armor();
            attack = g.Attack();
            speed = 1;
            healthPoints = 20.0;
        }
        public override void Description()
        {
            Console.WriteLine("The veteran soldiers, to be used in battle only in extreme situations.");
        }
        public double Attack(int count)
        {
            if (count % speed == 0)
            {
                return attack;
            }
            return 0;
        }
    }
}
