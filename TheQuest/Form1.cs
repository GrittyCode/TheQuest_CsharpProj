using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            Picture_Player.Location = game.playerLocation;
            Picture_Player.Visible = true;
            label_Player_HitPoints.Text = game.playerHealth.ToString();

            foreach(Enemy enemy in game.Enemies)
            {
                Picture_Bat.Location = enemy.Location;
                Picture_Bat.Visible = true;
            }

            Picture_Sword.Visible = true;
            Picture_Sword.Location = game.WeaponInRoom.Location;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
