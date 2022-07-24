using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction dir, Random rand)
        {
            int radius = 30;
            DamageEnemy(dir, radius,1, rand);
        }
    }
}
