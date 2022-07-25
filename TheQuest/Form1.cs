using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        Game game;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random(unchecked((int)DateTime.Now.Ticks));
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(rand);

            Picture_Player.Visible = true;
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            Picture_Player.Location = game.playerLocation;
            label_Player_HitPoints.Text = game.playerHealth.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    Picture_Bat.Location = enemy.Location;
                    label_Bat_Hitpoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                    else
                    {
                        showBat = false;
                        enemiesShown--;
                    }
                }
            }
    

            Picture_Bat.Visible = showBat;
            label_Bat_Hitpoints.Visible = showBat;
            Picture_Ghost.Visible = showGhost;
            label_Ghost_HitPoints.Visible = showGhost;
            Picture_Ghoul.Visible = showGhoul;
            label_Ghoul_HitPoints.Visible = showGhoul;

            
            Picture_Inventory_Sword.Visible =  game.CheckPlayerInventory("Sword");
            Picture_Inventory_Bow.Visible = game.CheckPlayerInventory("Bow");
            Picture_Inventory_Mace.Visible = game.CheckPlayerInventory("Mace");



            Picture_Inventory_RedPotion.Visible = (game.CheckPlayerInventory("RedPotion"));
            Picture_Inventory_BluePotion.Visible = game.CheckPlayerInventory("BluePotion");


            Picture_Sword.Visible = false;
            Picture_Bow.Visible = false;
            Picture_Red_potion.Visible = false;
            Picture_Blue_Potion.Visible = false;
            Picture_Mace.Visible = false;


            Control weaponcontrol = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponcontrol = Picture_Sword; break;
                case "Bow":
                    weaponcontrol = Picture_Bow; break;
                case "Mace":
                    weaponcontrol = Picture_Mace; break;
            }

            weaponcontrol.Location = game.WeaponInRoom.Location;
            weaponcontrol.Visible = !game.WeaponInRoom.PickedUp;


            foreach(Weapon item in game.ItemInRoom)
            {
                if(item is RedPotion)
                {
                    Picture_Red_potion.Location = item.Location;
                    Picture_Red_potion.Visible = (!item.PickedUp);
                }
                else if(item is BluePotion)
                {
                    Picture_Blue_Potion.Location = item.Location;
                    Picture_Blue_Potion.Visible = (!item.PickedUp);
                }
            }

            //gameexit
            if(game.playerHealth <= 0)
            {
                MessageBox.Show("You died..");
                Application.Exit();
            }

            if(enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(rand);
                UpdateCharacters();
            }
        }
        private void Table_Hit_Point_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Move_Up_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, rand);
            UpdateCharacters();
        }

        private void Buttom_Move_Left_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, rand);
            UpdateCharacters();
        }

        private void Button_Move_Down_Click(object sender, EventArgs e)
        {              
            game.Move(Direction.Down, rand);
            UpdateCharacters();
        }

        private void Button_Move_Right_Click(object sender, EventArgs e)
        {   
            game.Move(Direction.Right, rand);
            UpdateCharacters();
        }

        private void Button_Attack_Down_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, rand);
            UpdateCharacters();
        }

        private void Button_Attack_Up_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, rand);
            UpdateCharacters();
        }

        private void Button_Attack_Right_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, rand);
            UpdateCharacters();
        }

        private void Button_Attack_Left_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, rand);
            UpdateCharacters();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Inventory_Sword_Click(object sender, EventArgs e)    
        {
            if (game.CheckPlayerInventory("Sword"))
                game.Equip("Sword");
            Picture_Inventory_Sword.BorderStyle = BorderStyle.FixedSingle;
            Picture_Inventory_Bow.BorderStyle = BorderStyle.None;
            Picture_Inventory_Mace.BorderStyle = BorderStyle.None;
        }

        private void Picture_Inventory_Bow_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("Bow"))
                game.Equip("Bow");
            Picture_Inventory_Sword.BorderStyle = BorderStyle.None;
            Picture_Inventory_Bow.BorderStyle = BorderStyle.FixedSingle;
            Picture_Inventory_Mace.BorderStyle = BorderStyle.None;
        }

        private void Picture_Inventory_Mace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
                game.Equip("Mace");
            Picture_Inventory_Sword.BorderStyle = BorderStyle.None;
            Picture_Inventory_Bow.BorderStyle = BorderStyle.None;
            Picture_Inventory_Mace.BorderStyle = BorderStyle.FixedSingle;

        }

        private void Picture_Inventory_RedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("RedPotion"))
            {
                foreach(Weapon item in game.ItemInRoom)
                {
                    if(item is RedPotion)
                    {
                        RedPotion potion = item as RedPotion;
                        if(potion.PickedUp && !potion.Used)
                        {
                            potion.UsePotion(rand);
                            UpdateCharacters();
                        }
                    }
                }
            }
        }

        private void Picture_Inventory_BluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("BluePotion"))
            {
                foreach (Weapon item in game.ItemInRoom)
                {
                    if (item is BluePotion)
                    {
                        BluePotion potion = item as BluePotion;
                        if (potion.PickedUp && !potion.Used)
                        {
                            potion.UsePotion(rand);
                            UpdateCharacters();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
