using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class MonsterC : Monster
    {
        public MonsterC(string name, int hit_point, int power, int defence, int speed)
            : base(_name : name + "C", _hit_point: hit_point, _power: power, _defence: defence, _speed: speed)
        {

        }

        public override void attack(in Monster other)
        {
            other.isAttacked(power + (int)(defence / 2));
        }
    }
}
