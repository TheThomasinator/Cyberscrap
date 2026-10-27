using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberScrap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            User user = new User("Thomas101");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu(user));
            //Application.Run(new CharacterSelect(user));
            Application.Run(new Login());
            //Application.Run(new Prologue_Epilogue(user, "Prologue", false, 0));
        }
    }
}
