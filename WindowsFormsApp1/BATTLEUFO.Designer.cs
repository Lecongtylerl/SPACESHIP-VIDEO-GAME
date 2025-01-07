namespace WindowsFormsApp1
{
    partial class BATTLEUFO
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numscore = new System.Windows.Forms.Label();
            this.TITLE = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.PictureBox();
            this.TextRules = new System.Windows.Forms.PictureBox();
            this.Rules = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Unmute = new System.Windows.Forms.PictureBox();
            this.Mutte = new System.Windows.Forms.PictureBox();
            this.Medium = new System.Windows.Forms.PictureBox();
            this.Hard = new System.Windows.Forms.PictureBox();
            this.Easy = new System.Windows.Forms.PictureBox();
            this.Backbutton = new System.Windows.Forms.PictureBox();
            this.ButtonOption = new System.Windows.Forms.PictureBox();
            this.ButtonJouer = new System.Windows.Forms.PictureBox();
            this.MenuBack = new System.Windows.Forms.PictureBox();
            this.UFOPic3 = new System.Windows.Forms.PictureBox();
            this.UFOPic2 = new System.Windows.Forms.PictureBox();
            this.UFOPic1 = new System.Windows.Forms.PictureBox();
            this.CannonPic = new System.Windows.Forms.PictureBox();
            this.LazerPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.ClockCount = new System.Windows.Forms.Label();
            this.Timerword = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonJouer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "SCORE: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 4;
            // 
            // Numscore
            // 
            this.Numscore.AutoSize = true;
            this.Numscore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Numscore.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Numscore.Location = new System.Drawing.Point(100, 9);
            this.Numscore.Name = "Numscore";
            this.Numscore.Size = new System.Drawing.Size(25, 28);
            this.Numscore.TabIndex = 7;
            this.Numscore.Text = "0";
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.Color.Black;
            this.TITLE.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TITLE.Location = new System.Drawing.Point(189, 65);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(417, 39);
            this.TITLE.TabIndex = 23;
            this.TITLE.Text = "Bienvenue dans Battle UFO";
            // 
            // Start
            // 
            this.Start.Image = global::WindowsFormsApp1.Properties.Resources.Start;
            this.Start.Location = new System.Drawing.Point(502, 342);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(289, 96);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Start.TabIndex = 27;
            this.Start.TabStop = false;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TextRules
            // 
            this.TextRules.Image = global::WindowsFormsApp1.Properties.Resources.Rulesssss;
            this.TextRules.Location = new System.Drawing.Point(67, 212);
            this.TextRules.Name = "TextRules";
            this.TextRules.Size = new System.Drawing.Size(674, 37);
            this.TextRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TextRules.TabIndex = 26;
            this.TextRules.TabStop = false;
            this.TextRules.Visible = false;
            // 
            // Rules
            // 
            this.Rules.Image = global::WindowsFormsApp1.Properties.Resources.Rules;
            this.Rules.Location = new System.Drawing.Point(248, 12);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(308, 114);
            this.Rules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Rules.TabIndex = 25;
            this.Rules.TabStop = false;
            this.Rules.Visible = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(294, 342);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(202, 66);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exit.TabIndex = 24;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox2_Click_4);
            // 
            // Unmute
            // 
            this.Unmute.Image = global::WindowsFormsApp1.Properties.Resources.Unmute;
            this.Unmute.Location = new System.Drawing.Point(239, 375);
            this.Unmute.Name = "Unmute";
            this.Unmute.Size = new System.Drawing.Size(308, 50);
            this.Unmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Unmute.TabIndex = 22;
            this.Unmute.TabStop = false;
            this.Unmute.Visible = false;
            this.Unmute.Click += new System.EventHandler(this.Unmute_Click);
            // 
            // Mutte
            // 
            this.Mutte.Image = global::WindowsFormsApp1.Properties.Resources.Mute;
            this.Mutte.Location = new System.Drawing.Point(239, 300);
            this.Mutte.Name = "Mutte";
            this.Mutte.Size = new System.Drawing.Size(308, 50);
            this.Mutte.TabIndex = 21;
            this.Mutte.TabStop = false;
            this.Mutte.Visible = false;
            this.Mutte.Click += new System.EventHandler(this.pictureBox2_Click_3);
            // 
            // Medium
            // 
            this.Medium.Image = global::WindowsFormsApp1.Properties.Resources.NewMedium;
            this.Medium.Location = new System.Drawing.Point(239, 57);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(308, 84);
            this.Medium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Medium.TabIndex = 20;
            this.Medium.TabStop = false;
            this.Medium.Visible = false;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.Image = global::WindowsFormsApp1.Properties.Resources.Newhard;
            this.Hard.Location = new System.Drawing.Point(239, 57);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(308, 82);
            this.Hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hard.TabIndex = 19;
            this.Hard.TabStop = false;
            this.Hard.Visible = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Easy
            // 
            this.Easy.Image = global::WindowsFormsApp1.Properties.Resources.NewEasy;
            this.Easy.Location = new System.Drawing.Point(239, 57);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(306, 84);
            this.Easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Easy.TabIndex = 18;
            this.Easy.TabStop = false;
            this.Easy.Visible = false;
            this.Easy.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // Backbutton
            // 
            this.Backbutton.Image = global::WindowsFormsApp1.Properties.Resources.Newbackbutton;
            this.Backbutton.Location = new System.Drawing.Point(12, 12);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(148, 50);
            this.Backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Backbutton.TabIndex = 15;
            this.Backbutton.TabStop = false;
            this.Backbutton.Visible = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // ButtonOption
            // 
            this.ButtonOption.Image = global::WindowsFormsApp1.Properties.Resources.Option;
            this.ButtonOption.Location = new System.Drawing.Point(248, 235);
            this.ButtonOption.Name = "ButtonOption";
            this.ButtonOption.Size = new System.Drawing.Size(308, 59);
            this.ButtonOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonOption.TabIndex = 13;
            this.ButtonOption.TabStop = false;
            this.ButtonOption.Click += new System.EventHandler(this.ButtonOption_Click);
            // 
            // ButtonJouer
            // 
            this.ButtonJouer.Image = global::WindowsFormsApp1.Properties.Resources.Jouer;
            this.ButtonJouer.Location = new System.Drawing.Point(248, 155);
            this.ButtonJouer.Name = "ButtonJouer";
            this.ButtonJouer.Size = new System.Drawing.Size(308, 60);
            this.ButtonJouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonJouer.TabIndex = 12;
            this.ButtonJouer.TabStop = false;
            this.ButtonJouer.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // MenuBack
            // 
            this.MenuBack.Image = global::WindowsFormsApp1.Properties.Resources.inkpendude_portal_storm;
            this.MenuBack.Location = new System.Drawing.Point(1, -2);
            this.MenuBack.Name = "MenuBack";
            this.MenuBack.Size = new System.Drawing.Size(800, 454);
            this.MenuBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBack.TabIndex = 9;
            this.MenuBack.TabStop = false;
            // 
            // UFOPic3
            // 
            this.UFOPic3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UFOPic3.Image = global::WindowsFormsApp1.Properties.Resources.Gray_Alien_with_Uniform_Spaceship_UFO_PixelBoom_268x268_removebg_preview;
            this.UFOPic3.Location = new System.Drawing.Point(366, 102);
            this.UFOPic3.Name = "UFOPic3";
            this.UFOPic3.Size = new System.Drawing.Size(72, 60);
            this.UFOPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFOPic3.TabIndex = 6;
            this.UFOPic3.TabStop = false;
            // 
            // UFOPic2
            // 
            this.UFOPic2.BackColor = System.Drawing.Color.Black;
            this.UFOPic2.Image = global::WindowsFormsApp1.Properties.Resources.Gray_Alien_with_Uniform_Spaceship_UFO_PixelBoom_268x268_removebg_preview;
            this.UFOPic2.Location = new System.Drawing.Point(724, 155);
            this.UFOPic2.Name = "UFOPic2";
            this.UFOPic2.Size = new System.Drawing.Size(101, 72);
            this.UFOPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFOPic2.TabIndex = 5;
            this.UFOPic2.TabStop = false;
            // 
            // UFOPic1
            // 
            this.UFOPic1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UFOPic1.Image = global::WindowsFormsApp1.Properties.Resources.Gray_Alien_with_Uniform_Spaceship_UFO_PixelBoom_268x268_removebg_preview;
            this.UFOPic1.Location = new System.Drawing.Point(1, 40);
            this.UFOPic1.Name = "UFOPic1";
            this.UFOPic1.Size = new System.Drawing.Size(87, 64);
            this.UFOPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFOPic1.TabIndex = 2;
            this.UFOPic1.TabStop = false;
            // 
            // CannonPic
            // 
            this.CannonPic.BackColor = System.Drawing.Color.Black;
            this.CannonPic.Image = global::WindowsFormsApp1.Properties.Resources.Cannon;
            this.CannonPic.Location = new System.Drawing.Point(366, 342);
            this.CannonPic.Name = "CannonPic";
            this.CannonPic.Size = new System.Drawing.Size(114, 158);
            this.CannonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CannonPic.TabIndex = 0;
            this.CannonPic.TabStop = false;
            // 
            // LazerPic
            // 
            this.LazerPic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LazerPic.Image = global::WindowsFormsApp1.Properties.Resources.LaserbeamShortt;
            this.LazerPic.Location = new System.Drawing.Point(612, 255);
            this.LazerPic.Name = "LazerPic";
            this.LazerPic.Size = new System.Drawing.Size(34, 54);
            this.LazerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LazerPic.TabIndex = 1;
            this.LazerPic.TabStop = false;
            this.LazerPic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.WBVk;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ClockCount
            // 
            this.ClockCount.AutoSize = true;
            this.ClockCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClockCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClockCount.Location = new System.Drawing.Point(750, 12);
            this.ClockCount.Name = "ClockCount";
            this.ClockCount.Size = new System.Drawing.Size(38, 28);
            this.ClockCount.TabIndex = 28;
            this.ClockCount.Text = "60";
            this.ClockCount.Visible = false;
            // 
            // Timerword
            // 
            this.Timerword.AutoSize = true;
            this.Timerword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Timerword.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Timerword.Location = new System.Drawing.Point(669, 12);
            this.Timerword.Name = "Timerword";
            this.Timerword.Size = new System.Drawing.Size(85, 28);
            this.Timerword.TabIndex = 29;
            this.Timerword.Text = "Timer :";
            this.Timerword.Visible = false;
            // 
            // TimeLimit
            // 
            this.TimeLimit.Interval = 60000;
            this.TimeLimit.Tick += new System.EventHandler(this.TimeLimit_Tick);
            // 
            // BATTLEUFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Timerword);
            this.Controls.Add(this.ButtonOption);
            this.Controls.Add(this.ButtonJouer);
            this.Controls.Add(this.ClockCount);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TextRules);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.Unmute);
            this.Controls.Add(this.Mutte);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.MenuBack);
            this.Controls.Add(this.Numscore);
            this.Controls.Add(this.UFOPic3);
            this.Controls.Add(this.UFOPic2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UFOPic1);
            this.Controls.Add(this.CannonPic);
            this.Controls.Add(this.LazerPic);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BATTLEUFO";
            this.Text = "BATTLE UFO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonJouer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CannonPic;
        private System.Windows.Forms.PictureBox LazerPic;
        private System.Windows.Forms.PictureBox UFOPic1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox UFOPic2;
        private System.Windows.Forms.PictureBox UFOPic3;
        private System.Windows.Forms.Label Numscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MenuBack;
        private System.Windows.Forms.PictureBox ButtonJouer;
        private System.Windows.Forms.PictureBox ButtonOption;
        private System.Windows.Forms.PictureBox Backbutton;
        private System.Windows.Forms.PictureBox Easy;
        private System.Windows.Forms.PictureBox Hard;
        private System.Windows.Forms.PictureBox Medium;
        private System.Windows.Forms.PictureBox Mutte;
        private System.Windows.Forms.PictureBox Unmute;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Rules;
        private System.Windows.Forms.PictureBox TextRules;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label ClockCount;
        private System.Windows.Forms.Label Timerword;
        private System.Windows.Forms.Timer TimeLimit;
    }
}

