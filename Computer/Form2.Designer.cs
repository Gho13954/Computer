namespace Computer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Gameplane = new System.Windows.Forms.Panel();
            this.plane = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startgame = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.gamedifficulty = new System.Windows.Forms.Label();
            this.gameread = new System.Windows.Forms.Button();
            this.ft = new System.Windows.Forms.RichTextBox();
            this.fraction = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Theworld = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gameplane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            this.SuspendLayout();
            // 
            // Gameplane
            // 
            this.Gameplane.Controls.Add(this.plane);
            this.Gameplane.Location = new System.Drawing.Point(9, 10);
            this.Gameplane.Margin = new System.Windows.Forms.Padding(2);
            this.Gameplane.Name = "Gameplane";
            this.Gameplane.Size = new System.Drawing.Size(485, 416);
            this.Gameplane.TabIndex = 0;
            // 
            // plane
            // 
            this.plane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plane.Image = global::Computer.Properties.Resources.空军基地1;
            this.plane.Location = new System.Drawing.Point(184, 325);
            this.plane.Margin = new System.Windows.Forms.Padding(2);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(73, 78);
            this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plane.TabIndex = 0;
            this.plane.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // startgame
            // 
            this.startgame.Location = new System.Drawing.Point(506, 10);
            this.startgame.Margin = new System.Windows.Forms.Padding(2);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(104, 36);
            this.startgame.TabIndex = 1;
            this.startgame.Text = "开始游戏";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // difficulty
            // 
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "easy",
            "normal",
            "hard"});
            this.difficulty.Location = new System.Drawing.Point(506, 118);
            this.difficulty.Margin = new System.Windows.Forms.Padding(2);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(104, 20);
            this.difficulty.TabIndex = 3;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // gamedifficulty
            // 
            this.gamedifficulty.AutoSize = true;
            this.gamedifficulty.Location = new System.Drawing.Point(503, 103);
            this.gamedifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamedifficulty.Name = "gamedifficulty";
            this.gamedifficulty.Size = new System.Drawing.Size(53, 12);
            this.gamedifficulty.TabIndex = 4;
            this.gamedifficulty.Text = "游戏难度";
            // 
            // gameread
            // 
            this.gameread.Location = new System.Drawing.Point(501, 214);
            this.gameread.Margin = new System.Windows.Forms.Padding(2);
            this.gameread.Name = "gameread";
            this.gameread.Size = new System.Drawing.Size(94, 29);
            this.gameread.TabIndex = 5;
            this.gameread.Text = "拼一枪";
            this.gameread.UseVisualStyleBackColor = true;
            this.gameread.Click += new System.EventHandler(this.gameread_Click);
            // 
            // ft
            // 
            this.ft.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ft.Location = new System.Drawing.Point(499, 334);
            this.ft.Margin = new System.Windows.Forms.Padding(2);
            this.ft.Name = "ft";
            this.ft.ReadOnly = true;
            this.ft.Size = new System.Drawing.Size(111, 65);
            this.ft.TabIndex = 7;
            this.ft.Text = "";
            // 
            // fraction
            // 
            this.fraction.AutoSize = true;
            this.fraction.Location = new System.Drawing.Point(503, 320);
            this.fraction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(29, 12);
            this.fraction.TabIndex = 9;
            this.fraction.Text = "分数";
            // 
            // life
            // 
            this.life.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.life.Location = new System.Drawing.Point(538, 141);
            this.life.Margin = new System.Windows.Forms.Padding(2);
            this.life.Name = "life";
            this.life.ReadOnly = true;
            this.life.Size = new System.Drawing.Size(72, 44);
            this.life.TabIndex = 10;
            this.life.Text = "***";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Theworld
            // 
            this.Theworld.Location = new System.Drawing.Point(506, 50);
            this.Theworld.Margin = new System.Windows.Forms.Padding(2);
            this.Theworld.Name = "Theworld";
            this.Theworld.Size = new System.Drawing.Size(104, 36);
            this.Theworld.TabIndex = 12;
            this.Theworld.Text = "暂停游戏";
            this.Theworld.UseVisualStyleBackColor = true;
            this.Theworld.Click += new System.EventHandler(this.Theworld_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(495, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "生命";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "通过剪刀石头布";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Theworld);
            this.Controls.Add(this.life);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.gameread);
            this.Controls.Add(this.gamedifficulty);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.Gameplane);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.Gameplane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Gameplane;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label gamedifficulty;
        private System.Windows.Forms.Button gameread;
        private System.Windows.Forms.RichTextBox ft;
        private System.Windows.Forms.Label fraction;
        private System.Windows.Forms.RichTextBox life;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Theworld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}