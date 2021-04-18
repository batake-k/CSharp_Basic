using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class MonsterA : Monster
    {
        public MonsterA(string name, int hit_point, int power, int defence, int speed)
            :base(_name : name + "A", _hit_point : hit_point, _power : power, _defence : defence, _speed : speed)
        {

        }

        public override void attack(in Monster other)
        {
            Random r = new System.Random();
            if(r.NextDouble() >= 0.5)
            {
                base.attack(other);
                base.attack(other);
            }
            else
            {
                base.attack(other);
            }
        }
    }
}
