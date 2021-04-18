using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class MonsterB : Monster
    {
        public MonsterB(string name, int hit_point, int power, int defence, int speed)
            : base(_name : name + "B", _hit_point: (int)(hit_point * 1.5), _power: power, _defence: defence, _speed: speed)
        {

        }

        public override void isAttacked(int _power)
        {
            base.isAttacked(_power);
            hit_point += 3;
            Console.WriteLine(name + " is healed. + 3 points.");
        }
    }
}
