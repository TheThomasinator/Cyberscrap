using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberScrap
{


    class Weapon
    {
        private Bitmap bullet = CyberScrap.Properties.Resources.Bullet, pellet = CyberScrap.Properties.Resources.Pellet, rotatedBullet = CyberScrap.Properties.Resources.Bullet, swordSlash = Properties.Resources.SwordSlash, laser = CyberScrap.Properties.Resources.Laser;      
        private bool friendly, moved;
        private float angle;
        private int x, y;
        private string weapon;

        public Weapon(bool friendly, string type)
        {
            this.friendly = friendly;
            weapon = type;
            if (weapon == "SMG") //Determines what image the player projectile will be
            {
                BMP = bullet;
            }
            else if (weapon == "SHOTGUN")
            {
                BMP = pellet;             
            }
            else if (weapon == "SWORD")
            {
                BMP = swordSlash;
            }
            else
            {
                BMP = laser;
            }
            
        }

        public Bitmap OgBMP
        {
            get
            {
                if (weapon == "SMG") //Returns the appropriate image for the character 
                {
                    return bullet;
                }
                else if (weapon == "SHOTGUN")
                {
                    return pellet;
                }
                else if (weapon == "SWORD")
                {
                    return swordSlash;
                }
                else
                {
                    return laser;
                }
            }
        }

        public Bitmap BMP
        {
            get { return rotatedBullet; }
            set { rotatedBullet = value; }
        }     

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

       
        public bool Move
        {
            get { return moved; }
            set { moved = value; }
        }

        
        public double Speed
        {
            get
            {
                if (friendly || weapon == "SWORD") //The sword and railgun have their own speed values and the SMG and Shotgun both have the same
                {
                    return 100;
                }
                else if (weapon == "RAILGUN")
                {
                    return 200;
                }
                else return 50;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y 
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
