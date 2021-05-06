using System;
using System.Collections.Generic;
using System.Text;

namespace Akikawa_Practice
{
    class Wizard : Villager, magic_power
    {
        public int magic_power { get; set; }

        public Wizard(int _hp, int _magic_power) : base(_hp)
        {
            magic_power = _magic_power;
        }

        public override void writeStatus()
        {
            base.writeStatus();
            Console.WriteLine("MAGIC POWER: " + magic_power);
        }
    }
}
