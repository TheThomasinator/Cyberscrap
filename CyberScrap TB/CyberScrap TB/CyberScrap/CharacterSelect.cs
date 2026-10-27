using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CyberScrap
{
    public partial class CharacterSelect : Form
    {
        User current;
        int currentRobot;
        Image robo1 = CyberScrap.Properties.Resources.Future_Warrior;
        Image robo2 = CyberScrap.Properties.Resources.ShotgunCs;
        Image robo3 = CyberScrap.Properties.Resources.Ancient_Titan_Select;
        bool selectCheck = false;

        public CharacterSelect(User user)
        {
            current = user;           
            InitializeComponent();
            mainThemePlayer.settings.playCount = 9999;
            buttonNoisePlayer.Ctlcontrols.stop();

        }

        private void CharacterPan1_MouseDown(object sender, MouseEventArgs e) //If the first pabel is dragged in then set the current robot int to the panels tag (1)
        {
            Panel source = (Panel)sender;
            currentRobot = Int32.Parse(((Panel)source).Tag.ToString());
            DoDragDrop(source.BackgroundImage, DragDropEffects.Copy);
        }

        private void CharacterPan2_MouseDown(object sender, MouseEventArgs e) //If the second pabel is dragged in then set the current robot int to the panels tag (2)
        {
            Panel source = (Panel)sender;
            currentRobot = Int32.Parse(((Panel)source).Tag.ToString());
            DoDragDrop(source.BackgroundImage, DragDropEffects.Copy);
        }


        private void CharacterPan3_MouseDown(object sender, MouseEventArgs e) //If the third pabel is dragged in then set the current robot int to the panels tag (3)
        {
            Panel source = (Panel)sender;
            currentRobot = Int32.Parse(((Panel)source).Tag.ToString());
            DoDragDrop(source.BackgroundImage, DragDropEffects.Copy);
        }

        private void SelectedCharPan_DragEnter(object sender, DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void SelectedCharPan_DragDrop(object sender, DragEventArgs e)  //When a panel is dragged into this panel set the image to whatever the image of the panel that was dragged in is
        {
            Panel destination = (Panel)sender;
            current.Character = currentRobot;
            selectCheck = true;
            if (currentRobot == 0)
            {
                SelectedCharPan.BackgroundImage = robo1;
            }
            if (currentRobot == 1)
            {
                SelectedCharPan.BackgroundImage = robo2;
            }
            if (currentRobot == 2)
            {
                SelectedCharPan.BackgroundImage = robo3;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            buttonNoisePlayer.Ctlcontrols.play();
            if (selectCheck == true) //If the player has chosen a character open the game screen and stop the music so that the music does not overlap with the game screens music
            {
                mainThemePlayer.settings.playCount = 0;
                mainThemePlayer.Ctlcontrols.stop();
                var game = new Game(current);            
                this.Hide();               
                game.Show(); 
            }
            else //If the player has not
                MessageBox.Show("Please select a character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
