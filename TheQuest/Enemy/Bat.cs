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

        public override void Move(Random rand)
        {
            int randIdx = rand.Next(0,2);

            if(randIdx == 0)
            {
                Direction dir =  base.FindPlayerDierection(game.playerLocation);
                location = Move(dir, game.Boundaries);
            }
            else
            {
                Direction dir = (Direction)rand.Next((int)Direction.Up,(int)Direction.Right);
                location = Move(dir, game.Boundaries);
            }

            if(NearPlayer())
            {
                game.HitPlayer(MaxDamage, rand);
            }
        }
    }
}
