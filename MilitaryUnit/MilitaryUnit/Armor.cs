using System;
using System.Collections.Generic;
using System.Text;
using MilitaryUnitParentClasses;

namespace MilitaryUnitArmor
{
    public class BodyArmor : Armor
    {
        public BodyArmor(Body b) : base()
        {
            switch (b)
            {
                case Body.Ringmail:
                    armor = 3.0;
                    break;
                case Body.Scalemail:
                    armor = 4.0;
                    break;
                case Body.Plate:
                    armor = 5.0;
                    break;
                default:
                    Console.WriteLine("How did we get here?");
                    break;
            }
        }
        public double SetArmor()
        {
            return armor;
        }
    }
    public class Equip : Armor
    {
        public Equip(Slot s) : base()
        {
            switch (s)
            {
                case Slot.Helm:
                    armor = 2;
                    break;
                case Slot.Body:
                    armor = 3.0; //default is Ringmail
                    break;
                case Slot.Legs:
                    armor = 1.5;
                    break;
                case Slot.Arms:
                    armor = 1.5;
                    break;
                default:
                    Console.WriteLine("How did we get here?");
                    break;
            }
        }
        public double SetArmor()
        {
            return armor;
        }
    }
}
