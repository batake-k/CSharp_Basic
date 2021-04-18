using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class Monster
    {
        public string name { get; private set; }
        public int hit_point { get; protected set; }
        protected readonly int power;
        protected readonly int defence;
        public readonly int speed;

        protected const int base_damage = 10;

        public Monster(string _name, int _hit_point, int _power, int _defence, int _speed)
        {
            name = _name;
            hit_point = _hit_point;
            power = _power;
            defence = _defence;
            speed = _speed;
        }

        public virtual void attack(in Monster other)
        {
            other.isAttacked(power);
        }

        public virtual void isAttacked(int _power)
        {
            int damage = base_damage;
            if(_power > defence)
            {
                damage += _power - defence;
            }

            hit_point -= damage;
            Console.WriteLine(name + " is attacked. - " + damage + " points.");
        }

        public void outputStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("hit point: " + hit_point);
            Console.WriteLine("power:     " + power);
            Console.WriteLine("defence:   " + defence);
            Console.WriteLine("speed:     " + speed);
        }
    }
}
