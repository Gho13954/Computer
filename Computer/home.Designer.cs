namespace Computer
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Button();
            this.f1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "吴嘉豪";
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.Color.DimGray;
            this.f2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f2.BackgroundImage")));
            this.f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f2.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.f2.ForeColor = System.Drawing.Color.White;
            this.f2.Location = new System.Drawing.Point(9, 34);
            this.f2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(88, 87);
            this.f2.TabIndex = 1;
            this.f2.Text = "太空大战(打字游戏+石头剪刀布)";
            this.f2.UseVisualStyleBackColor = false;
            this.f2.Click += new System.EventHandler(this.f3_Click);
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.Color.White;
            this.f1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f1.BackgroundImage")));
            this.f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.f1.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.f1.ForeColor = System.Drawing.Color.Black;
            this.f1.Location = new System.Drawing.Point(102, 34);
            this.f1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(88, 87);
            this.f1.TabIndex = 0;
            this.f1.Text = "计算机";
            this.f1.UseVisualStyleBackColor = false;
            this.f1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f1;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Label label1;
    }
}