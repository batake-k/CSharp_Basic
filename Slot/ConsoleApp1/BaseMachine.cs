using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class BaseMachine
    {
        protected int prize = 0;

        public BaseMachine(int bet)
        {
            prize = bet;
        }

        public int getPrize()
        {
            return prize;
        }

        public abstract bool run();
    }
}
