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
        private Weapon equippedWeapon = null;
        private int hitPoints;
        //프로퍼티를 통한 힛 포인트 관리
        public int HitPoints { get { return hitPoints; } }

        public List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();

                foreach (Weapon weapon in inventory)
                {
                    if(weapon is RedPotion)
                    {
                        RedPotion potion = weapon as RedPotion;
                        if (!potion.Used)
                            names.Add(weapon.Name);
                    }
                    else if(weapon is BluePotion)
                    {

                        BluePotion potion = weapon as BluePotion;
                        if (!potion.Used)
                            names.Add(weapon.Name);
                    }
                    else
                        names.Add(weapon.Name);
                }
                   

                return names;
            }
           
        }



        public Player(Game game, Point location) : 
            base(game, location)
        {
            hitPoints = 10;
        }
        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);

        }
        public void IncreaseHP(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Move(Direction dir)
        {
            base.location = Move(dir, game.Boundaries);
            if(!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 10))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }            
            }

            foreach (Weapon item in game.ItemInRoom)
            {
                if (Nearby(item.Location, 10))
                {
                    item.PickUpWeapon();
                    inventory.Add(item);
                }
            }
        }

        public void Attack(Direction dir, Random rand)
        {
            if(equippedWeapon != null)
                equippedWeapon.Attack(dir, rand);
        }
    }
}
