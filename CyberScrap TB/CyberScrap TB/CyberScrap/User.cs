using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CyberScrap
{
    [Serializable]
    public class User
    {
        private string username;
        private int charSelected;
        private Bitmap char1 = CyberScrap.Properties.Resources.Ch1Gameplay, char2 = CyberScrap.Properties.Resources.ShotGunGameplay, char3 = CyberScrap.Properties.Resources.Ch3GamePlay;


        public User(string username)
        {
            Username = username;
        }      

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public Bitmap BMP
        {
            get
            {
                if (charSelected == 0) //Returns the image based on what character the player is
                {
                    return char1;
                }
                else if (charSelected == 1)
                {
                    return char2;
                }
                else return char3;
            }           
        }           

        public string Weapon
        {
            get
            {
                if (charSelected == 0) //Returns the name of the weapon based on what character the player is
                {
                    return "SMG";
                }
                else if (charSelected == 1)
                {
                    return "SHOTGUN";
                }
                else return "SWORD";
            }
        }

        public int Character
        {
            set { charSelected = value; }
            get { return charSelected; }
        }
    }
}
