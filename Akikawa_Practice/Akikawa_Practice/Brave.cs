using System;
using System.Collections.Generic;
using System.Text;

namespace Akikawa_Practice
{
    class Brave : Villager, power, magic_power
    {
        public int power { get; set; }
        public int magic_power { get; set; }

        public Brave(int _hp, int _power, int _magic_power) : base(_hp)
        {
            power = _power;
            magic_power = _magic_power;
        }

        public override void writeStatus()
        {
            base.writeStatus();
            Console.WriteLine("POWER: " + power);
            Console.WriteLine("MAGIC POWER: " + magic_power);
        }
    }
}
