using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    class Enemy : Mover
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

        public virtual void Move(Direction dir, Rectangle border) { base.Move(dir, border); }


    }
}
