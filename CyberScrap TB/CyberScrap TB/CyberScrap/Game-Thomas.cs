using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberScrap
{
    public partial class Game : Form
    {
        bool left, right, up, down, gameStart, reload = false;
        bool[] collideChecks = new bool[20];
        Rectangle rectPlayer;
        Rectangle[] rectBullet, rectWall;
        Brush wallBrush;
        string angle;
        int clipCount = 19, collisCycle = 19;
        SmgBullet[] myClip = new SmgBullet[20];
        User user;
        string lastKey;
        Point playerPoint;
        int currentRotated = 19;


        public Game(User user)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.user = user;
            rectPlayer = new Rectangle(100, 100, 100, 100);
            for (int i = 0; i < 20; i++)
            {
                myClip[i] = new SmgBullet();
            }



            rectBullet = new Rectangle[]
                {
                    myClip[0].GetRectangle(),
                    myClip[1].GetRectangle(),
                    myClip[2].GetRectangle(),
                    myClip[3].GetRectangle(),
                    myClip[4].GetRectangle(),
                    myClip[5].GetRectangle(),
                    myClip[6].GetRectangle(),
                    myClip[7].GetRectangle(),
                    myClip[8].GetRectangle(),
                    myClip[9].GetRectangle(),
                    myClip[10].GetRectangle(),
                    myClip[11].GetRectangle(),
                    myClip[12].GetRectangle(),
                    myClip[13].GetRectangle(),
                    myClip[14].GetRectangle(),
                    myClip[15].GetRectangle(),
                    myClip[16].GetRectangle(),
                    myClip[17].GetRectangle(),
                    myClip[18].GetRectangle(),
                    myClip[19].GetRectangle()
                };
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rectBullet[clipCount].Location = new Point(rectPlayer.X + 28, rectPlayer.Y + 28);
            myClip[clipCount].SetBMP(RotateImage(myClip[clipCount].GetBMP(), GetAngleBetweenPlayerAndMouse(playerPoint, Cursor.Position), true));
            clipCount--;  
            if (clipCount < 0)
            {
                reload = true;
                clipCount = 19;
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (gameStart == true)
            {
                g.DrawImage(user.GetBMP(), rectPlayer);
                for (int i = 0; i < 20; i++)
                {
                    g.DrawImage(myClip[i].GetOgBMP(), rectBullet[i]);
                }
            }
            else
            {
                playerPoint = new Point(rectPlayer.X + 50, rectPlayer.Y - 50);
                g.DrawImage(RotateImage(user.GetBMP(), GetAngleBetweenPlayerAndMouse(playerPoint, Cursor.Position), true), rectPlayer);
                if (reload == true)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        g.DrawImage(myClip[i].GetOgBMP(), rectBullet[i]);
                        reload = false;
                    }
                }
                else
                {
                    for (int i = 0; i < 20; i++)
                    {
                        g.DrawImage(myClip[i].GetBMP(), rectBullet[i]);
                    }
                }
            }

            
        

        }
        private void Form1_Paint2(object sender, PaintEventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A: left = true; lastKey = "left"; break;
                case Keys.W: up = true; lastKey = "up"; break;
                case Keys.S: down = true; lastKey = "down"; break;
                case Keys.D: right = true; lastKey = "right"; break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A: left = false; break;
                case Keys.W: up = false; break;
                case Keys.S: down = false; break;
                case Keys.D: right = false; break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameStart = false;
            angle = GetAngleBetweenPlayerAndMouse(playerPoint, Cursor.Position).ToString();
            label2.Text = angle;
            if (left) rectPlayer.X -= 7;
            if (right) rectPlayer.X += 7;
            if (up) rectPlayer.Y -= 7;
            if (down) rectPlayer.Y += 7;
            foreach (bool b in collideChecks)
            {
                if (b == true)
                {
                    rectBullet[collisCycle].Location = new Point(3000, 3000);
                    collisCycle--;
                }
                collisCycle = 19;
            }

            


            Invalidate();
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
        public static float GetAngleBetweenPlayerAndMouse(Point p1, Point p2) //https://stackoverflow.com/questions/12891516/math-calculation-to-retrieve-angle-between-two-points
        {
            float xDiff = p2.X - p1.X;
            float yDiff = p2.Y - p1.Y;
            return (float)(Math.Atan2(yDiff, xDiff) * (180 / Math.PI));
        }

        private Bitmap RotateImage(Bitmap bmp, float angle, bool player) //https://stackoverflow.com/questions/12024406/how-can-i-rotate-an-image-by-any-degree
        {
          
            float height = bmp.Height;
            float width = bmp.Width;
            int hypotenuse = System.Convert.ToInt32(System.Math.Floor(Math.Sqrt(height * height + width * width)));
            Bitmap rotatedImage = new Bitmap(hypotenuse, hypotenuse);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(angle); //rotate
                g.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2); //restore rotation point into the matrix
                g.DrawImage(bmp, (hypotenuse - width) / 2, (hypotenuse - height) / 2, width, height);
            }
            if (player == false)
            {
                myClip[clipCount].SetBMP(rotatedImage);
            }
            return rotatedImage;
        }

    }  
}
