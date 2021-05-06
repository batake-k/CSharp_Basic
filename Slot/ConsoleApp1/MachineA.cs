using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MachineA : BaseMachine
    {
        public MachineA(int bet) : base(bet) { }

        public override bool run()
        {
            Random r = new System.Random();

            if(r.NextDouble() >= 0.5)
            {
                prize = (int)(prize * 1.5);
            }
            else
            {
                prize = (int)(prize * 0.5);
            }

            return true;
        }
    }
}
