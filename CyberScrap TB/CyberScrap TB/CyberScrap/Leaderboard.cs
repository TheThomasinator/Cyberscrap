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
    public partial class Leaderboard : Form
    {
        User current;

        public Leaderboard(User user)
        {
            InitializeComponent();
            current = user;
            mainThemePlayer.settings.playCount = 9999;
            buttonNoisePlayer.Ctlcontrols.stop();
            buttonNoisePlayer.Ctlcontrols.stop();
            displayScores();
        }

        private void displayScores()
        {
            string[] users = File.ReadAllLines("userScore.txt").ToArray(); //turns the file into a string array
            for (int i = 0; i < users.Length; i++)
            {
                string[] userDetails = users[i].Split('~'); //splits it
                string[] userScoreandChar = userDetails[1].Split('.'); //splits it again
                highScoreTbl.Rows.Add(userDetails[0], Int32.Parse(userScoreandChar[0]), userScoreandChar[1]); //adds the details to the table
            }
        }

        private void button1_Click(object sender, EventArgs e) //Open the main menu screen and stop the music so that the music from the main menu does not overlap
        {
            buttonNoisePlayer.Ctlcontrols.play();
            mainThemePlayer.settings.playCount = 0;
            mainThemePlayer.Ctlcontrols.stop();
            var MainMenu = new MainMenu(current); //New menu 
            this.Hide(); 
            MainMenu.Show(); 
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }
    }
}

