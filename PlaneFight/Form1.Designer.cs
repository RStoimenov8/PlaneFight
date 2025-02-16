namespace PlaneFight
{
    partial class Form1
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.Ememy1 = new System.Windows.Forms.PictureBox();
            this.Ememy2 = new System.Windows.Forms.PictureBox();
            this.Ememy3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy3)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::PlaneFight.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(260, 530);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(112, 101);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.Image = global::PlaneFight.Properties.Resources.bullet;
            this.Bullet.Location = new System.Drawing.Point(311, 378);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(10, 30);
            this.Bullet.TabIndex = 1;
            this.Bullet.TabStop = false;
            // 
            // Ememy1
            // 
            this.Ememy1.Image = global::PlaneFight.Properties.Resources.enemy;
            this.Ememy1.Location = new System.Drawing.Point(61, 48);
            this.Ememy1.Name = "Ememy1";
            this.Ememy1.Size = new System.Drawing.Size(103, 88);
            this.Ememy1.TabIndex = 2;
            this.Ememy1.TabStop = false;
            // 
            // Ememy2
            // 
            this.Ememy2.Image = global::PlaneFight.Properties.Resources.enemy;
            this.Ememy2.Location = new System.Drawing.Point(276, 48);
            this.Ememy2.Name = "Ememy2";
            this.Ememy2.Size = new System.Drawing.Size(103, 88);
            this.Ememy2.TabIndex = 3;
            this.Ememy2.TabStop = false;
            // 
            // Ememy3
            // 
            this.Ememy3.Image = global::PlaneFight.Properties.Resources.enemy;
            this.Ememy3.Location = new System.Drawing.Point(459, 48);
            this.Ememy3.Name = "Ememy3";
            this.Ememy3.Size = new System.Drawing.Size(103, 88);
            this.Ememy3.TabIndex = 4;
            this.Ememy3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 108);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(103, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Pused! Press Space to Resume/Start!";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ememy1);
            this.Controls.Add(this.Ememy2);
            this.Controls.Add(this.Ememy3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ememy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.PictureBox Ememy1;
        private System.Windows.Forms.PictureBox Ememy2;
        private System.Windows.Forms.PictureBox Ememy3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

