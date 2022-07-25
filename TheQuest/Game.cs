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

        public List<Weapon> ItemInRoom = new List<Weapon>();

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
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(rand);
            }
        }
        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            ItemInRoom.Clear();
            WeaponInRoom = null;
            m_player.inventory.Clear();

            level++;
            switch (level)
            {
                case 1:
                    {
                        Enemies = new List<Enemy>()
                        { new Bat(this, GetRandomLocation(random))};
                        WeaponInRoom = new Sword(this,GetRandomLocation(random));
                        ItemInRoom.Add(new RedPotion(this, GetRandomLocation(random)));
                    }
                    break;
            
            }

        }
        public void Equip(string weaponName)
        {
            m_player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return m_player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            m_player.Hit(maxDamage, random);
        }
        
        public void IncreasPlayerHealth(int health, Random rand)
        {
            m_player.IncreaseHP(health, rand);
        }

        public void Attack(Direction dir, Random rand)
        {
            m_player.Attack(dir, rand);
            foreach(Enemy enemy in Enemies)
            {
                enemy.Move(rand);
            }
        }

    }
}
