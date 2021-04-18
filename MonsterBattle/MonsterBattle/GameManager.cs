using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class GameManager
    {
        private Monster monster1;
        private Monster monster2;

        public GameManager()
        {
            monster1 = generateMonster("1");
            monster2 = generateMonster("2");
        }

        private Monster generateMonster(string _name)
        {
            Random r = new System.Random();
            int _hit_point = r.Next(80, 121);
            int _power = r.Next(0, 31);
            int _defence = r.Next(0, 31);
            int _speed = r.Next(0, 31);

            Monster m;

            switch(r.Next(0, 3)){
                case 0:
                    m = new MonsterA(name : _name, hit_point: _hit_point, power: _power, defence: _defence, speed: _speed);
                    break;
                case 1:
                    m = new MonsterB(name: _name, hit_point: _hit_point, power: _power, defence: _defence, speed: _speed);
                    break;
                default:
                    m = new MonsterC(name: _name, hit_point: _hit_point, power: _power, defence: _defence, speed: _speed);
                    break;
            }

            return m;
        }

        public void run()
        {
            monster1.outputStatus();
            monster2.outputStatus();

            Random r = new System.Random();

            while(monster1.hit_point > 0 && monster2.hit_point > 0)
            {
                Console.WriteLine("====================================");

                int first = 0;

                if(monster1.speed > monster2.speed)
                {
                    monster1.attack(monster2);
                    first = 1;
                }
                else if(monster2.speed > monster1.speed)
                {
                    monster2.attack(monster1);
                    first = 2;
                }
                else
                {
                    if(r.NextDouble() >= 0.5)
                    {
                        monster1.attack(monster2);
                        first = 1;
                    }
                    else
                    {
                        monster2.attack(monster1);
                        first = 2;
                    }
                }

                if(monster1.hit_point > 0 && monster2.hit_point > 0)
                {
                    if(first == 1)
                    {
                        monster2.attack(monster1);
                    }
                    else
                    {
                        monster1.attack(monster2);
                    }
                }
            }

            Console.WriteLine("====================================");
            monster1.outputStatus();
            monster2.outputStatus();
        }
    }
}
