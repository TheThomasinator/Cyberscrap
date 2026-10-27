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
    public partial class Help : Form
    {
        User user;

        public Help(User current)
        {
            InitializeComponent();
            user = current;
            mainThemePlayer.settings.playCount = 9999;
            buttonNoisePlayer.Ctlcontrols.stop();
        }

        private void btnBack_Click(object sender, EventArgs e) //Open the main menu and stop the music so that the music does not overlap with the main menus music
        {
            buttonNoisePlayer.Ctlcontrols.play();
            mainThemePlayer.settings.playCount = 0;
            mainThemePlayer.Ctlcontrols.stop();
            var mainMenu = new MainMenu(user);
            this.Hide();
            mainMenu.Show();
        }
    }
}
