namespace PacMan
{
    partial class Game
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
            this.pictureBox_greenF = new System.Windows.Forms.PictureBox();
            this.pictureBox_Cherry = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pacman = new System.Windows.Forms.PictureBox();
            this.pictureBox_RedG = new System.Windows.Forms.PictureBox();
            this.pictureBox_pinkG = new System.Windows.Forms.PictureBox();
            this.picture_BottomWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_TopWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftWall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greenF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RedG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pinkG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftWall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_greenF
            // 
            this.pictureBox_greenF.Image = global::PacMan.Properties.Resources.tile114;
            this.pictureBox_greenF.Location = new System.Drawing.Point(386, 341);
            this.pictureBox_greenF.Name = "pictureBox_greenF";
            this.pictureBox_greenF.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_greenF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_greenF.TabIndex = 8;
            this.pictureBox_greenF.TabStop = false;
            this.pictureBox_greenF.Tag = "grape";
            // 
            // pictureBox_Cherry
            // 
            this.pictureBox_Cherry.Image = global::PacMan.Properties.Resources.cherry;
            this.pictureBox_Cherry.Location = new System.Drawing.Point(131, 141);
            this.pictureBox_Cherry.Name = "pictureBox_Cherry";
            this.pictureBox_Cherry.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cherry.TabIndex = 7;
            this.pictureBox_Cherry.TabStop = false;
            this.pictureBox_Cherry.Tag = "cherry";
            // 
            // pictureBox_Pacman
            // 
            this.pictureBox_Pacman.Image = global::PacMan.Properties.Resources.pacman_right;
            this.pictureBox_Pacman.Location = new System.Drawing.Point(447, 112);
            this.pictureBox_Pacman.Name = "pictureBox_Pacman";
            this.pictureBox_Pacman.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pacman.TabIndex = 6;
            this.pictureBox_Pacman.TabStop = false;
            this.pictureBox_Pacman.Tag = "pacman";
            // 
            // pictureBox_RedG
            // 
            this.pictureBox_RedG.Image = global::PacMan.Properties.Resources.red_left1;
            this.pictureBox_RedG.Location = new System.Drawing.Point(210, 305);
            this.pictureBox_RedG.Name = "pictureBox_RedG";
            this.pictureBox_RedG.Size = new System.Drawing.Size(36, 38);
            this.pictureBox_RedG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RedG.TabIndex = 5;
            this.pictureBox_RedG.TabStop = false;
            this.pictureBox_RedG.Tag = "ghost";
            // 
            // pictureBox_pinkG
            // 
            this.pictureBox_pinkG.Image = global::PacMan.Properties.Resources.pink_left1;
            this.pictureBox_pinkG.Location = new System.Drawing.Point(287, 186);
            this.pictureBox_pinkG.Name = "pictureBox_pinkG";
            this.pictureBox_pinkG.Size = new System.Drawing.Size(36, 38);
            this.pictureBox_pinkG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pinkG.TabIndex = 4;
            this.pictureBox_pinkG.TabStop = false;
            this.pictureBox_pinkG.Tag = "ghost";
            // 
            // picture_BottomWall
            // 
            this.picture_BottomWall.BackColor = System.Drawing.SystemColors.Desktop;
            this.picture_BottomWall.Location = new System.Drawing.Point(231, 397);
            this.picture_BottomWall.Name = "picture_BottomWall";
            this.picture_BottomWall.Size = new System.Drawing.Size(230, 15);
            this.picture_BottomWall.TabIndex = 3;
            this.picture_BottomWall.TabStop = false;
            this.picture_BottomWall.Tag = "wall";
            // 
            // pictureBox_TopWall
            // 
            this.pictureBox_TopWall.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox_TopWall.Location = new System.Drawing.Point(144, 112);
            this.pictureBox_TopWall.Name = "pictureBox_TopWall";
            this.pictureBox_TopWall.Size = new System.Drawing.Size(129, 11);
            this.pictureBox_TopWall.TabIndex = 2;
            this.pictureBox_TopWall.TabStop = false;
            this.pictureBox_TopWall.Tag = "wall";
            // 
            // pictureBox_RightWall
            // 
            this.pictureBox_RightWall.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox_RightWall.Location = new System.Drawing.Point(493, 141);
            this.pictureBox_RightWall.Name = "pictureBox_RightWall";
            this.pictureBox_RightWall.Size = new System.Drawing.Size(17, 146);
            this.pictureBox_RightWall.TabIndex = 1;
            this.pictureBox_RightWall.TabStop = false;
            this.pictureBox_RightWall.Tag = "wall";
            // 
            // pictureBox_LeftWall
            // 
            this.pictureBox_LeftWall.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox_LeftWall.Location = new System.Drawing.Point(88, 231);
            this.pictureBox_LeftWall.Name = "pictureBox_LeftWall";
            this.pictureBox_LeftWall.Size = new System.Drawing.Size(18, 181);
            this.pictureBox_LeftWall.TabIndex = 0;
            this.pictureBox_LeftWall.TabStop = false;
            this.pictureBox_LeftWall.Tag = "wall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 76);
            this.label2.TabIndex = 10;
            this.label2.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(422, 9);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(77, 29);
            this.label_UserName.TabIndex = 11;
            this.label_UserName.Text = "name";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 523);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_greenF);
            this.Controls.Add(this.pictureBox_Cherry);
            this.Controls.Add(this.pictureBox_Pacman);
            this.Controls.Add(this.pictureBox_RedG);
            this.Controls.Add(this.pictureBox_pinkG);
            this.Controls.Add(this.picture_BottomWall);
            this.Controls.Add(this.pictureBox_TopWall);
            this.Controls.Add(this.pictureBox_RightWall);
            this.Controls.Add(this.pictureBox_LeftWall);
            this.Name = "Game";
            this.Tag = "wall";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_greenF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RedG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pinkG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_LeftWall;
        private System.Windows.Forms.PictureBox pictureBox_RightWall;
        private System.Windows.Forms.PictureBox pictureBox_TopWall;
        private System.Windows.Forms.PictureBox picture_BottomWall;
        private System.Windows.Forms.PictureBox pictureBox_pinkG;
        private System.Windows.Forms.PictureBox pictureBox_RedG;
        private System.Windows.Forms.PictureBox pictureBox_Pacman;
        private System.Windows.Forms.PictureBox pictureBox_Cherry;
        private System.Windows.Forms.PictureBox pictureBox_greenF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_UserName;
    }
}