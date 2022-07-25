using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    interface IPotion
    {
        bool Used { get; }
    }
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location) { Used = false; }

        public bool Used { get; private set; }

        public override string Name { get { return "RedPotion"; } }

        public override void Attack(Direction dir, Random rand)
        {
            game.IncreasPlayerHealth(10, rand);
            Used = true;
        }

        public void UsePotion(Random rand)
        {
            game.IncreasPlayerHealth(10, rand);
            Used = true;
        }

    }
}
