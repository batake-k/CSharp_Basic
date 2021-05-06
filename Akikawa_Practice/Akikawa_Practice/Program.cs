using System;
using System.Collections.Generic;
using System.Text;

namespace Akikawa_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Villager villager = new Villager(10);
            Swordfighter swordfighter = new Swordfighter(50, 10);
            Wizard wizard = new Wizard(30, 20);
            Brave brave = new Brave(40, 5, 15);

            villager.writeStatus();
            swordfighter.writeStatus();
            wizard.writeStatus();
            brave.writeStatus();
        }
    }
}
