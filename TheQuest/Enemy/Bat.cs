using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    class Bat : Enemy
    {
        public int MaxDamage {get; private set;}
        public Bat(Game game, Point location) : base(game, location, 6)
        {
            MaxDamage = 2;
        }

        public override void Move(Direction dir, Rectangle border)
        {
           // int rand = random.Next(1);
           /*
            * 
            * 
            * 
            if(rand == 0)
            {
                //오른쪽에 플레이어가 있다면
                if(game.playerLocation.X - base.Location.X < 0)
                {
                    base.Move(Direction.Right, game.Boundaries); 
                }
                //왼쪽
                else if(game.playerLocation.X - base.Location.X > 0)
                {
                    base.Move(Direction.Left, game.Boundaries);

                }
                //위에
                else if(game.playerLocation.Y - base.location.Y > 0)
                {
                    base.Move(Direction.Up, game.Boundaries);

                }
                //아래
                else if (game.playerLocation.Y - base.location.Y < 0)
                {
                    base.Move(Direction.Down, game.Boundaries);
                }
            }
            else
            {
                int dir = random.Next((int)Direction.Right + 1) - 1;
                base.Move((Direction)dir, game.Boundaries);
            }
           */
        }
    }
}
