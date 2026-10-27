using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CyberScrap
{

    public partial class MainMenu : Form
    {
        User current;
        ScoreObj temp;
        string fp;
        string[] users, userScoreandChar, userDetails;
        int lineNum;

        public MainMenu(User myUser)  //Because of an issue when switching between my home pc and the school pc, the sound for this screen has broken
        {
            InitializeComponent();
            current = myUser;
            //mainThemePlayer.settings.playCount = 9999;
            //buttonNoisePlayer.Ctlcontrols.stop();
            fp = "backups/" + current.Username + "Backup.bin";
            username.Text = current.Username;
        }

        private void btnStory_Click(object sender, EventArgs e) //Stop the music so the sound doesn't overlap with the next screen then open the prologue epilogue screen
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            //mainThemePlayer.settings.playCount = 0;
            //mainThemePlayer.Ctlcontrols.stop();
            var pro_epi = new Prologue_Epilogue(current, "Prologue", false, 0);
            this.Hide();
            pro_epi.Show();
        }

        private void btnLdrBrd_Click(object sender, EventArgs e) //Stop the music so the sound doesn't overlap with the next screen then open the leaderboard screen
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            //mainThemePlayer.settings.playCount = 0;
            //mainThemePlayer.Ctlcontrols.stop();
            var leaderboard = new Leaderboard(current);
            this.Hide();
            leaderboard.Show();
        }

        private void stripChangeUser_Click(object sender, EventArgs e) //Stop the music so the sound doesn't overlap with the next screen then open the login screen
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            //mainThemePlayer.settings.playCount = 0;
            //mainThemePlayer.Ctlcontrols.stop();
            var login = new Login();
            this.Hide();
            login.Show();

        }
        private void stripLogOut_Click(object sender, EventArgs e) //Close the game
        {
            Environment.Exit(0);
        }

        private void stripBackup_Click(object sender, EventArgs e) //Ask the player if they want to create a backup file and if they chose yes then play the Serialize() method
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            string overwrite = "You are about to overwrite your existing backup. Do you want to continue?";
            DialogResult dialogResult = MessageBox.Show(overwrite, "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Serialize();
                MessageBox.Show("Backup was successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("Backup was cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stripRestore_Click(object sender, EventArgs e) //Ask the player if they want to restore a backup file and if they chose yes then play the Deserialize() method 
        {                                                       
            //buttonNoisePlayer.Ctlcontrols.play();
            string restore = "You are about to load your existing backup and replace your current player details. Do you want to continue?"; DialogResult dialogResult = MessageBox.Show(restore, "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Deserialize();
            }
            else if (dialogResult == DialogResult.No)
                MessageBox.Show("Restore was cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Serialize()
        {
            try //try to delete the backup file
            {
                File.Delete(fp);
            }
            finally 
            {
                users = File.ReadAllLines("userScore.txt").ToArray(); //converting all the usernames and passwords into an array

                for (int i = 0; i < users.Length; i++)
                {
                    userDetails = users[i].Split('~'); //splits it
                    userScoreandChar = userDetails[1].Split('.'); //splits it again

                    if (userDetails[0] == current.Username)
                    {
                        temp = new ScoreObj(userDetails[0], userScoreandChar[0], userScoreandChar[1]); //set a temp variable to the ScoreObj object
                    }
                }

                Stream st = File.OpenWrite(fp);

                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(st, temp); //Write the temp variable that contains the ScoreObj object to the file path

                st.Flush();
                st.Close();
                st.Dispose();
            }
        }

        private void Deserialize()
        {
            try //If there is a backup file
            {
                BinaryFormatter bf = new BinaryFormatter();

                FileStream fs = File.Open(fp, FileMode.Open); //Open the file stream

                object obj = bf.Deserialize(fs); //Take the backup file and put it into an object variable

                temp = (ScoreObj)obj; //Convert that object variable int a ScoreObj variable and set it to temp

                users = File.ReadAllLines("userScore.txt").ToArray(); //Convert the user score file into an array

                lineNum = 0;
                for (int i = 0; i < users.Length; i++) //Go through each array line and if the current user matches the lines username currently being looked at then replace that line 
                {                                      //with the temp objects full details string variable
                    userDetails = users[i].Split('~'); 

                    if (userDetails[0] == current.Username)
                    {
                        users[lineNum] = temp.FullDetails;
                    }
                    lineNum++;
                }

                File.WriteAllLines("userScore.txt", users); //Rewrite the array back to the file

                MessageBox.Show("Restore was successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fs.Flush();
                fs.Close();
                fs.Dispose();
            }
            catch //If there is no backup file
            {
                MessageBox.Show("There is no backup file available, please create one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpBtn_Click(object sender, EventArgs e) //Open the help screen and stop the music so that the music from the help screen does not overlap with it
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            //mainThemePlayer.settings.playCount = 0;
            //mainThemePlayer.Ctlcontrols.stop();
            var help = new Help(current);
            this.Hide();
            help.Show();
        }

      
    }
}
