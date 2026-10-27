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
using System.Media;

namespace CyberScrap
{
    public partial class Login : Form
    {

        bool userFound = false;
        string currentUser = "";

        public Login()
        {
            InitializeComponent();
            buttonNoisePlayer.Ctlcontrols.stop();
            mainThemePlayer.settings.playCount = 9999;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            buttonNoisePlayer.Ctlcontrols.play();
            if ((!string.IsNullOrEmpty(userBox.Text)) && (!string.IsNullOrEmpty(passBox.Text))) //if both boxes have been filled
            {
                //try //If a userData file exists
                //{
                    string[] users = File.ReadAllLines("userData.txt").ToArray(); //converting all the usernames and passwords into an array

                    for (int i = 0; i < users.Length; i++) //looping through each username and password
                    {
                        string[] userAndPass = users[i].Split('~'); //splitting the username and password 
                        if ((userBox.Text == userAndPass[0]) && (passBox.Text == userAndPass[1])) //checking the username and password 
                        {
                            userFound = true;
                            currentUser = userBox.Text;
                        }
                    }

                    if (userFound == true)  //if the inputs match an existing user
                    {
                        User user = new User(currentUser); //new user object
                        MessageBox.Show("CORRECT, PLEASE ENTER");
                        mainThemePlayer.settings.playCount = 0;
                        mainThemePlayer.Ctlcontrols.stop();
                        var mainMenu = new MainMenu(user); //New menu with the "user" class which define name and highscore
                        this.Hide();
                        mainMenu.Show();
                    }
                    else MessageBox.Show("Username or Password is incorrect, please re-enter your details or create a new account"); //error message
                //}
                //catch //If no userData file exists
                //{
                //    MessageBox.Show("There are no users on file, please register a new user"); //error message
                //}
            }
            else MessageBox.Show("Do not leave any boxes blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit the game
        {
            Environment.Exit(1);
        }

        private void btnReg_Click(object sender, EventArgs e) //Open the register screen and stop the music so that the music from the register screen does not overlap
        {
            buttonNoisePlayer.Ctlcontrols.play();
            mainThemePlayer.Ctlcontrols.stop();
            var register = new Register(); 
            this.Hide();
            register.Show(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
