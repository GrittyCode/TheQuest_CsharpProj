using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    class BluePotion : Weapon, IPotion
    {
        public bool Used { get; private set; }

        public BluePotion(Game game, Point location) : base(game,location) { Used = false; }

        public override string Name { get { return "BluePotion"; } }

        public override void Attack(Direction dir, Random rand)
        {
            game.IncreasPlayerHealth(5, rand);
            Used = true;
        }

        public void UsePotion(Random rand)
        {
            game.IncreasPlayerHealth(10, rand);
            Used = true;
        }
    }
}
