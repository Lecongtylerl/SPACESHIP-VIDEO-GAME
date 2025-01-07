using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float xOVNI;
        float vxOVNI = 3;
        bool left;
        bool right;
        float xCannon;
        float vxCannon = 2;
        float xLazer;
        float yLazer;
        float vxLazer = 0, vyLazer = 8;
        bool lazer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xOVNI = UFOPic.Left;
            xCannon = CannonPic.Left;
            xLazer = LazerPic.Left;
            yLazer = LazerPic.Top;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xOVNI += vxOVNI;
            if (xOVNI > ClientSize.Width)
            {
                xOVNI = -UFOPic.Width;
            }
            UFOPic.Left = (int)xOVNI;

            if (left)
            {
                xCannon -= vxCannon;
                CannonPic.Left = (int)xCannon;
            }
            if (right)
            {
                xCannon += vxCannon;
                CannonPic.Left = (int)xCannon;
            }
            //left = false;
            //right = false;

            if(lazer)
            {
                yLazer -= vyLazer;
                LazerPic.Top = (int)yLazer;

                if(LazerPic.Bounds.IntersectsWith(UFOPic.Bounds))
                {
                    UFOPic.Visible = false;
                    LazerPic.Visible = false;
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;
                }
                if (yLazer < -60)
                {
                    LazerPic.Visible = false;
                    lazer = false;
                    yLazer = 350;
                    LazerPic.Top = (int)yLazer;
                }

            }

        }

        private void keyDown(object sender, KeyEventArgs e)
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
                    xLazer = xCannon + 19;
                    LazerPic.Left = (int)xLazer;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
