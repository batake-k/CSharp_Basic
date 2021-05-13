using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MachineC : BaseMachine
    {
        public MachineC(int bet) : base(bet) { }

        public override bool run()
        {
            if (prize <= 11)
            {
                return false;
            }

            prize -= 10;

            Random r = new System.Random();

            if (r.NextDouble() >= 0.5)
            {
                prize = (int)(prize * 2);
            }
            else
            {
                prize = (int)(prize * 0.5);
            }

            return true;
        }
    }
}
