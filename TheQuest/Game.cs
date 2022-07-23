using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        private int level = 0;
        public int Level { get { return level; } }

        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        private Player m_player;
        public Point playerLocation { get { return m_player.Location; } }
        public int playerHealth { get { return m_player.HitPoints; } }


        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            m_player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void Move(Direction dir, Random rand)
        {
            m_player.Move(dir);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    {
                        Enemies = new List<Enemy>()
                        { new Bat(this, GetRandomLocation(random))};

                    }
                    break;
            
            }

        }
    }
}
