
namespace TheQuest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Table_Hit_Point = new System.Windows.Forms.TableLayoutPanel();
            this.label_Ghoul_HitPoints = new System.Windows.Forms.Label();
            this.label_Ghoul = new System.Windows.Forms.Label();
            this.label_Ghost_HitPoints = new System.Windows.Forms.Label();
            this.label_Ghost = new System.Windows.Forms.Label();
            this.label_Bat_Hitpoints = new System.Windows.Forms.Label();
            this.label_Bat = new System.Windows.Forms.Label();
            this.label_Player = new System.Windows.Forms.Label();
            this.label_Player_HitPoints = new System.Windows.Forms.Label();
            this.MoveBox = new System.Windows.Forms.GroupBox();
            this.Button_Move_Right = new System.Windows.Forms.Button();
            this.Buttom_Move_Left = new System.Windows.Forms.Button();
            this.Button_Move_Down = new System.Windows.Forms.Button();
            this.Button_Move_Up = new System.Windows.Forms.Button();
            this.AttackBox = new System.Windows.Forms.GroupBox();
            this.Button_Attack_Right = new System.Windows.Forms.Button();
            this.Button_Attack_Up = new System.Windows.Forms.Button();
            this.Button_Attack_Left = new System.Windows.Forms.Button();
            this.Button_Attack_Down = new System.Windows.Forms.Button();
            this.Picture_Player = new System.Windows.Forms.PictureBox();
            this.Picture_Sword = new System.Windows.Forms.PictureBox();
            this.Picture_Bat = new System.Windows.Forms.PictureBox();
            this.Picture_Ghoul = new System.Windows.Forms.PictureBox();
            this.Picture_Ghost = new System.Windows.Forms.PictureBox();
            this.Picture_Bow = new System.Windows.Forms.PictureBox();
            this.Picture_Red_potion = new System.Windows.Forms.PictureBox();
            this.Picture_Blue_Potion = new System.Windows.Forms.PictureBox();
            this.Picture_Mace = new System.Windows.Forms.PictureBox();
            this.Picture_Inventory_Sword = new System.Windows.Forms.PictureBox();
            this.Picture_Inventory_Mace = new System.Windows.Forms.PictureBox();
            this.Picture_Inventory_BluePotion = new System.Windows.Forms.PictureBox();
            this.Picture_Inventory_Bow = new System.Windows.Forms.PictureBox();
            this.Picture_Inventory_RedPotion = new System.Windows.Forms.PictureBox();
            this.Table_Hit_Point.SuspendLayout();
            this.MoveBox.SuspendLayout();
            this.AttackBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Red_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Blue_Potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_BluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_RedPotion)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_Hit_Point
            // 
            this.Table_Hit_Point.AutoSize = true;
            this.Table_Hit_Point.ColumnCount = 2;
            this.Table_Hit_Point.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.Table_Hit_Point.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.Table_Hit_Point.Controls.Add(this.label_Ghoul_HitPoints, 1, 3);
            this.Table_Hit_Point.Controls.Add(this.label_Ghoul, 0, 3);
            this.Table_Hit_Point.Controls.Add(this.label_Ghost_HitPoints, 1, 2);
            this.Table_Hit_Point.Controls.Add(this.label_Ghost, 0, 2);
            this.Table_Hit_Point.Controls.Add(this.label_Bat_Hitpoints, 1, 1);
            this.Table_Hit_Point.Controls.Add(this.label_Bat, 0, 1);
            this.Table_Hit_Point.Controls.Add(this.label_Player, 0, 0);
            this.Table_Hit_Point.Controls.Add(this.label_Player_HitPoints, 1, 0);
            this.Table_Hit_Point.Location = new System.Drawing.Point(610, 254);
            this.Table_Hit_Point.Name = "Table_Hit_Point";
            this.Table_Hit_Point.RowCount = 4;
            this.Table_Hit_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table_Hit_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table_Hit_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table_Hit_Point.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table_Hit_Point.Size = new System.Drawing.Size(179, 140);
            this.Table_Hit_Point.TabIndex = 1;
            this.Table_Hit_Point.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Hit_Point_Paint);
            // 
            // label_Ghoul_HitPoints
            // 
            this.label_Ghoul_HitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Ghoul_HitPoints.AutoSize = true;
            this.label_Ghoul_HitPoints.Font = new System.Drawing.Font("굴림", 10F);
            this.label_Ghoul_HitPoints.Location = new System.Drawing.Point(70, 115);
            this.label_Ghoul_HitPoints.Name = "label_Ghoul_HitPoints";
            this.label_Ghoul_HitPoints.Size = new System.Drawing.Size(102, 14);
            this.label_Ghoul_HitPoints.TabIndex = 7;
            this.label_Ghoul_HitPoints.Text = "ghoulHitPoints";
            // 
            // label_Ghoul
            // 
            this.label_Ghoul.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Ghoul.AutoSize = true;
            this.label_Ghoul.Font = new System.Drawing.Font("굴림", 12F);
            this.label_Ghoul.Location = new System.Drawing.Point(3, 114);
            this.label_Ghoul.Name = "label_Ghoul";
            this.label_Ghoul.Size = new System.Drawing.Size(50, 16);
            this.label_Ghoul.TabIndex = 6;
            this.label_Ghoul.Text = "Ghoul";
            // 
            // label_Ghost_HitPoints
            // 
            this.label_Ghost_HitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Ghost_HitPoints.AutoSize = true;
            this.label_Ghost_HitPoints.Font = new System.Drawing.Font("굴림", 10F);
            this.label_Ghost_HitPoints.Location = new System.Drawing.Point(70, 80);
            this.label_Ghost_HitPoints.Name = "label_Ghost_HitPoints";
            this.label_Ghost_HitPoints.Size = new System.Drawing.Size(93, 14);
            this.label_Ghost_HitPoints.TabIndex = 5;
            this.label_Ghost_HitPoints.Text = "ghostHitpoint";
            // 
            // label_Ghost
            // 
            this.label_Ghost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Ghost.AutoSize = true;
            this.label_Ghost.Font = new System.Drawing.Font("굴림", 12F);
            this.label_Ghost.Location = new System.Drawing.Point(3, 79);
            this.label_Ghost.Name = "label_Ghost";
            this.label_Ghost.Size = new System.Drawing.Size(52, 16);
            this.label_Ghost.TabIndex = 4;
            this.label_Ghost.Text = "Ghost";
            // 
            // label_Bat_Hitpoints
            // 
            this.label_Bat_Hitpoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Bat_Hitpoints.AutoSize = true;
            this.label_Bat_Hitpoints.Font = new System.Drawing.Font("굴림", 10F);
            this.label_Bat_Hitpoints.Location = new System.Drawing.Point(70, 45);
            this.label_Bat_Hitpoints.Name = "label_Bat_Hitpoints";
            this.label_Bat_Hitpoints.Size = new System.Drawing.Size(86, 14);
            this.label_Bat_Hitpoints.TabIndex = 3;
            this.label_Bat_Hitpoints.Text = "batHitPoints";
            // 
            // label_Bat
            // 
            this.label_Bat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Bat.AutoSize = true;
            this.label_Bat.Font = new System.Drawing.Font("굴림", 12F);
            this.label_Bat.Location = new System.Drawing.Point(3, 44);
            this.label_Bat.Name = "label_Bat";
            this.label_Bat.Size = new System.Drawing.Size(32, 16);
            this.label_Bat.TabIndex = 2;
            this.label_Bat.Text = "Bat";
            // 
            // label_Player
            // 
            this.label_Player.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Player.AutoSize = true;
            this.label_Player.Font = new System.Drawing.Font("굴림", 12F);
            this.label_Player.Location = new System.Drawing.Point(3, 9);
            this.label_Player.Name = "label_Player";
            this.label_Player.Size = new System.Drawing.Size(52, 16);
            this.label_Player.TabIndex = 0;
            this.label_Player.Text = "Player";
            this.label_Player.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Player_HitPoints
            // 
            this.label_Player_HitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Player_HitPoints.AutoSize = true;
            this.label_Player_HitPoints.Font = new System.Drawing.Font("굴림", 10F);
            this.label_Player_HitPoints.Location = new System.Drawing.Point(70, 10);
            this.label_Player_HitPoints.Name = "label_Player_HitPoints";
            this.label_Player_HitPoints.Size = new System.Drawing.Size(105, 14);
            this.label_Player_HitPoints.TabIndex = 1;
            this.label_Player_HitPoints.Text = "playerHitPoints";
            // 
            // MoveBox
            // 
            this.MoveBox.Controls.Add(this.Button_Move_Right);
            this.MoveBox.Controls.Add(this.Buttom_Move_Left);
            this.MoveBox.Controls.Add(this.Button_Move_Down);
            this.MoveBox.Controls.Add(this.Button_Move_Up);
            this.MoveBox.Location = new System.Drawing.Point(600, 0);
            this.MoveBox.Name = "MoveBox";
            this.MoveBox.Size = new System.Drawing.Size(200, 120);
            this.MoveBox.TabIndex = 0;
            this.MoveBox.TabStop = false;
            this.MoveBox.Text = "MOVE";
            // 
            // Button_Move_Right
            // 
            this.Button_Move_Right.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Move_Right.Location = new System.Drawing.Point(127, 48);
            this.Button_Move_Right.Name = "Button_Move_Right";
            this.Button_Move_Right.Size = new System.Drawing.Size(58, 30);
            this.Button_Move_Right.TabIndex = 3;
            this.Button_Move_Right.Text = "Right";
            this.Button_Move_Right.UseVisualStyleBackColor = false;
            this.Button_Move_Right.Click += new System.EventHandler(this.Button_Move_Right_Click);
            // 
            // Buttom_Move_Left
            // 
            this.Buttom_Move_Left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Buttom_Move_Left.Location = new System.Drawing.Point(11, 48);
            this.Buttom_Move_Left.Name = "Buttom_Move_Left";
            this.Buttom_Move_Left.Size = new System.Drawing.Size(58, 30);
            this.Buttom_Move_Left.TabIndex = 2;
            this.Buttom_Move_Left.Text = "Left";
            this.Buttom_Move_Left.UseVisualStyleBackColor = false;
            this.Buttom_Move_Left.Click += new System.EventHandler(this.Buttom_Move_Left_Click);
            // 
            // Button_Move_Down
            // 
            this.Button_Move_Down.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Move_Down.Location = new System.Drawing.Point(70, 90);
            this.Button_Move_Down.Name = "Button_Move_Down";
            this.Button_Move_Down.Size = new System.Drawing.Size(58, 30);
            this.Button_Move_Down.TabIndex = 1;
            this.Button_Move_Down.Text = "Down";
            this.Button_Move_Down.UseVisualStyleBackColor = false;
            this.Button_Move_Down.Click += new System.EventHandler(this.Button_Move_Down_Click);
            // 
            // Button_Move_Up
            // 
            this.Button_Move_Up.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Move_Up.Location = new System.Drawing.Point(70, 12);
            this.Button_Move_Up.Name = "Button_Move_Up";
            this.Button_Move_Up.Size = new System.Drawing.Size(58, 30);
            this.Button_Move_Up.TabIndex = 0;
            this.Button_Move_Up.Text = "Up";
            this.Button_Move_Up.UseVisualStyleBackColor = false;
            this.Button_Move_Up.Click += new System.EventHandler(this.Button_Move_Up_Click);
            // 
            // AttackBox
            // 
            this.AttackBox.Controls.Add(this.Button_Attack_Right);
            this.AttackBox.Controls.Add(this.Button_Attack_Up);
            this.AttackBox.Controls.Add(this.Button_Attack_Left);
            this.AttackBox.Controls.Add(this.Button_Attack_Down);
            this.AttackBox.Location = new System.Drawing.Point(600, 126);
            this.AttackBox.Name = "AttackBox";
            this.AttackBox.Size = new System.Drawing.Size(200, 120);
            this.AttackBox.TabIndex = 1;
            this.AttackBox.TabStop = false;
            this.AttackBox.Text = "Attack";
            // 
            // Button_Attack_Right
            // 
            this.Button_Attack_Right.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Attack_Right.Location = new System.Drawing.Point(127, 46);
            this.Button_Attack_Right.Name = "Button_Attack_Right";
            this.Button_Attack_Right.Size = new System.Drawing.Size(58, 30);
            this.Button_Attack_Right.TabIndex = 7;
            this.Button_Attack_Right.Text = "Right";
            this.Button_Attack_Right.UseVisualStyleBackColor = false;
            this.Button_Attack_Right.Click += new System.EventHandler(this.Button_Attack_Right_Click);

            // 
            // Button_Attack_Up
            // 
            this.Button_Attack_Up.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Attack_Up.Location = new System.Drawing.Point(70, 13);
            this.Button_Attack_Up.Name = "Button_Attack_Up";
            this.Button_Attack_Up.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Attack_Up.Size = new System.Drawing.Size(58, 30);
            this.Button_Attack_Up.TabIndex = 4;
            this.Button_Attack_Up.Text = "Up";
            this.Button_Attack_Up.UseVisualStyleBackColor = false;
            this.Button_Attack_Up.Click += new System.EventHandler(this.Button_Attack_Up_Click);

            // 
            // Button_Attack_Left
            // 
            this.Button_Attack_Left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Attack_Left.Location = new System.Drawing.Point(11, 46);
            this.Button_Attack_Left.Name = "Button_Attack_Left";
            this.Button_Attack_Left.Size = new System.Drawing.Size(58, 30);
            this.Button_Attack_Left.TabIndex = 6;
            this.Button_Attack_Left.Text = "Left";
            this.Button_Attack_Left.UseVisualStyleBackColor = false;
            this.Button_Attack_Left.Click += new System.EventHandler(this.Button_Attack_Left_Click);

            // 
            // Button_Attack_Down
            // 
            this.Button_Attack_Down.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Attack_Down.Location = new System.Drawing.Point(70, 84);
            this.Button_Attack_Down.Name = "Button_Attack_Down";
            this.Button_Attack_Down.Size = new System.Drawing.Size(58, 30);
            this.Button_Attack_Down.TabIndex = 5;
            this.Button_Attack_Down.Text = "Down";
            this.Button_Attack_Down.UseVisualStyleBackColor = false;
            this.Button_Attack_Down.Click += new System.EventHandler(this.Button_Attack_Down_Click);

            // 
            // Picture_Player
            // 
            this.Picture_Player.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Player.Image = global::TheQuest.Properties.Resources.player;
            this.Picture_Player.Location = new System.Drawing.Point(74, 57);
            this.Picture_Player.Name = "Picture_Player";
            this.Picture_Player.Size = new System.Drawing.Size(30, 30);
            this.Picture_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Player.TabIndex = 10;
            this.Picture_Player.TabStop = false;
            this.Picture_Player.Visible = false;
            // 
            // Picture_Sword
            // 
            this.Picture_Sword.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Sword.Image = global::TheQuest.Properties.Resources.sword;
            this.Picture_Sword.Location = new System.Drawing.Point(110, 57);
            this.Picture_Sword.Name = "Picture_Sword";
            this.Picture_Sword.Size = new System.Drawing.Size(30, 30);
            this.Picture_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Sword.TabIndex = 11;
            this.Picture_Sword.TabStop = false;
            this.Picture_Sword.Visible = false;
            // 
            // Picture_Bat
            // 
            this.Picture_Bat.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Bat.Image = global::TheQuest.Properties.Resources.bat;
            this.Picture_Bat.Location = new System.Drawing.Point(146, 57);
            this.Picture_Bat.Name = "Picture_Bat";
            this.Picture_Bat.Size = new System.Drawing.Size(30, 30);
            this.Picture_Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Bat.TabIndex = 12;
            this.Picture_Bat.TabStop = false;
            this.Picture_Bat.Visible = false;
            // 
            // Picture_Ghoul
            // 
            this.Picture_Ghoul.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Ghoul.Image = global::TheQuest.Properties.Resources.ghoul;
            this.Picture_Ghoul.Location = new System.Drawing.Point(182, 57);
            this.Picture_Ghoul.Name = "Picture_Ghoul";
            this.Picture_Ghoul.Size = new System.Drawing.Size(30, 30);
            this.Picture_Ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Ghoul.TabIndex = 13;
            this.Picture_Ghoul.TabStop = false;
            this.Picture_Ghoul.Visible = false;
            // 
            // Picture_Ghost
            // 
            this.Picture_Ghost.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Ghost.Image = global::TheQuest.Properties.Resources.ghost;
            this.Picture_Ghost.Location = new System.Drawing.Point(218, 57);
            this.Picture_Ghost.Name = "Picture_Ghost";
            this.Picture_Ghost.Size = new System.Drawing.Size(30, 30);
            this.Picture_Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Ghost.TabIndex = 14;
            this.Picture_Ghost.TabStop = false;
            this.Picture_Ghost.Visible = false;
            // 
            // Picture_Bow
            // 
            this.Picture_Bow.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Bow.Image = global::TheQuest.Properties.Resources.bow;
            this.Picture_Bow.Location = new System.Drawing.Point(254, 57);
            this.Picture_Bow.Name = "Picture_Bow";
            this.Picture_Bow.Size = new System.Drawing.Size(30, 30);
            this.Picture_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Bow.TabIndex = 15;
            this.Picture_Bow.TabStop = false;
            this.Picture_Bow.Visible = false;
            // 
            // Picture_Red_potion
            // 
            this.Picture_Red_potion.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Red_potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Red_potion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.Picture_Red_potion.Location = new System.Drawing.Point(290, 57);
            this.Picture_Red_potion.Name = "Picture_Red_potion";
            this.Picture_Red_potion.Size = new System.Drawing.Size(30, 30);
            this.Picture_Red_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Red_potion.TabIndex = 16;
            this.Picture_Red_potion.TabStop = false;
            this.Picture_Red_potion.Visible = false;
            // 
            // Picture_Blue_Potion
            // 
            this.Picture_Blue_Potion.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Blue_Potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Blue_Potion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.Picture_Blue_Potion.Location = new System.Drawing.Point(326, 57);
            this.Picture_Blue_Potion.Name = "Picture_Blue_Potion";
            this.Picture_Blue_Potion.Size = new System.Drawing.Size(30, 30);
            this.Picture_Blue_Potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Blue_Potion.TabIndex = 17;
            this.Picture_Blue_Potion.TabStop = false;
            this.Picture_Blue_Potion.Visible = false;
            // 
            // Picture_Mace
            // 
            this.Picture_Mace.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Mace.Image = global::TheQuest.Properties.Resources.mace;
            this.Picture_Mace.Location = new System.Drawing.Point(362, 57);
            this.Picture_Mace.Name = "Picture_Mace";
            this.Picture_Mace.Size = new System.Drawing.Size(30, 30);
            this.Picture_Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Mace.TabIndex = 18;
            this.Picture_Mace.TabStop = false;
            this.Picture_Mace.Visible = false;
            // 
            // Picture_Inventory_Sword
            // 
            this.Picture_Inventory_Sword.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Inventory_Sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Inventory_Sword.Image = global::TheQuest.Properties.Resources.sword;
            this.Picture_Inventory_Sword.Location = new System.Drawing.Point(90, 321);
            this.Picture_Inventory_Sword.Name = "Picture_Inventory_Sword";
            this.Picture_Inventory_Sword.Size = new System.Drawing.Size(50, 50);
            this.Picture_Inventory_Sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Inventory_Sword.TabIndex = 19;
            this.Picture_Inventory_Sword.TabStop = false;
            this.Picture_Inventory_Sword.Visible = false;
            this.Picture_Inventory_Sword.Click += new System.EventHandler(this.Picture_Inventory_Sword_Click);
            // 
            // Picture_Inventory_Mace
            // 
            this.Picture_Inventory_Mace.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Inventory_Mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Inventory_Mace.Image = global::TheQuest.Properties.Resources.mace;
            this.Picture_Inventory_Mace.Location = new System.Drawing.Point(330, 320);
            this.Picture_Inventory_Mace.Name = "Picture_Inventory_Mace";
            this.Picture_Inventory_Mace.Size = new System.Drawing.Size(50, 50);
            this.Picture_Inventory_Mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Inventory_Mace.TabIndex = 20;
            this.Picture_Inventory_Mace.TabStop = false;
            this.Picture_Inventory_Mace.Visible = false;
            this.Picture_Inventory_Mace.Click += new System.EventHandler(this.Picture_Inventory_Mace_Click);
            // 
            // Picture_Inventory_BluePotion
            // 
            this.Picture_Inventory_BluePotion.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Inventory_BluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Inventory_BluePotion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.Picture_Inventory_BluePotion.Location = new System.Drawing.Point(270, 320);
            this.Picture_Inventory_BluePotion.Name = "Picture_Inventory_BluePotion";
            this.Picture_Inventory_BluePotion.Size = new System.Drawing.Size(50, 50);
            this.Picture_Inventory_BluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Inventory_BluePotion.TabIndex = 21;
            this.Picture_Inventory_BluePotion.TabStop = false;
            this.Picture_Inventory_BluePotion.Visible = false;
            this.Picture_Inventory_BluePotion.Click += new System.EventHandler(this.Picture_Inventory_BluePotion_Click);
            // 
            // Picture_Inventory_Bow
            // 
            this.Picture_Inventory_Bow.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Inventory_Bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Inventory_Bow.Image = global::TheQuest.Properties.Resources.bow;
            this.Picture_Inventory_Bow.Location = new System.Drawing.Point(210, 321);
            this.Picture_Inventory_Bow.Name = "Picture_Inventory_Bow";
            this.Picture_Inventory_Bow.Size = new System.Drawing.Size(50, 50);
            this.Picture_Inventory_Bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Inventory_Bow.TabIndex = 22;
            this.Picture_Inventory_Bow.TabStop = false;
            this.Picture_Inventory_Bow.Visible = false;
            this.Picture_Inventory_Bow.Click += new System.EventHandler(this.Picture_Inventory_Bow_Click);
            // 
            // Picture_Inventory_RedPotion
            // 
            this.Picture_Inventory_RedPotion.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Inventory_RedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Inventory_RedPotion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.Picture_Inventory_RedPotion.Location = new System.Drawing.Point(150, 321);
            this.Picture_Inventory_RedPotion.Name = "Picture_Inventory_RedPotion";
            this.Picture_Inventory_RedPotion.Size = new System.Drawing.Size(50, 50);
            this.Picture_Inventory_RedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Inventory_RedPotion.TabIndex = 23;
            this.Picture_Inventory_RedPotion.TabStop = false;
            this.Picture_Inventory_RedPotion.Visible = false;
            this.Picture_Inventory_RedPotion.Click += new System.EventHandler(this.Picture_Inventory_RedPotion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(797, 401);
            this.Controls.Add(this.Picture_Inventory_RedPotion);
            this.Controls.Add(this.Picture_Inventory_Bow);
            this.Controls.Add(this.Picture_Inventory_BluePotion);
            this.Controls.Add(this.Picture_Inventory_Mace);
            this.Controls.Add(this.Picture_Inventory_Sword);
            this.Controls.Add(this.Picture_Player);
            this.Controls.Add(this.Picture_Mace);
            this.Controls.Add(this.Picture_Blue_Potion);
            this.Controls.Add(this.Picture_Red_potion);
            this.Controls.Add(this.Picture_Bow);
            this.Controls.Add(this.Picture_Ghost);
            this.Controls.Add(this.Picture_Ghoul);
            this.Controls.Add(this.Picture_Bat);
            this.Controls.Add(this.Picture_Sword);
            this.Controls.Add(this.AttackBox);
            this.Controls.Add(this.MoveBox);
            this.Controls.Add(this.Table_Hit_Point);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Table_Hit_Point.ResumeLayout(false);
            this.Table_Hit_Point.PerformLayout();
            this.MoveBox.ResumeLayout(false);
            this.AttackBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Red_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Blue_Potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_BluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_Bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Inventory_RedPotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel Table_Hit_Point;
        private System.Windows.Forms.GroupBox MoveBox;
        private System.Windows.Forms.Button Button_Move_Up;
        private System.Windows.Forms.GroupBox AttackBox;
        private System.Windows.Forms.Button Button_Move_Right;
        private System.Windows.Forms.Button Buttom_Move_Left;
        private System.Windows.Forms.Button Button_Move_Down;
        private System.Windows.Forms.Button Button_Attack_Right;
        private System.Windows.Forms.Button Button_Attack_Up;
        private System.Windows.Forms.Button Button_Attack_Left;
        private System.Windows.Forms.Button Button_Attack_Down;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.Label label_Ghoul_HitPoints;
        private System.Windows.Forms.Label label_Ghoul;
        private System.Windows.Forms.Label label_Ghost_HitPoints;
        private System.Windows.Forms.Label label_Ghost;
        private System.Windows.Forms.Label label_Bat_Hitpoints;
        private System.Windows.Forms.Label label_Bat;
        private System.Windows.Forms.Label label_Player_HitPoints;
        private System.Windows.Forms.PictureBox Picture_Player;
        private System.Windows.Forms.PictureBox Picture_Sword;
        private System.Windows.Forms.PictureBox Picture_Bat;
        private System.Windows.Forms.PictureBox Picture_Ghoul;
        private System.Windows.Forms.PictureBox Picture_Ghost;
        private System.Windows.Forms.PictureBox Picture_Bow;
        private System.Windows.Forms.PictureBox Picture_Red_potion;
        private System.Windows.Forms.PictureBox Picture_Blue_Potion;
        private System.Windows.Forms.PictureBox Picture_Mace;
        private System.Windows.Forms.PictureBox Picture_Inventory_Sword;
        private System.Windows.Forms.PictureBox Picture_Inventory_Mace;
        private System.Windows.Forms.PictureBox Picture_Inventory_BluePotion;
        private System.Windows.Forms.PictureBox Picture_Inventory_Bow;
        private System.Windows.Forms.PictureBox Picture_Inventory_RedPotion;
    }
}

