using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;// so we can use sound effects

namespace WindowsFormsApp1
{
    public partial class BATTLEUFO : Form
    {
        float xUFO1;//UFO 1
        float xUFO2;//UFO 2
        float xUFO3;//UFO 3
        float vUFO1 = 6;// vitesse de UFO
        float vUFO2 = 10; // vitesse de UFO2 
        float vUFO3 = 9;// vitesse de UFO3 
        bool left;
        bool right;
        float xCannon;//placement vertical de Cannon
        float vCannon = 15;//Vitess de Cannon
        float xLazer;//placement vertical de Lazer
        float yLazer;
        float vxLazer = 0, vyLazer = 20;//vitess de lazer
        bool lazer; 
        int score = 0;//score
        private SoundPlayer SoundHit = new SoundPlayer(Properties.Resources.LaserHit);  //Son pour Lazer qui frappe
        private SoundPlayer SoundShoot = new SoundPlayer(Properties.Resources.LaserShoot);//Son pour Lazer qui tir
        private SoundPlayer ArcadeSong = new SoundPlayer(Properties.Resources.Arcade_Game_Menu_Music_Loop_Sound_Effect__8_Bit_Style_);// son pour la music
        bool mute = false;// boutton de mute
        int TimerCountdown = 60;// temp limit
        public BATTLEUFO()
        {
            InitializeComponent();          
        }       
        private void Form1_Load(object sender, EventArgs e)
        {
            /// Set variable 
            xUFO1 = UFOPic1.Left;
            xUFO2 = UFOPic2.Left;
            xUFO3 = UFOPic3.Left;
            xCannon = CannonPic.Left;
            xLazer = LazerPic.Left;
            yLazer = LazerPic.Top;
          
            if (!mute)// Si se n'est pas mute
            {
                ArcadeSong.Play();// jouer arcade music
            }
            Clock.Stop();// arreter timer 
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        { 
            /// Vitesse de UFO
            xUFO1 += vUFO1;
            xUFO2 += vUFO2;
            xUFO3 += vUFO3;
            
            if (xUFO1 > ClientSize.Width)// si UFO frappe le côté du mur, il reviendra
            {
                xUFO1 = -UFOPic1.Width;
            }
            UFOPic1.Left = (int)xUFO1;//Convertir variable a int

            //////////////////////////////////////////////////

            if (xUFO2 > ClientSize.Width)// si UFO frappe le côté du mur, il reviendra
            {
                xUFO2 = -UFOPic2.Width;
            }
            UFOPic2.Left = (int)xUFO2;//Convertir variable a int

            /////////////////////////////////////////////////

            if (xUFO3 > ClientSize.Width)// si UFO frappe le côté du mur, il reviendra
            {
                xUFO3 = -UFOPic3.Width;
            }
            UFOPic3.Left = (int)xUFO3;//Convertir variable a int

            ///////////////////////////////////////////////////
            if (left && CannonPic.Left > 0) // Si Cannon frappe le côté du mur, il va arreter au mure
            {
                xCannon -= vCannon;
                CannonPic.Left = (int)xCannon;//Convertir variable a int
            }
            if (right && CannonPic.Left < 690) //si UFO frappe le côté du mur, il reviendra
            {
                xCannon += vCannon;
                CannonPic.Left = (int)xCannon;//Convertir variable a int
            }
            //left = false;
            //right = false;
            
            /////////////////////////////// When lazer hit UFO 
            if(lazer)
            {
                yLazer -= vyLazer;
                LazerPic.Top = (int)yLazer;//Convertir variable a int

                if (LazerPic.Bounds.IntersectsWith(UFOPic1.Bounds)) // Quand lazer frappe ufo 1
                {
                    UFOPic1.Visible = false;
                    LazerPic.Visible = false;
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;//Convertir variable a int
                    UFOPic1.Top = -5000;
                    score += 1;//+1 a score
                    Numscore.Text = score.ToString();//Convertir variable a String

                    if (!mute)// Si se n'est pas mute
                    {
                        SoundHit.Play();// son quand frappe UFO
                    }


                }

                if (LazerPic.Bounds.IntersectsWith(UFOPic2.Bounds)) // quand le laser a frappé ufo 2
                {
                    UFOPic2.Visible = false;// UFOPic pas visible
                    LazerPic.Visible = false;// LazerPic pas visible
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;//Convertir variable a int
                    UFOPic2.Top = -5000;
                    score += 1;//+1 a score
                    Numscore.Text = score.ToString();
                    if (!mute)// Si se n'est pas mute
                    {
                        SoundHit.Play();// son quand frappe UFO
                    }
                }
                if (LazerPic.Bounds.IntersectsWith(UFOPic3.Bounds)) // quand le laser a frappé ufo 2
                {
                    UFOPic3.Visible = false;
                    LazerPic.Visible = false;
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;//Convertir variable a int
                    UFOPic3.Top = -5000;
                    score += 1;//adds +1 tto socre
                    Numscore.Text = score.ToString();
                    if (!mute)// if mute is off, the sound plays
                    {
                        SoundHit.Play();
                    }

                }
                if (yLazer < -60)
                {
                    LazerPic.Visible = false;
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;//Convertir variable a int
                }
                
                if (UFOPic1.Visible == false && UFOPic2.Visible == false && UFOPic3.Visible == false)// when All ufo gets killed
                {
                    UFOPic1.Visible = true;
                    UFOPic3.Visible = true;
                    UFOPic2.Visible = true;
                    UFOPic1.Top = 25;
                    UFOPic2.Top = 150;
                    UFOPic3.Top = 80;
                }
            }         
        }

        private void keyDown(object sender, KeyEventArgs e)
            ///To make Space bar shoot the lazer 
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if(!lazer)
            {
                if(e.KeyCode == Keys.Space)
                {       
                    LazerPic.Visible = true;
                    lazer = true;
                    xLazer = xCannon + 60;// the lazer will come out tthe end of the cannon
                    LazerPic.Left = (int)xLazer;
                    if (!mute)
                    {
                        SoundShoot.Play();
                    }
                }
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }
      
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //When they click JOUER
            Rules.Visible = true;
            TextRules.Visible = true;
            MenuBack.Visible = true;
            TITLE.Visible = false;
            Exit.Visible = false;
            Start.Visible = true;
            ButtonJouer.Visible = false;
            ButtonJouer.Visible = false;
            ButtonOption.Visible = false;
            ButtonOption.Visible = false;
            Backbutton.Visible = true;
        }
        private void ButtonOption_Click(object sender, EventArgs e)
        {
            //When they click option
            Backbutton.Visible = true;
            Easy.Visible = true;
            Mutte.Visible = true;
            TITLE.Visible = false;
            Easy.Top = 125;
            Mutte.Top = 275;
            // ButtonOption.Top = -5000;
            // ButtonJouer.Top = -5000;
            ButtonJouer.Visible = false;
            ButtonOption.Visible = false;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            // When they click back button
            ButtonJouer.Top = 155;
            ButtonOption.Top = 235;
            TITLE.Visible = true;
            Backbutton.Visible = false;
            Easy.Visible = false;
            Medium.Visible = false;
            Hard.Visible = false;
            Mutte.Visible = false;
            Unmute.Visible = false;
            Rules.Visible = false;
            TextRules.Visible = false;
            Start.Visible = false;
            ButtonJouer.Visible = true;
            ButtonOption.Visible = true;
            Exit.Visible = true;
        }
       
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            // when they click on Easy
            Medium.Visible = true;
            Medium.Top = 125;
            Easy.Visible = false;
            Hard.Visible = false;
            vUFO1 = 14;
            vUFO2 = 18;
            vUFO3 = 19;
        }
        private void Hard_Click(object sender, EventArgs e)
        {
            // when they click button hard
            Easy.Visible = true;
            Easy.Top = 125;
            Medium.Visible = false;
            Hard.Visible = false;
            vUFO1 = 6;
            vUFO2 = 10;
            vUFO3 = 9;
        }
        private void Medium_Click(object sender, EventArgs e)
        {
            //When they click buttton Medium
            Hard.Visible = true;
            Hard.Top = 125;
            Easy.Visible = false;
            Medium.Visible = false;
            vUFO1 = 20;
            vUFO2 = 25;
            vUFO3 = 22;
        }
        private void mutte_Click(object sender, EventArgs e)
        {
            // when they click button Mute       
            Mutte.Visible = false;
            Unmute.Visible = true;
            mute = true;
            if (!mute)// if mute is off, the sound plays
            {
                ArcadeSong.Play();
            }
        }
        private void pictureBox2_Click_3(object sender, EventArgs e)
        {
            
            Mutte.Visible = false;
            Unmute.Visible = true;
            Unmute.Top = 275;
            mute = true;
            ArcadeSong.Stop();
        }
        private void Unmute_Click(object sender, EventArgs e)
        {
            Unmute.Visible = false;
            Mutte.Visible = true;
            Mutte.Top = 275;
            mute = false;
            ArcadeSong.Play();
        }
        private void pictureBox2_Click_4(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Countdown_Tick(object sender, EventArgs e)
        {
            // write what happen aftter time end
            MessageBox.Show("Ton score est:" + score);
        }
        private void Start_Click(object sender, EventArgs e)
        {
            // when they click START
            MenuBack.Visible = false;
            Rules.Visible = false;
            TextRules.Visible = false; 
            Exit.Visible = false;
            Start.Visible = false; 
            ButtonJouer.Visible = false;
            ButtonOption.Visible = false;
            Backbutton.Visible = false;
            ArcadeSong.Stop();
            timer1.Start();
            Timerword.Visible = true;
            TimeLimit.Start();
            Clock.Start();
            ClockCount.Visible = true;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            //timer counting down           
            if (TimerCountdown > 0)
            {
                TimerCountdown = TimerCountdown - 1;
                ClockCount.Text = TimerCountdown + "";
            }

            if (ClockCount.Text == "0")
            {
                TimerCountdown = 60;
                Clock.Stop();
            }           
        }

        private void Rules_Click(object sender, EventArgs e)
        {

        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            //When 60 sec is done
            MessageBox.Show("Ton score est: " + score + "\n Tu es un expert!!");
            score = 0;
            timer1.Stop();
            Clock.Stop();
            TimeLimit.Stop();
            TITLE.Visible = true;
            ButtonJouer.Visible = true;
            ButtonOption.Visible = true;
            MenuBack.Visible = true;
            Timerword.Visible = false;
            ClockCount.Visible = false;
            if (!mute)// if mute is off, the sound plays
            {
                ArcadeSong.Play();
            }

        }
    }
}
