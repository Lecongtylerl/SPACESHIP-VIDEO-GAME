namespace WindowsFormsApp1
{
    partial class Form1
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
            this.UFOPic = new System.Windows.Forms.PictureBox();
            this.CannonPic = new System.Windows.Forms.PictureBox();
            this.LazerPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UFOPic
            // 
            this.UFOPic.Image = global::WindowsFormsApp1.Properties.Resources.Gray_Alien_with_Uniform_Spaceship_UFO_PixelBoom_268x268_removebg_preview;
            this.UFOPic.Location = new System.Drawing.Point(-43, 47);
            this.UFOPic.Name = "UFOPic";
            this.UFOPic.Size = new System.Drawing.Size(204, 76);
            this.UFOPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UFOPic.TabIndex = 2;
            this.UFOPic.TabStop = false;
            // 
            // CannonPic
            // 
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
            this.LazerPic.Image = global::WindowsFormsApp1.Properties.Resources.Laser_beam1;
            this.LazerPic.Location = new System.Drawing.Point(427, 295);
            this.LazerPic.Name = "LazerPic";
            this.LazerPic.Size = new System.Drawing.Size(34, 134);
            this.LazerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LazerPic.TabIndex = 1;
            this.LazerPic.TabStop = false;
            this.LazerPic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -2);
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
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "O";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UFOPic);
            this.Controls.Add(this.CannonPic);
            this.Controls.Add(this.LazerPic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.UFOPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CannonPic;
        private System.Windows.Forms.PictureBox LazerPic;
        private System.Windows.Forms.PictureBox UFOPic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

