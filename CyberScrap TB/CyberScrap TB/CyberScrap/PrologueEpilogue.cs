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
    public partial class Prologue_Epilogue : Form
    {
        User current;
        string firstMsg, secondMsg, thirdMsg;
        int i = 0, score;
        bool firstMessageDone = false, secondMessageDone = false, thirdMessageDone, transitionDone = false, pause = true, winLose;      
        string state;
        Image transition1 = Properties.Resources.Transition1P1, transition2 = Properties.Resources.Transition1P2, transition3 = Properties.Resources.Transition1P3, transition4 = Properties.Resources.Transition1P4, transitionFinal = Properties.Resources.Transition1Final;
        Image[] transition = new Image[5];

        public Prologue_Epilogue(User user, string prologueOrEpilogue, bool winLose, int score)
        {
            InitializeComponent();
            mainThemePlayer.settings.playCount = 9999;
            buttonNoisePlayer.Ctlcontrols.stop();
            if (!winLose) //Determines what music plays depending on if the player won or lost
            {
                winMusicPlayer.Ctlcontrols.stop();
            }
            else
            {
                mainThemePlayer.settings.playCount = 0;
                mainThemePlayer.Ctlcontrols.stop();
            }
            state = prologueOrEpilogue;
            current = user;
            this.score = score;
            this.winLose = winLose;

            if (state == "Prologue") //Determines what the text boxes will say based on if its the epilogue or prologue
            {
                BackgroundImage = Properties.Resources.PrologueStart;
                firstMsg = "In a far distant future, everything is done by robots and life becomes easy for humanity, why do it when the robot can do it for you? But what happens when the robots are thrown away? What happens when they go against programming?";
                secondMsg = "The answer? A society forms, created by the robots upon the scrap. Their hierarchy? Based on their combative skill. In the harsh environment that is the scrapyard only the strong come out on top. That is the society the robots built.";
                thirdMsg = "A butler bot, Bob, has risen to be the king and rules over the scrapyard with an iron fist. Do you have what it takes to defeat him and his subordinates and claim the throne for yourself? or will you die trying?";               
            }
            else
            {
                BackgroundImage = Properties.Resources.PrologueStart;
                firstMsg = "You've done it! No one believed in you but you did it!";
                secondMsg = "The scrapyard has been made a better place now that you are king, your subjects are loyal because of your fair treatment of all and all is good within your kingdom.";
                thirdMsg = "Your story will be spread down the line, king by king after you eventually rust away. Your legacy is eternal.";      
            }

            transition[0] = transition1; //Sets the array varaibles to the correct images
            transition[1] = transition2;
            transition[2] = transition3;
            transition[3] = transition4;
            transition[4] = transitionFinal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 5000) //When the timer interval is set to 5000 a long pause is taken before the next tick and then that is detected by this conditional statement to go to the next screen
            {
                timer.Stop();
                if (state == "Prologue") //If the prologue just played then stop the sounds to prevent music overlap and open the character select
                {
                    mainThemePlayer.settings.playCount = 0;
                    mainThemePlayer.Ctlcontrols.stop();
                    winMusicPlayer.Ctlcontrols.stop();
                    var characterSelect = new CharacterSelect(current);
                    this.Hide();
                    characterSelect.Show();
                }
                else  //If the epilogue just played then stop the sounds to prevent music overlap and open the game win lose screen
                {
                    mainThemePlayer.settings.playCount = 0;
                    mainThemePlayer.Ctlcontrols.stop();
                    winMusicPlayer.Ctlcontrols.stop();
                    var gameWinLose = new GameWinLose(current, winLose, score);
                    this.Hide();
                    gameWinLose.Show();
                }
            }

            if (timer.Interval == 3000) //When a sentence finishes in the textbox then the interval is set to 3000 for a pause so the player can read it and then the timer interval is detected within
            {                           //this conditional the game knows when to set pause to false, continuing the next piece of code
                pause = false; 
            }

            if (i < firstMsg.Length + 1 && !firstMessageDone) //If the first message is still playing then update the label to include up to whatever I has been reached
            {
                storyLbl.Text = firstMsg.Substring(0, i);
                i++;
            }
            else if (i >= firstMsg.Length && !firstMessageDone) //If the message has been comepleted but the bool not set to true then set the bool to true and reset I and set the timer to 3000 so a pause
            {                                                   //happens allowing the player time to read
                firstMessageDone = true;
                i = 0;
                timer.Interval = 3000;
            }

            if (firstMessageDone && !transitionDone && !pause) //If the first message has finished, there isnt a pause for the player to read and the image transition has not occured then set the interval
            {                                                  //to 200 and for each tick changge the image untill the i value has reached 5 (transition length) which creates the illusion of the images
                timer.Interval = 200;                          //slowly changing. Then reset i and set inteval to 40 and set transitionDone to true so the next part of the code can play
                if (i < transition.Length)
                {
                    BackgroundImage = transition[i];
                    i++;
                }
                else if (i >= transition.Length)
                {
                    transitionDone = true;
                    i = 0;
                    timer.Interval = 40;
                }
            }
              

            if (transitionDone) //If the image transition has played
            {
                if (timer.Interval == 3000) //Two messages play after the inage transition so the timer will switch to 3000 at one point to allow the player to read the first sentence
                {                           //If this happens then the interval needs to swapped back to 40 to allow the text to play normally once the third line begins
                    timer.Interval = 40;
                }
                else if (secondMessageDone) //If the second message has finished 
                {
                    if (i < thirdMsg.Length + 1 && !thirdMessageDone) //If the third message is not done then for each tick change the label to be the message up to a certain point (i) and increment
                    {                                                 //i each tick so that the message progessively appears
                        storyLbl.Text = thirdMsg.Substring(0, i);
                        i++;
                    }
                    else if (i >= thirdMsg.Length && !thirdMessageDone) //If the thirdMessageDone variable is false but the entire message is now in the label then set third message done to true 
                    {                                                   //and set interval to 5000 so a long pause happens before the very top code plays to open the next screen 
                        thirdMessageDone = true;
                        timer.Interval = 5000;
                    }
                }

                if (i < secondMsg.Length + 1 && !secondMessageDone)  //If the second message is not done then for each tick change the label to be the message up to a certain point (i) and increment
                {                                                    //i each tick so that the message progessively appears
                    storyLbl.Text = secondMsg.Substring(0, i);
                    i++;
                }
                else if (i >= secondMsg.Length && !secondMessageDone) //If the secondNessageDone variable is false but the entire message is now in the label then set second message done to true 
                {                                                     //then set the interval to 3000 so there is a pause
                    secondMessageDone = true;
                    i = 0;
                    timer.Interval = 3000;
                }
            }          
        }
       

        private void btnSkip_Click(object sender, EventArgs e)
        {
            buttonNoisePlayer.Ctlcontrols.play();
            if (state == "Prologue") //If the prologue just played then stop the sounds to prevent music overlap and open the character select screen
            {
                mainThemePlayer.settings.playCount = 0;
                mainThemePlayer.Ctlcontrols.stop();
                winMusicPlayer.Ctlcontrols.stop();
                timer.Stop();
                var characterSelect = new CharacterSelect(current);
                this.Hide();
                characterSelect.Show();
            }
            else //If the epilogue just played then stop the sounds to prevent music overlap and open the game win lose screen
            {
                mainThemePlayer.settings.playCount = 0;
                mainThemePlayer.Ctlcontrols.stop();
                winMusicPlayer.Ctlcontrols.stop();
                timer.Stop();
                var gameWinLose = new GameWinLose(current, winLose, score);
                this.Hide();
                gameWinLose.Show();
            }
        }
    }
}
