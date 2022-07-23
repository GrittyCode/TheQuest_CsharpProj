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

        public override void Move(Random random)
        {
           
        }
    }
}
