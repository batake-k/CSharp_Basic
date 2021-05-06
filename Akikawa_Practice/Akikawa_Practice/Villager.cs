using System;

namespace Akikawa_Practice
{
    class Villager
    {
        protected int hp;
        public Villager(int _hp)
        {
            hp = _hp;
        }

        public virtual void writeStatus()
        {
            Console.WriteLine("HP: " + hp);
        }
    }

    public interface power
    {
         public int power { get; set; }
    }

    public interface magic_power
    {
        public int magic_power { get; set; }
    }
}
