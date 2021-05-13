using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MachineB : BaseMachine
    {
        public MachineB(int bet) : base(bet) { }

        public override bool run()
        {
            if (prize <= 0)
            {
                return false;
            }

            Random r = new System.Random();

            if (r.NextDouble() >= 0.1)
            {
                prize = (int)(prize * 1.1);
            }
            else
            {
                prize = 0;
            }

            return true;
        }
    }
}
