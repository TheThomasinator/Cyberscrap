using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberScrap
{
    [Serializable]
    class ScoreObj
    {
        private string fullDetails, username;

        public ScoreObj(string username, string score, string character)  //Populates fulldetails so that it can be stored in a binary file or taken out of a binary file
        {
            FullDetails = username + "~" + score + "." + character;
            Username = username;
        }

        public string FullDetails
        {
            get { return fullDetails; }
            set { fullDetails = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
