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
    public partial class GameWinLose : Form
    {
        User user;
        bool win;
        int score;

        public GameWinLose(User current, bool win, int score)
        {
            InitializeComponent();
            if(win) //If the player won then stop playing the lose music
            {
                loseMusicPlayer.Ctlcontrols.stop();
            }
            else //if the player didnt win then stop playing the win music
            {
                winMusicPlayer.Ctlcontrols.stop();
            }
            buttonNoisePlayer.Ctlcontrols.stop();
            user = current; 
            this.win = win;
            this.score = score;
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            scoreLbl.Text = score.ToString(); //Set the score label to the score passed in from the game screen
            if (win) 
            {
                WinLoseBox.Image = CyberScrap.Properties.Resources.YouWinImg;
            }
            else
            {
                WinLoseBox.Image = CyberScrap.Properties.Resources.YouLoseImg;
            }

            string[] users = File.ReadAllLines("userScore.txt").ToArray(); //Convert the score file into an array

            foreach (string s in users) //foreach line of the file split it and check if the username from the file matches the current player
            {                           //If it matches then set the high score label to the high score from the text file
                string[] allUserScore = s.Split('~');
                string username = allUserScore[0];
                string[] scoreAndChar = allUserScore[1].Split('.');
                if (allUserScore[0] == user.Username) //If the array lines username variable matches the current username then set the high score label to that array lines high score variable
                {                
                    highScoreLbl.Text = scoreAndChar[0];
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) //Exit the game
        {
            Environment.Exit(0);
        }

        private void menuBtn_Click(object sender, EventArgs e) //Go back to the main menu and stop the music so that the main menu music does not overlap
        {
            loseMusicPlayer.Ctlcontrols.stop();
            winMusicPlayer.Ctlcontrols.stop();
            buttonNoisePlayer.Ctlcontrols.play();
            var MainMenu = new MainMenu(user); 
            this.Hide();
            MainMenu.Show(); 
        }    

        private void tryAgainBtn_Click(object sender, EventArgs e) //Go back to the character select and stop the music so that he character select music does not overlap
        {
            loseMusicPlayer.Ctlcontrols.stop();
            winMusicPlayer.Ctlcontrols.stop();
            buttonNoisePlayer.Ctlcontrols.play();
            var characterSelect = new CharacterSelect(user);
            this.Hide();
            characterSelect.Show();
        }
    }
}
