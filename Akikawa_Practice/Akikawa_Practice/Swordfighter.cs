using System;
using System.Collections.Generic;
using System.Text;

namespace Akikawa_Practice
{
    class Swordfighter : Villager, power
    {
        public int power { get; set; }

        public Swordfighter(int _hp, int _power) : base(_hp)
        {
            power = _power;
        }

        public override void writeStatus()
        {
            base.writeStatus();
            Console.WriteLine("POWER: " + power);
        }
    }
}
