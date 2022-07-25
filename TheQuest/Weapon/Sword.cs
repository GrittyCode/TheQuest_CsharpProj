using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction dir, Random rand)
        {
            int radius = 10;
            int checkAllDirection = 0;
            //공격한 방향에 몬스터가 없다면
            while (!DamageEnemy(dir, radius, 3, rand) && checkAllDirection < 3)
            {
                checkAllDirection++;

                if (dir == Direction.Up)
                {
                    dir = Direction.Right;
                }
                else if (dir == Direction.Right)
                {
                    dir = Direction.Down;
                }
                else if (dir == Direction.Down)
                {
                    dir = Direction.Left;
                }
                else
                {
                    dir = Direction.Up;
                }

            }
        }
    }
}
