using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace TheQuest
{
    class Player : Mover
    {
        //프로퍼티를 통한 힛 포인트 관리
        public int HitPoints { get; private set; }

        public Player(Game game, Point location) : 
            base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {

        }

        public void IncreaseHP(int health, Random random)
        {

        }

        public void Move(Direction dir)
        {
            base.location = Move(dir, game.Boundaries);
        }
    }
}
