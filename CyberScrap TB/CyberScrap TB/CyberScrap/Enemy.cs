using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberScrap
{
    class Enemy
    {
        private int speed = 10, type, playerDistanceX, playerDistanceY, x, y, shotCount, bulDelay, clipCount = 19, projectileNum;
        private Bitmap ogBMP, bmp;
        private float angle;
        private bool enemyActive = false;
        private Weapon[] enemyClip = new Weapon[20];
        private string weaponName;
        private Point enemyPoint;
       
        public Enemy(int type)
        {
            Type = type;

            if (type == 1) //Depending on the enemy type sett the appropriate image for the enemy and set the string for their weapon type
            {
                BMP = CyberScrap.Properties.Resources.Enemy;
                weaponName = "SMG";
            }
            else if (type == 2)
            {
                BMP = CyberScrap.Properties.Resources.Enemy;
                weaponName = "SHOTGUN";
            }
            else if (type == 3)
            {
                BMP = CyberScrap.Properties.Resources.Enemy;
                weaponName = "SWORD";
            }
            else if(type  == 4)
            {
                BMP = CyberScrap.Properties.Resources.MiniBossGameplay;
                weaponName = "RAILGUN";
            }
            else
            {
                BMP = CyberScrap.Properties.Resources.BossGameplay;
                weaponName = "Mechromancy";
            }

            OgBMP = BMP;

            for (int j = 0; j < 20; j++) //Populate 20 weapon objects
            {
                enemyClip[j] = new Weapon(false, weaponName);
            }
        }

        public Bitmap OgBMP
        {
            get { return ogBMP; }
            set { ogBMP = value; }

        }
        public Bitmap BMP
        {
            get { return bmp; }
            set { bmp = value; }
        }

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool EnemyActive
        {
            get { return enemyActive; }
            set { enemyActive = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int PlayerDistanceX
        {
            get { return playerDistanceX; }
            set { playerDistanceX = value; }
        }

        public int PlayerDistanceY
        {
            get { return playerDistanceY; }
            set { playerDistanceY = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int BulDelay
        {
            get { return bulDelay; }
            set { bulDelay = value; }
        }

        public int ShotCount
        {
            get { return shotCount; }
            set { shotCount = value; }
        }

        public int ClipCount
        {
            get { return clipCount; }
            set { clipCount = value; }
        }           

        public double BulSpeed //Depending on the type of enemy return how fast the enemies bullets will travel
        {
            get
            {
                if (weaponName == "SMG")
                {
                    return 100;
                }
                else if (weaponName == "SHOTGUN")
                {
                    return 200;
                }
                else if (weaponName == "SWORD")
                {
                    return 100;
                }
                else 
                { 
                    return 1000;
                }
            }
        }        

        public Point EnemyPoint
        {
            get { return enemyPoint; }
            set { enemyPoint = value; }
        }

        public Weapon[] EnemyClip
        {
            get { return enemyClip; }
            set { enemyClip = value; }
        }

        public int ProjectileNum
        {
            get { return projectileNum; }
            set { projectileNum = value; }
        }                      
    }
}
