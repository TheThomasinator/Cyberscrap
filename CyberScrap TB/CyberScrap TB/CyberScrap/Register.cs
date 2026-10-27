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
    public partial class Register : Form
    {

        string fp = @"userData.txt";
        string fp2 = @"userScore.txt";
        FileStream fs;
        FileStream fs2;
        StreamWriter sw;
        StreamWriter sw2;

        public Register()
        {        
            InitializeComponent();
            mainThemePlayer.settings.playCount = 9999;
            buttonNoisePlayer.Ctlcontrols.stop();
        }

        public void btnReg_Click(object sender, EventArgs e)
        {
            buttonNoisePlayer.Ctlcontrols.play();
            int check = 0;
            string userinput = userBox.Text;
            string userpass = passBox.Text;
            string conf = textBox3.Text;
            bool tildCheck = false;
            bool userFound = false;
            int length = userpass.Length;

            for (int i = 0; i > userinput.Length; i++) //cycle through each input for username
            {
                if (userinput[i] == '~') //check for ~
                {
                    tildCheck = true; //there is a tilde
                }
            }

            for (int i = 0; i > userpass.Length; i++) //cycle through each input for password
            {
                if (userpass[i] == '~')  //check for ~
                {
                    tildCheck = true; //there is a tilde
                }
            }

            if (tildCheck == false) //if there is no tilde in user inout
            {
                if ((!string.IsNullOrEmpty(userBox.Text)) && (!string.IsNullOrEmpty(passBox.Text)) && (!string.IsNullOrEmpty(textBox3.Text))) //checking that all text boxes have an input and aren't blank
                {
                    if (conf == userpass) //if the password and confirm password inputs are the same
                    {
                        if ((userinput.Length >= 5) && (userpass.Length >= 5)) //Checks that username and password are at least 5 characters long
                        {
                            for (int i = 0; i < length; i++) //cycles through each character of the inputed password
                            {
                                if (char.IsDigit(userpass[i]))
                                {
                                    check++; //increase the check amount by one each time a digit is found
                                }
                            }
                            if (check >= 3) //checks that there are at least 3 digits 
                            {
                                try
                                {
                                    string[] users = File.ReadAllLines("userData.txt").ToArray(); //saves the details in the textfile as an array

                                    for (int i = 0; i < users.Length; i++) //cycles through the array created
                                    {
                                        string[] userAndPass = users[i].Split('~'); //splits the details into username and password
                                        if ((userBox.Text == userAndPass[0])) //check if the user input for username exists already
                                        {
                                            userFound = true; //An existing user has been found
                                        }
                                        else userFound = false; //An existing user is not found
                                    }
                                    if (userFound == false)
                                    {                                        
                                        fs = new FileStream(fp, FileMode.Append, FileAccess.Write); //Opens a file stream so the file can be written to 
                                        sw = new StreamWriter(fs);  //creates a new writer to the text file
                                        sw.WriteLine(userBox.Text + "~" + passBox.Text); //Using the stram writer to write in the details
                                        sw.Close(); 
                                        fs.Close();
                                        
                                        fs2 = new FileStream(fp2, FileMode.Append, FileAccess.Write); //Opens a file so the file can be written to
                                        sw2 = new StreamWriter(fs2); //Creates a new writer to the text file
                                        sw2.WriteLine(userBox.Text + "~" + "0.none"); //Using the stram writer to write in the details
                                        sw2.Close();
                                        fs2.Close();

                                        MessageBox.Show("Welcome new user"); //Opens the login screen and stops the main theme player so that the music does not overlap
                                        mainThemePlayer.settings.playCount = 0;
                                        mainThemePlayer.Ctlcontrols.stop();
                                        var login = new Login();
                                        this.Hide();
                                        login.Show();
                                    }
                                }
                                catch
                                {
                                    fs = new FileStream(fp, FileMode.Create, FileAccess.Write); //Create a new file to write to
                                    sw = new StreamWriter(fs);  //creates a new writer to the text file
                                    sw.WriteLine(userBox.Text + "~" + passBox.Text);  //Using the stram writer to write in the details
                                    sw.Close();
                                    fs.Close();

                                    fs2 = new FileStream(fp2, FileMode.Create, FileAccess.Write); //Create a new file to write to
                                    sw2 = new StreamWriter(fs2);//creates a new writer to the text file
                                    sw2.WriteLine(userBox.Text + "~" + "0.none"); //Using the stram writer to write in the details
                                    sw2.Close();
                                    fs2.Close();

                                    MessageBox.Show("Welcome new user");  //Opens the login screen and stops the main theme player so that the music does not overlap
                                    mainThemePlayer.settings.playCount = 0;
                                    mainThemePlayer.Ctlcontrols.stop();
                                    var login = new Login();
                                    this.Hide();
                                    login.Show();
                                }

                                if (userFound == true)
                                {
                                    MessageBox.Show("This user already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
                                }
                            }
                            else MessageBox.Show("Password must contain at least 3 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
                        }
                        else MessageBox.Show("Username and password must both be at least 5 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
                    }
                    else MessageBox.Show("Password and password confirmation don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
                }
                else MessageBox.Show("Do not leave any boxes blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
            }
            else MessageBox.Show("Can't use ~ character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message
            tildCheck = false; //resets it for the next register attempt
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            buttonNoisePlayer.Ctlcontrols.play();  //Opens the login screen and stops the main theme player so that the music does not overlap
            mainThemePlayer.settings.playCount = 0;
            mainThemePlayer.Ctlcontrols.stop();
            var login = new Login();
            this.Hide();
            login.Show();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
