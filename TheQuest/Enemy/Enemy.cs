using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
        public bool Dead 
        { 
            get { if (HitPoints <= 0) return true; else return false; } 
        }
        public Enemy(Game game, Point location, int hitpoints) :base(game,location)
        {
            HitPoints = hitpoints;
        }

        public abstract void Move(Random rand);
        
        public void Hit(int maxDamage, Random rand)
        {
            HitPoints -= rand.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.playerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDierection(Point playerLocation)
        {
            Direction dir;
            //오른쪽에 플레이어가 있다면
            if (playerLocation.X > location.X + 10)
            {
                dir = Direction.Right;
            }
            //왼쪽
            else if (playerLocation.X  < Location.X - 10)
            {
                dir = Direction.Left;
            }
            else if (playerLocation.Y < location.Y - 10)
            {
                dir = Direction.Up;
            }
            else
            {
                dir = Direction.Down;
            }

            return dir;
        }
        

    }
}
