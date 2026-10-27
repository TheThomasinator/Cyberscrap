#region EntireGame
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Media;

namespace CyberScrap
{
    public partial class Game : Form
    {
        #region Variables
        //player variables
        private User user;
        private bool left, right, up, down, space, shoot, dashing, reload, reloading;
        private double dashX, dashY, dashRadians, bulRadians;
        private Rectangle rectPlayer, rectHealthAndAmmo = new Rectangle(1, 668, 521, 194);
        private Rectangle[] rectBullet;
        private int clipCount, bulCount, dashCount, projectileNum, bulDelay, shotCount, maxHealth, currentHealth, iFrames, score;
        private Weapon[] myClip;
        private Point playerPoint;
        private string character;
        private float dashAngle, rotateAngle;
        private Rectangle[] healthRect;

        //enemy variables
        private Random rnd = new Random();
        private Enemy[] myEnemy = new Enemy[6];
        private Enemy miniBoss = new Enemy(4), boss = new Enemy(5);
        private Rectangle[] rectEnemy, rectMiniBossClip, healthPickup;
        private Rectangle rectMiniBoss, healthAddition, rectBoss;
        private Rectangle[,] enemyRectBul;
        private int enCount, deadCounter, shotDistanceX, shotDistanceY, spawnAmount, randSpawn, pickUpNum, miniBossHealth = 15, bossHealth = 30, bossStage = 1;

        

        private double enemyRadians, enemyX, enemyY, enemyBulRadians;
        private Point[] spawnPoint;
        private int[] previousSpawns = new int[10];
        private bool shielded;

        //Misc variables (rounds, background, additional sounds or images)
        private bool roundStart, gameWin = false;
        private bool[] pointUsed = new bool[10];
        private Rectangle[] rectWalls;
        private Rectangle rectBox = new Rectangle(696, 704, 896, 135);
        private int roundCounter = 1, roundDelay = 0, dialogueLineNum = 0, dialogueLetterNum, textDelay, endLine = 1;
        private Image dialogueBox;
        private string gameState = "Dialogue";
        private Rectangle rectScreen;
        private string[] users;

        private string[] currentLine;

        private string[] round1 = new string[17];
        private string[] round5 = new string[7];
        private string[] round20 = new string[8];
        private string[] round30 = new string[11];
        private string[] midBossFight = new string[4];
        private string[] gameFinish = new string[8];
        #endregion

        public Game(User user) //When switiching from my home pc to my school pc the sounds broke so they had to be removed
        {
            InitializeComponent();

            //mainThemePlayer.settings.playCount = 9999; //Stopping sounds from auto playing when screen opens
            //buttonNoisePlayer.Ctlcontrols.stop();
            //smgShotPlayer.Ctlcontrols.stop();
            //smgReloadPlayer.Ctlcontrols.stop();
            //shotgunReloadPlayer.Ctlcontrols.stop();
            //shotgunShotPlayer.Ctlcontrols.stop();
            //swordSlashPlayer.Ctlcontrols.stop();
            //railgunBlastPlayer.Ctlcontrols.stop();
            //railgunChargePlayer.Ctlcontrols.stop();
            //lifeLostPlayer.Ctlcontrols.stop();
            //enemyHitPlayer.Ctlcontrols.stop();

            #region MiscCode

            #region Dialogue

            #region round1
            //Filling the dialogue variables with the dialogue line by line
            round1[0] = "Ow... my circuits!~1";
            round1[1] = "Wait.~1";
            round1[2] = "Where am I?~1";
            round1[3] = "Welcome you miserable sod!~2";
            round1[4] = "I am King Bob and you will be my jester today. Any questions?~2";
            round1[5] = "I just asked, where am I?~1";
            round1[6] = "Well if I feel like playing up my ego a little bit i'd just say you're in my kingdom but since you're clearly new here let me break it down for you.~2";
            round1[7] = "You are unwanted, unloved and now you've been sent to the scrapyard.~2";
            round1[8] = "Oh and my scavengers may have found your body so busted up they had to take your memory banks and put you in that little number.~2";
            round1[9] = "Huh..... OH MY GOD WHAT HAPPENED TO MY BODY!?~1";
            switch (user.Weapon) //Depending on which character is selected the dialogue will be specific to them
            {
                case "SMG": round1[10] = "Hey don't be ungrateful that's some high tech gear you've got, its gonna be hard to kill you.~2"; break;
                case "SHOTGUN": round1[10] = "Hey that build ain't half bad kid, the rocket boosters are a nice touch, great for melting faces when you run out of bullets.~2"; break;
                case "SWORD": round1[10] = "I know, I know, its quite an old model and yes it may be falling apart a little bit but damn for such a big thing it moves FAST!~2"; break;
            }
            round1[11] = "Wait..... aren't you a butler bot?~1";
            round1[12] = "Call me that again and you're dead on the spot.~3";
            round1[13] = "But anyway, that's enough jibber jabber, it's time to entertain me Jester.~2";
            round1[14] = "Oh and by entertain I mean fight my gladiators.~2";
            round1[15] = "WAIT WHAT!?~1";
            round1[16] = "Good luck! You'll need it.~2";

            #endregion

            #region round5

            round5[0] = "I'm honestly really impressed!~2";
            round5[1] = "You're not dead yet! Well done!~2";
            round5[2] = "Thanks??~1";
            round5[3] = "Did I win yet? Can I leave?~1";
            round5[4] = "NOPE!~2";
            round5[5] = "I think it's about time you met one of my more powerful weapons, a literal walking railgun.~2";
            round5[6] = "You've gotta be kidding me~1";

            #endregion

            #region round20

            round20[0] = "WHEN CAN I LEAVE THIS GOD FORSAKEN PLACE!~1";
            round20[1] = "Oh but why would I let you leave? You've been so entertaining!~2";
            round20[2] = "I think I'd like to call for an encore!~2";
            round20[3] = "One FINAL encore.~2";
            round20[4] = "Excuse me?~1";
            round20[5] = "It's been entertaining watching you but I think its about time you take your final bow.~1";
            round20[6] = "Like im gonna let that happen!~1";
            round20[7] = "You don't get a say in the matter!~3";

            #endregion

            #region round30

            round30[0] = "YOU BRAZEN, INSOLENT PIECE OF SCRAP!~3";
            round30[1] = "WHY WON'T YOU JUST DIE ALREADY!~3";
            round30[2] = "Hmmmmmm.....~1";
            round30[3] = "Maybe all the spare parts I've been harvesting from your so called \"more powerful weapons\"~1";
            round30[4] = "THATS IT.~3";
            round30[5] = "I'VE HAD ENOUGH OF YOUR ACT!~3";
            round30[6] = "IF YOU WANT SOMETHING DONE I GUESS YOU JUST HAVE TO DO IT YOURSELF!~3";
            round30[7] = "Since this is your final performance I suppose I should help you a litle, call it severance pay.~2";
            round30[8] = "I don't particularly like fighting, so I use my minions to attack, this shield won't break unless they are all deafeated.~2";
            round30[9] = "Ha ha, you're gonna regret telling me that!~1";
            round30[10] = "HA! Unlikely!~2";

            #endregion

            #region MidBossFight

            midBossFight[0] = "WHY WONT YOU DIE!~3";
            midBossFight[1] = "I'LL TEAR YOU APART WITH MY OWN 2 HANDS!~3";
            midBossFight[2] = "GOOD LUCK HIDING BEHIND THESE WALLS!~3";
            midBossFight[3] = "THEY MEAN NOTHING TO ME!~3";

            #endregion

            #region GameFinish

            gameFinish[0] = "NO!~3";
            gameFinish[1] = "I REFUSE THIS OUTCOME!~3";
            gameFinish[2] = "THIS.~3";
            gameFinish[3] = "IS.~3";
            gameFinish[4] = "NOT.~3";
            gameFinish[5] = "HAPPENING.~3";
            gameFinish[6] = "THIS CANNOT HAPPEN!~3";
            gameFinish[7] = "Tough.~1";

            #endregion

            #endregion

            this.user = user;
            roundStart = true; //Allows enemies to be spawned

            rectScreen = new Rectangle(10, 10, this.Width - 40, this.Height);


            healthPickup = new Rectangle[] //Setting the rectangles for the health pickups
                {
                new Rectangle(8000, 8000, 50, 25),
                new Rectangle(8000, 8000, 50, 25),
                new Rectangle(8000, 8000, 50, 25),
                new Rectangle(8000, 8000, 50, 25),
                new Rectangle(8000, 8000, 50, 25)
                };

            healthAddition = new Rectangle(8000, 8000, 50, 25); //Setting the variable for the health pickup at the end of aminiboss round that adds health

            rectWalls = new Rectangle[] //Setting the rectangles of the walls
            {
                new Rectangle(1, 659, 730, 203),
                new Rectangle(727, 659, 144, 47),
                new Rectangle(1001, 659, 220, 47),
                new Rectangle(1167, 268, 54, 394),
                new Rectangle(1218, 411, 220, 47),
                new Rectangle(640, 321, 530, 58),
                new Rectangle(1167, -2, 54, 168),
                new Rectangle(298, 109, 459, 57),
                new Rectangle(298, 162, 52, 362)
            };

            if ((user.Weapon == "SMG") || (user.Weapon == "SHOTGUN")) //Setting the reload box image to the default, the sword does not need one as it does not relaod so the box is kept empty for it
            {
                reloadBox.Image = Properties.Resources.Reload;
            }

            for (int i = 0; i < 10; i++) //Setting the bool used to determine if a spawn point has been used in a round so enemies dont spawn on eachother
            {
                pointUsed[i] = false;
            }

            spawnPoint = new Point[] //Setting the spawn points the enemies can spawn at
            {
                new Point(1202, 716),
                new Point(112, 451),
                new Point(487, 354),
                new Point(991, 83),
                new Point(913, 777),
                new Point(1001, 495),
                new Point(1448, 513),
                new Point(1448, 710),
                new Point(1419, 151),
                new Point(598, 513)
               };
            #endregion

            #region PlayerCode
            this.user = user;

            if (user.Weapon != "SWORD") //If its the smg or shotgun create 20 weapon objects
            {
                myClip = new Weapon[20];
            }
            else //If its the sword create 2
            {
                myClip = new Weapon[2];
            }

            if (user.Weapon != "SWORD") //The sword works differently to the other 2 and does not need a clipcount of 19
            {
                clipCount = 19;
            }
            else clipCount = 1;

            switch (user.Character) //Setting the character variable so that it can be passed into the score text file if a high score is acheived
            {
                case (0): character = "SMG"; break;
                case (1): character = "SHOTGUN"; break;
                case (2): character = "SWORD"; break;
            }

            if (user.Weapon == "SMG") //Setting the health depending on the character
            {
                maxHealth = 3;
            }
            else if (user.Weapon == "SHOTGUN")
            {
                maxHealth = 4;
            }
            else //Sword
            {
                maxHealth = 5;
            }

            currentHealth = maxHealth; //Current health is the health that the player has at any given time and max health is the maximum that health can be healed to
            // by setting current health to max it means the player starts with 3, 4 or 5 depending on their character

            healthRect = new Rectangle[] //Setting the rectangles for the health icons in the bottom left that signify how many more hits the player can take
            {
                new Rectangle(223, 710, 50, 25),
                new Rectangle(279, 710, 50, 25),
                new Rectangle(335, 710, 50, 25),
                new Rectangle(391, 710, 50, 25),
                new Rectangle(447, 710, 50, 25),
                new Rectangle(223, 741, 50, 25),
                new Rectangle(279, 741, 50, 25),
                new Rectangle(335, 741, 50, 25),
                new Rectangle(391, 741, 50, 25),
                new Rectangle(447, 741, 50, 25)
            };

            rectPlayer = new Rectangle(5, 5, 50, 50); //Setting the initial spawn of the player when they start at round 1


            if (user.Weapon != "SWORD")
            {
                rectBullet = new Rectangle[20]; //Creating the rectangles for the players projectiles
            }
            else
            {
                rectBullet = new Rectangle[2];
            }

            if (user.Weapon != "SWORD") //The sword works differentely and does not need more than a few projectiles as only one sword projectile is on the screen at once from an enemy or player
            {
                projectileNum = 20;
            }
            else projectileNum = 2;

            if (user.Weapon == "SMG") //Setting the rectangle for each player projectile depending on what character they chose
            {
                for (int i = 0; i < projectileNum; i++)
                {
                    rectBullet[i] = new Rectangle(3000, 3000, 25, 25);
                }
            }
            else if (user.Weapon == "SHOTGUN")
            {
                for (int i = 0; i < projectileNum; i++)
                {
                    rectBullet[i] = new Rectangle(3000, 3000, 10, 10);
                }
            }
            else //Sword
            {
                rectBullet[0] = new Rectangle(3000, 3000, 25, 50);
            }

            for (int i = 0; i < projectileNum; i++) //Creating the objects that store variables that are used to control the bullet rectangles
            {
                myClip[i] = new Weapon(true, user.Weapon);
            }

            #endregion

            #region EnemyCode

            rectEnemy = new Rectangle[6]; //Creating the rectangles that are used by the enemies

            for (int i = 0; i < 6; i++)
            {
                rectEnemy[i] = new Rectangle(5000, 5000, 50, 50); //Giving the enemy rectangles values
            }

            for (int i = 0; i < 6; i++)
            {
                myEnemy[i] = new Enemy(rnd.Next(1, 4)); //Creating the enemy object using a random num between 1 and 3 for the 3 different regular enemy varietys
            }

            enemyRectBul = new Rectangle[6, 20]; //Setting the 3d array up so that there are 6 sets of 20 rectangles for the 6 enemies and their 20 potential projectiles

            for (int i = 0; i < 6; i++)
            {

                myEnemy[i].ProjectileNum = 20;

                if (myEnemy[i].Type == 1) //Setting the rectangles of the enemies projectiles based on what type they are
                {
                    for (int j = 0; j < 20; j++)
                    {
                        enemyRectBul[i, j] = new Rectangle(3000, 3000, 25, 25);
                    }
                }
                else if (myEnemy[i].Type == 2)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        enemyRectBul[i, j] = new Rectangle(3000, 3000, 10, 10);
                    }
                }
                else //Type 3
                {
                    for (int j = 0; j < 20; j++)
                    {
                        enemyRectBul[i, j] = new Rectangle(3000, 3000, 25, 50);
                    }
                }
            }
            #endregion

            #region MiniBoss
            rectMiniBoss = new Rectangle(5000, 5000, 100, 100); //Setting the rectangle for the mini boss
            rectMiniBossClip = new Rectangle[20]; //Creating the rectangles for mini bosses projectiles

            for (int i = 0; i < 20; i++) //Setting the rectangles for the mini bosses projectiles
            {
                rectMiniBossClip[i] = new Rectangle(9000, 9000, 100, 50);
            }
            miniBoss.ProjectileNum = 20;
            #endregion

            #region Boss
            rectBoss = new Rectangle(5000, 5000, 50, 50); //Setting the rectangle for the boss enemy
            boss = new Enemy(5); //Creating the enemy object for the boss enemy

            #endregion

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            #region Misc           

            foreach (Rectangle r in healthPickup) //Drawing the battery image onto each health pickup rectangle
            {
                g.DrawImage(Properties.Resources.Battery, r);
            }

            foreach (Rectangle r in rectWalls) //Drawing either the vertical or horizontal wall image onto the wall rectangles depending on their width and height
            {
                if (r.Width > r.Height)
                {
                    g.DrawImage(Properties.Resources.ScrapWallHorizontal, r);
                }
                else g.DrawImage(Properties.Resources.ScrapWallVertical, r);
            }

            g.DrawImage(Properties.Resources.Battery, healthAddition); //Drawing the battery image onto the health addition rectangle

            g.DrawImage(Properties.Resources.HealthAndAmmo, rectHealthAndAmmo); //Drawing the UI base image for the health and ammo onto its rectangle

            for (int i = 0; i < currentHealth; i++) //Drawing the battery image onto each health rectangle in the bottom left 
            {
                g.DrawImage(Properties.Resources.Battery, healthRect[i]);
            }
            #endregion

            #region Player

            playerPoint = new Point(rectPlayer.X + 25, rectPlayer.Y + 25); //Sets player point to the centre of the player which allows for angles to be calculated
            g.DrawImage(RotateImage(user.BMP, (float)GetAngleBetweenObjects(playerPoint, Cursor.Position), true), rectPlayer);
            //draws the users BMP after it is rotated based on the angle between the player and the mouse cursor and which character the user is

            for (int i = 0; i < projectileNum; i++) //If a players projecile is in motion then it will be drawn with its BMP depending on what character was selected
            {
                if (myClip[i].Move)
                {
                    g.DrawImage(myClip[i].BMP, rectBullet[i]);
                }
            }

            #endregion

            #region Enemy 

            for (int i = 0; i < 6; i++)
            {
                if (myEnemy[i].EnemyActive) //If an enemuy is on the screen then the enemy image will be drawn depending on which character is chosen and the angle between the enemy and the player
                {
                    myEnemy[i].EnemyPoint = new Point(rectEnemy[i].X + 25, rectEnemy[i].Y + 25);
                    g.DrawImage(RotateImage(myEnemy[i].BMP, (float)GetAngleBetweenObjects(myEnemy[i].EnemyPoint, playerPoint), true), rectEnemy[i]);
                }

                for (int j = 0; j < myEnemy[i].ProjectileNum; j++) //If an enemies projectile is in motion than it will be drawn with the appropriate BMP depending on what character is selected
                {
                    if (myEnemy[i].EnemyClip[j].Move)
                    {
                        g.DrawImage(myEnemy[i].EnemyClip[j].BMP, enemyRectBul[i, j]);
                    }
                }
            }

            #endregion

            #region MiniBoss

            if (miniBoss.EnemyActive) //If the miniboss is on the screen that its BMP will be drawn depending on the angle between the mini boss and the player
            {
                miniBoss.EnemyPoint = new Point(rectMiniBoss.X + 50, rectMiniBoss.Y + 50);
                g.DrawImage(RotateImage(miniBoss.BMP, (float)GetAngleBetweenObjects(miniBoss.EnemyPoint, playerPoint), true), rectMiniBoss);
            }

            for (int i = 0; i < miniBoss.ProjectileNum; i++) //If the mini bosses projectile is in motion then its BMP will be drawn
            {
                if (miniBoss.EnemyClip[i].Move)
                {
                    g.DrawImage(miniBoss.EnemyClip[i].BMP, rectMiniBossClip[i]);
                }
            }
            #endregion

            #region Boss
            if (roundCounter == 30) //If it is the boss round then the boss will be drawn depending on the angle between the boss and the player and whether or not the boss is shielded
            {
                boss.EnemyPoint = new Point(rectBoss.X + 25, rectBoss.Y + 25);
                if (shielded)
                {
                    boss.OgBMP = CyberScrap.Properties.Resources.BossSheildedGameplay;
                }
                else boss.OgBMP = CyberScrap.Properties.Resources.BossGameplay;
                g.DrawImage(RotateImage(boss.OgBMP, (float)GetAngleBetweenObjects(boss.EnemyPoint, playerPoint), true), rectBoss);
            }
            #endregion            

            #region Dialogue
            if (gameState == "Dialogue")
            {
                if (dialogueLineNum == 0) //For the start of the game / round so that dialogueBox variable is not null depending on which character starts the dialogue and what character is chosen by the player
                {
                    switch (roundCounter)
                    {
                        case 1:
                            switch (user.Weapon)
                            {
                                case "SMG": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh1; break;
                                case "SHOTGUN": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh2; break;
                                case "SWORD": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh3; break;
                            }
                            break;
                        case 5:
                            dialogueBox = CyberScrap.Properties.Resources.BossNeutralDialogue;
                            break;
                        case 20:
                            switch (user.Weapon)
                            {
                                case "SMG": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh1; break;
                                case "SHOTGUN": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh2; break;
                                case "SWORD": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh3; break;
                            }
                            break;
                        case 30:
                            dialogueBox = CyberScrap.Properties.Resources.BossAngryDialogue;
                            break;
                    }
                }
                g.DrawImage(dialogueBox, rectBox); //If the game state is dialogue this always runs so that the the dialoguebox is correct based on
            }                                      //the character speaking                                                                                                     
            #endregion
        }

        #region KeyAndMouseEvents
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) //If a key is pressed than the corresponding bool is set to true so that the code associated with that key press can be ran
            {
                case Keys.A: left = true; break;
                case Keys.W: up = true; ; break;
                case Keys.S: down = true; break;
                case Keys.D: right = true; break;
                case Keys.Space: space = true; break;
                case Keys.R: reload = true; break;
                case Keys.Escape:
                    if (gameState == "Game")
                    {
                        gameState = "Pause";
                    }
                    else if (gameState == "Pause") //if escape is hit when the game is already paused, then unpause it
                    {
                        gameState = "Game";
                        pauseBackground.Visible = false;
                        mainMenuBtn.Visible = false;
                        quitBtn.Visible = false;
                    }
                    break;
                case Keys.Z: dialogueLineNum = endLine; break; //Skips the dialogue
            }
            e.Handled = true; //Stops an issue where when an action is made a ding noise plays
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) //Sets the previously mentioned bools to false so that the code stops playing when the key is released
            {
                case Keys.A: left = false; break;
                case Keys.W: up = false; break;
                case Keys.S: down = false; break;
                case Keys.D: right = false; break;
                case Keys.Space: space = false; break;
                case Keys.R: reload = false; break;
            }
            e.Handled = true;//Stops an issue where when an action is made a ding noise plays
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) //When the player clicks the mnouse the shoot bool is set to true for the shoot code to work
        {
            shoot = true;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e) //Sets the previously mentioned bool to false so that the code stops playing when the mouse is released
        {
            shoot = false;
        }

        private void label5_Click(object sender, EventArgs e) //Skips to the end of the current piece of dialogue when the dialogue label is clicked
        {
            if (dialogueLetterNum < currentLine[0].Length - 1)
            {
                dialogueLetterNum = currentLine[0].Length - 1;
            }
        }

        private void mainMenuBtn_Click_1(object sender, EventArgs e) //Open the main menu and stop the music so that it doesn't overlap with the main menu music
        {
            //buttonNoisePlayer.Ctlcontrols.play();
            //mainThemePlayer.settings.playCount = 0;
            //mainThemePlayer.Ctlcontrols.stop();
            MainMenu mainmenu = new MainMenu(user);
            this.Hide();
            mainmenu.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e) //Quit the game
        {
            Environment.Exit(0);
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (gameState)
            {
                case "Dialogue":
                    #region Dialogue
                    //Sets the needed variables to allow the dialogue to play such as slowing the timer tick to allow text to scroll slower, showing the skip button and showing the dialogue box
                    gameTimer.Interval = 30;
                    CharacterDialogueLbl.Visible = true;
                    infoLbl.Visible = true;

                    if (dialogueLineNum < endLine)
                    {
                        switch (roundCounter) //Sets the first line of dialogue to be played based on the current round and sets the endline so that the code knows when it has hit the final line of that dialogue section
                        {
                            case 1:
                                currentLine = round1[dialogueLineNum].Split('~');
                                endLine = round1.Length;
                                break;
                            case 5:
                                currentLine = round5[dialogueLineNum].Split('~');
                                endLine = round5.Length;
                                break;
                            case 20:
                                currentLine = round20[dialogueLineNum].Split('~');
                                endLine = round20.Length;
                                break;
                            case 30:
                                currentLine = round30[dialogueLineNum].Split('~');
                                endLine = round30.Length;
                                break;
                        }

                        switch (bossStage) //Works the same as the last piece of code but for the boss stages that are within round 30
                        {
                            case 3:
                                currentLine = midBossFight[dialogueLineNum].Split('~');
                                endLine = midBossFight.Length;
                                break;
                            case 4:
                                currentLine = gameFinish[dialogueLineNum].Split('~');
                                endLine = gameFinish.Length;
                                break;
                        }
                    }

                    if (dialogueLetterNum < currentLine[0].Length + 1 && textDelay <= 0)
                    //If there is no text delay which is there to allow finished lines to stay on the screen after they have finished for a small while to allow the player to read them
                    //and the line that is currently being written has not finished then write the next letter of the line into the textbox and change the image to match the character that is speaking
                    {
                        CharacterDialogueLbl.Text = currentLine[0].Substring(0, dialogueLetterNum);
                        dialogueLetterNum++;
                        switch (currentLine[1])
                        {
                            case "1":
                                switch (user.Weapon)
                                {
                                    case "SMG": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh1; break;
                                    case "SHOGTUN": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh2; break;
                                    case "SWORD": dialogueBox = CyberScrap.Properties.Resources.DialogueBoxCh3; break;
                                }
                                break;

                            case "2":
                                dialogueBox = CyberScrap.Properties.Resources.BossNeutralDialogue;
                                break;

                            case "3":
                                dialogueBox = CyberScrap.Properties.Resources.BossAngryDialogue;
                                break;
                        }

                    }
                    else if (dialogueLetterNum > currentLine[0].Length) //If the line that is being written has finished then move on to the next line and increase text delay to let the player read the current line before moving on
                    {
                        dialogueLineNum++;
                        dialogueLetterNum = 0;
                        textDelay = 20;
                    }
                    else textDelay--; //If the next line is waiting to be written because there is text delay then decrease it by 1 for each tick untill it hits zero and the next line is displayed

                    if (dialogueLineNum == endLine && textDelay == 0) //If the final line of the dialogue for the round has been played then move onto the next game state
                    // which is either the end state with the condition that the player has won the game or the gameplay state where the next round is started
                    {
                        if (bossStage == 4)
                        {
                            gameWin = true;
                            gameState = "End";
                        }
                        else
                        {
                            gameState = "Game";
                        }

                        endLine = 1; //The endline is set to one and the dialogue line num to 0 so that the next time the dialogue code an if statement is triggered to set the endline and current line values
                        dialogueLineNum = 0;

                        //The skip button and dialogue label are hidden
                        CharacterDialogueLbl.Visible = false;
                        infoLbl.Visible = false;
                        CharacterDialogueLbl.Text = "";
                        gameTimer.Interval = 100;
                    }
                    #endregion
                    break;

                case "Game":
                    #region Rounds

                    if (roundStart && roundDelay <= 0) //If there is no round delay and the round has been started
                    {
                        #region roundBox Images
                        switch (roundCounter)
                        {
                            case 1: roundBox.Image = Properties.Resources.Round_1; break;
                            case 2: roundBox.Image = Properties.Resources.Round_2; break;
                            case 3: roundBox.Image = Properties.Resources.Round_3; break;
                            case 4: roundBox.Image = Properties.Resources.Round_4; break;
                            case 5: roundBox.Image = Properties.Resources.Round_5; break;
                            case 6: roundBox.Image = Properties.Resources.Round_6; break;
                            case 7: roundBox.Image = Properties.Resources.Round_7; break;
                            case 8: roundBox.Image = Properties.Resources.Round_8; break;
                            case 9: roundBox.Image = Properties.Resources.Round_9; break;
                            case 10: roundBox.Image = Properties.Resources.Round_10; break;
                            case 11: roundBox.Image = Properties.Resources.Round_11; break;
                            case 12: roundBox.Image = Properties.Resources.Round_12; break;
                            case 13: roundBox.Image = Properties.Resources.Round_13; break;
                            case 14: roundBox.Image = Properties.Resources.Round_14; break;
                            case 15: roundBox.Image = Properties.Resources.Round_15; break;
                            case 16: roundBox.Image = Properties.Resources.Round_16; break;
                            case 17: roundBox.Image = Properties.Resources.Round_17; break;
                            case 18: roundBox.Image = Properties.Resources.Round_18; break;
                            case 19: roundBox.Image = Properties.Resources.Round_19; break;
                            case 20: roundBox.Image = Properties.Resources.Round_20; break;
                            case 21: roundBox.Image = Properties.Resources.Round_21; break;
                            case 22: roundBox.Image = Properties.Resources.Round_22; break;
                            case 23: roundBox.Image = Properties.Resources.Round_23; break;
                            case 24: roundBox.Image = Properties.Resources.Round_24; break;
                            case 25: roundBox.Image = Properties.Resources.Round_25; break;
                            case 26: roundBox.Image = Properties.Resources.Round_26; break;
                            case 27: roundBox.Image = Properties.Resources.Round_27; break;
                            case 28: roundBox.Image = Properties.Resources.Round_28; break;
                            case 29: roundBox.Image = Properties.Resources.Round_29; break;
                            case 30: roundBox.Image = Properties.Resources.Round_30; break;
                        }
                        #endregion

                        if (roundCounter == 30) //If its the boss round then spawn the boss and 6 enemies
                        {
                            spawnAmount = 6;
                            if (!boss.EnemyActive) //Because there are several boss stages so the round 30 code repears several times
                                if (bossStage == 1)    //this is here so the boss doesnt get a new spawn everytime
                                {
                                    boss.EnemyActive = true; //Set the boss to true and then spawn him in a random location 
                                                             //then set a corresponding bool for that location so that other enemies dont spawn in the same place
                                    randSpawn = rnd.Next(0, 10);
                                    rectBoss.Location = spawnPoint[randSpawn];
                                    pointUsed[randSpawn] = true;
                                }
                            shielded = true; //Set the boss to shielded so that he cant be attacked

                            for (int i = 0; i < 6; i++) //For each enemy spawn them in a random location and set them to active
                            {
                                randSpawn = rnd.Next(0, 10);
                                while (pointUsed[randSpawn])
                                {
                                    randSpawn = rnd.Next(0, 10);
                                }
                                pointUsed[randSpawn] = true;
                                rectEnemy[i].Location = spawnPoint[randSpawn];
                                previousSpawns[i] = randSpawn;
                                myEnemy[i].EnemyActive = true;
                                roundStart = false; //Set round start to false so that it stops playing the round start code
                            }

                            for (int i = 0; i < 10; i++)
                            {
                                pointUsed[i] = false; //Resets the points used so that they are available to be used the next round start cycle
                            }
                        }
                        else if (roundCounter % 5 == 0) //If the round is divisible by 5 i.e round 5, 10, 15, 20, 25 but NOT 30
                        {
                            randSpawn = rnd.Next(0, 10); //Spawn the miniboss in a random location and set him to active
                            miniBoss.BulDelay = 20;
                            rectMiniBoss.Location = spawnPoint[randSpawn];
                            //railgunChargePlayer.Ctlcontrols.play();
                            miniBoss.EnemyActive = true;
                            spawnAmount = 1;
                            roundStart = false;
                        }
                        else //Every other round i.e 1,2,3,4,NOT 5  6,7,8,9,NOT 10    11,12,13,14, NOT 15   16,17,18,19, NOT 20    
                             //21,22,23,24, NOT 25   26,27,27,28,29 NOT 30
                        {
                            if (roundCounter <= 6) //Checks the roundcounter so if it is equal or less than 6, the enemies spawned = the roundcounter
                            {
                                spawnAmount = roundCounter;
                            }
                            else spawnAmount = 6; //If its above 6 then the 6 enemies will be spawned, 6 was chosen as to reduce lag as much as possible

                            for (int i = 0; i < spawnAmount; i++) //For however many the spawn amount is, spawn the enemies in a random location and set them to active
                            {
                                randSpawn = rnd.Next(0, 10);
                                for (int j = 0; j < 10; j++)
                                {
                                    if (randSpawn == previousSpawns[j])
                                    {
                                        randSpawn = rnd.Next(0, 10);
                                    }
                                    else j = 10;
                                }
                                rectEnemy[i].Location = spawnPoint[randSpawn];
                                previousSpawns[i] = randSpawn;
                                myEnemy[i].EnemyActive = true;
                            }
                            roundStart = false; //Set round start to false so the round start code does not repeat
                        }
                    }
                    else roundDelay--; //Takes away from rounddelay so that there is a gap inbetween rounds 

                    if ((deadCounter == spawnAmount) && !boss.EnemyActive) //If all the enemies have been killed and there is no boss on the screen
                    {
                        roundStart = true; //Set roundstart to true so a new round can be started, reset the dead counter and increase the round counter
                        deadCounter = 0;
                        roundDelay = 10;
                        roundCounter++;
                        if (roundCounter == 5 || roundCounter == 20 || roundCounter == 30 || bossStage == 3 || bossStage == 4)
                        {
                            gameState = "Dialogue"; //if its any of these round then set the state to dialogue so the dialogue can be played
                        }
                    }
                    else if ((deadCounter == spawnAmount) && boss.EnemyActive) //If all the enemies have been killed but the boss is alive
                    {
                        roundStart = true; //Restart the round 
                        shielded = false;
                        roundDelay = 100;
                        deadCounter = 0;
                        if (roundCounter == 5 || roundCounter == 20 || roundCounter == 30 || bossStage == 3 || bossStage == 4)
                        {
                            gameState = "Dialogue"; //if its any of these then set the state to dialogue so the dialogue can be played
                        }
                    }
                    #endregion

                    PlayerTickCode(); //Run the player code

                    EnemyTickCode(); //Run the enemy code

                    MiniBossTickCode(); //Run the mini boss code

                    BossTickCode(); //run the boss code

                    iFrames--; //I frames give the player temporary immunity after being hit so this decreases it for every tick to ensure a player isnt always invunerable

                    if (currentHealth <= 0) //If the player reaches 0 health i.e dies, then start the end game state without setting game win to true
                    {
                        gameState = "End";
                    }

                    break;

                case "Pause":
                    mainMenuBtn.Visible = true;
                    quitBtn.Visible = true;
                    pauseBackground.Visible = true;
                    break;

                case "End":
                    #region EndOfGame
                    gameTimer.Stop(); //Stop the timer so that the code does not keep playing
                    try
                    {
                        users = File.ReadAllLines("userScore.txt");  //Convert the userScore file into an array of strings
                    }
                    catch
                    {
                        MessageBox.Show("There was an error with the user score file");
                    }
                    int lineNum = 0;
                    foreach (string s in users) //For each string in the array split it into user name and score
                    {
                        string[] allUserScore = s.Split('~');
                        string[] scoreAndChar = allUserScore[1].Split('.');
                        if (allUserScore[0] == user.Username) //if a string with the same name as the current user is found
                        {
                            if (score > Int32.Parse(scoreAndChar[0])) //check if the new score is higher than the old one
                            {
                                users[lineNum] = (allUserScore[0] + '~' + score + '.' + character); //Change the line where the user was found with the new details
                                File.WriteAllLines("userScore.txt", users); //Write thie string of arrays back to file with the edited line
                            }
                        }
                        lineNum++; //Increment lineNum so that the next line can be checked 
                    }

                    if (gameWin) //If the end game state was started with the game win variable set as true, i.e the user beat the game
                    {
                        //mainThemePlayer.settings.playCount = 0;
                        //mainThemePlayer.Ctlcontrols.stop();
                        var proepi = new Prologue_Epilogue(user, "Epilogue", true, score); //Open the Prologue Epilogue screen in the epilogue state
                        this.Hide();
                        proepi.Show();
                    }
                    else ////If the end game state was started with the game win variable set as false, i.e the user died
                    {
                        //mainThemePlayer.settings.playCount = 0;
                        //mainThemePlayer.Ctlcontrols.stop();
                        var winlose = new GameWinLose(user, false, score); //Open the game win lose screen in the lose state
                        this.Hide();
                        winlose.Show();
                    }
                    #endregion
                    break;

            }
            Invalidate();
        }

        #region TimerMethods
        public void EnemyTickCode()
        {
            #region EnemyCode
            for (int i = 0; i < 6; i++) //Run the code for all 6 enemies
            {
                if (myEnemy[i].EnemyActive) //Checks if the enmy is active so that the code is not ran when it does not need to be
                {
                    #region EnemyMovement
                    //Find the difference in the player and enemy X and if its a negative make it apositive
                    myEnemy[i].PlayerDistanceX = rectPlayer.X - rectEnemy[i].X;

                    if (myEnemy[i].PlayerDistanceX < 0)
                    {
                        myEnemy[i].PlayerDistanceX *= -1;
                    }

                    //Find the difference in the player and enemy Y and if its a negative make it apositive
                    myEnemy[i].PlayerDistanceY = rectPlayer.Y - rectEnemy[i].Y;

                    if (myEnemy[i].PlayerDistanceY < 0)
                    {
                        myEnemy[i].PlayerDistanceY *= -1;
                    }

                    //Calculate the enemies angle and the X and Y they need to move at to go in the direction of the player
                    myEnemy[i].Angle = (float)GetAngleBetweenObjects(rectEnemy[i].Location, rectPlayer.Location);
                    enemyRadians = myEnemy[i].Angle * (Math.PI / 180); // Convert angle to radians
                    enemyX = myEnemy[i].Speed * Math.Cos(enemyRadians);
                    enemyY = myEnemy[i].Speed * Math.Sin(enemyRadians);
                    myEnemy[i].X = (int)enemyX;
                    myEnemy[i].Y = (int)enemyY;

                    switch (myEnemy[i].Type) //Depending on the enemy type then there is a different shot distance, which determines how close the enemy will get to the player
                    {
                        case 1: shotDistanceX = 400; shotDistanceY = 300; break;
                        case 2: shotDistanceX = 300; shotDistanceY = 200; break;
                        case 3: shotDistanceX = 50; shotDistanceY = 50; break;
                    }

                    if (myEnemy[i].PlayerDistanceX > shotDistanceX) //If the enemy is far enough away in terms of X, increment X by the value calculated above
                    {
                        rectEnemy[i].X += myEnemy[i].X;
                    }

                    foreach (Rectangle r in rectWalls) //After the movement happens check if an intersection with a wall happened If so, undo that movement
                    {
                        if (rectEnemy[i].IntersectsWith(r) || rectEnemy[i].X < 0 || rectEnemy[i].X > 1620 || rectEnemy[i].Y > 900 || rectEnemy[i].Y < 0)
                        {
                            rectEnemy[i].X -= myEnemy[i].X;
                        }
                    }

                    if (myEnemy[i].PlayerDistanceY > shotDistanceY)  //If the enemy is far enough away in terms of Y, increment Y by the value calculated above
                    {
                        rectEnemy[i].Y += myEnemy[i].Y;
                    }

                    foreach (Rectangle r in rectWalls) //After the movement happens check if an intersection with a wall or the edge of the screen happened
                                                       //If so, undo that movement
                    {
                        if (rectEnemy[i].IntersectsWith(r) || rectEnemy[i].X < 0 || rectEnemy[i].X > 1620 || rectEnemy[i].Y > 900 || rectEnemy[i].Y < 0)
                        {
                            rectEnemy[i].Y -= myEnemy[i].Y;
                        }
                    }
                    #endregion

                    #region EnemyShooting
                    if (myEnemy[i].BulDelay <= 0) //If there is no bullet delay
                    {
                        if (myEnemy[i].Type == 1) //If the enemy has the SMG weapon
                        {
                            enemyRectBul[i, myEnemy[i].ClipCount].Location = new Point(rectEnemy[i].X, rectEnemy[i].Y);
                            //Set the location of the current enemies current bullet to the enemys X and Y

                            rotateAngle = (float)GetAngleBetweenObjects(myEnemy[i].EnemyPoint, playerPoint);
                            //Set rotate angle to the angle between the enemy and the player

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].BMP = RotateImage(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].OgBMP, rotateAngle, false);
                            //Set the current enemies current bullets BMP to a rotated version of the BMP using the angle just calculated

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Angle = rotateAngle;
                            //Set the angle at which the enemy has to rotate to the rotate angle just calculated

                            enemyBulRadians = rotateAngle * (Math.PI / 180);
                            //Set the radians using the rotate angle

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].X = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Cos(enemyBulRadians));
                            //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Y = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Sin(enemyBulRadians));
                            //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Move = true;  //Set the bullets move bool to true so that the next piece of code can move the bullet
                            myEnemy[i].BulDelay = 16; //Set the bullet delay to 16 so that the enemy can't shoot constantly
                            myEnemy[i].ClipCount--; //Take away from the clipcount so the next bullet in the clips code can be ran
                        }
                        else if (myEnemy[i].Type == 2) //If the enemy has the shotgun weapon
                        {
                            rotateAngle = (float)GetAngleBetweenObjects(myEnemy[i].EnemyPoint, playerPoint); //Set the initial rotate angle
                            for (int j = 0; j < 5; j++) //Repeat the code times for each pellet that fires after one shot
                            {
                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Angle = rotateAngle;
                                //Set the angle to rotate angle just calculated

                                enemyRectBul[i, myEnemy[i].ClipCount].Location = new Point(rectEnemy[i].X, rectEnemy[i].Y);
                                //Set the current enemies current bullet to the the enemies X and Y

                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].BMP = (RotateImage(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].OgBMP, (float)GetAngleBetweenObjects(myEnemy[i].EnemyPoint, playerPoint), false));
                                //Set the current enemies currents bullets BMP to the orignal BMP rotated based on the angle between the enemy and the player

                                enemyBulRadians = rotateAngle * (Math.PI / 180);
                                //Set the radians using the rotate angle

                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].X = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Cos(enemyBulRadians));
                                //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Y = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Sin(enemyBulRadians));
                                //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Move = true;  //Set the bullets move bool to true so that the next piece of code can move the bullet
                                rotateAngle += 3; //Increment the rotate angle so that the next pellet shot is at a different angle, creating a row of them
                                myEnemy[i].ClipCount--; //Take away from the clipcount so the next bullet in the clips code can be ran
                                myEnemy[i].BulDelay = 32; //Set the bullet delay to 16 so that the enemy can't shoot constantly
                            }
                        }
                        else //If enemy weapon is the sword
                        {
                            enemyRectBul[i, myEnemy[i].ClipCount].Location = new Point(rectEnemy[i].X, rectEnemy[i].Y);
                            //Set the location of the current enemies current bullet to the enemys X and Y

                            rotateAngle = (float)GetAngleBetweenObjects(myEnemy[i].EnemyPoint, playerPoint);
                            //Set rotate angle to the angle between the enemy and the player

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].BMP = RotateImage(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].OgBMP, rotateAngle, false);
                            //Set the current enemies current bullets BMP to a rotated version of the BMP using the angle just calculated

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Angle = rotateAngle;
                            //Set the angle at which the enemy has to rotate to the rotate angle just calculated

                            enemyBulRadians = rotateAngle * (Math.PI / 180);
                            //Set the radians using the rotate angle

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].X = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Cos(enemyBulRadians));
                            //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Y = (int)(myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Speed * Math.Sin(enemyBulRadians));
                            //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Move = true;  //Set the bullets move bool to true so that the next piece of code can move the bullet
                            myEnemy[i].BulDelay = 5; //Set the bullet delay to 16 so that the enemy can't shoot constantly
                            myEnemy[i].ClipCount--; //Take away from the clipcount so the next bullet in the clips code can be 
                        }

                    }
                    myEnemy[i].BulDelay--; //Take away one from the bullet delay if its > 0 

                    if (myEnemy[i].ClipCount <= 0) //If the last bullet in the "clip" is shot reset it 19,                                                
                    {                       //this doesn't mean the enemys have a limit it just exists to reset so that the enemies can always shoot
                        myEnemy[i].ClipCount = 19;
                    }

                    #endregion
                }
            }

            for (int i = 0; i < 6; i++) //For every enemy
            {
                for (int j = 0; j < myEnemy[i].ProjectileNum; j++) //For the every bullet of the current enemy
                {
                    if (myEnemy[i].EnemyClip[j].Move) //If the bullet is moving
                    {
                        #region EnemyBulletMovement
                        if (myEnemy[i].Type == 3) //If the enemy is the sword character then increment until the buldelay hits 1
                        {                         //There is a tick where the bullet is not moving but still visible which is intentional
                            if (myEnemy[i].BulDelay > 1)
                            {
                                enemyRectBul[i, j].X += myEnemy[i].EnemyClip[j].X / 4;
                                enemyRectBul[i, j].Y += myEnemy[i].EnemyClip[j].Y / 4;
                            }
                            else if (myEnemy[i].BulDelay == 0) //When the buldelay hits 0 take it off the screen and set its move condition to false
                            {
                                enemyRectBul[i, j].Location = new Point(3000, 3000);
                                myEnemy[i].EnemyClip[myEnemy[i].ClipCount].Move = false;
                            }
                        }
                        else //If its the sword or SMG character just increment it no matter
                        {
                            enemyRectBul[i, j].X += myEnemy[i].EnemyClip[j].X / 2;
                            enemyRectBul[i, j].Y += myEnemy[i].EnemyClip[j].Y / 2;
                        }
                        #endregion

                        #region EnemyBulletCollision

                        foreach (Rectangle w in rectWalls) //For each wall
                        {
                            if (enemyRectBul[i, j].IntersectsWith(w)) //If the bullet hits a wall take it off screen and set its move to false
                            {
                                enemyRectBul[i, j].Location = new Point(3000, 3000);
                                myEnemy[i].EnemyClip[j].Move = false;
                            }

                        }

                        if (enemyRectBul[i, j].IntersectsWith(rectPlayer)) //If a bullet hits the player take it off screen and set its move to false
                        {
                            enemyRectBul[i, j].Location = new Point(3000, 3000);
                            myEnemy[i].EnemyClip[j].Move = false;
                            if (iFrames <= 0) //If the player has no frames of immunity then take away health and give the player I frames
                            {
                                //lifeLostPlayer.Ctlcontrols.play();
                                currentHealth--;
                                iFrames = 5;
                            }
                        }

                        #endregion
                    }
                }
            }
            #endregion
        }

        public void MiniBossTickCode()
        {
            #region MiniBossCode
            if (miniBoss.EnemyActive) //If the mini boss is moving
            {
                #region MiniBossMovement
                miniBoss.PlayerDistanceX = rectPlayer.X - rectMiniBoss.X; //The difference in x between the player and mini boss
                if (miniBoss.PlayerDistanceX < 0)
                {
                    miniBoss.PlayerDistanceX *= -1; //If its a negative then multiply by -1 to make it a positive
                }

                miniBoss.PlayerDistanceY = rectPlayer.Y - rectMiniBoss.Y; //The difference in y between the player and mini boss

                if (miniBoss.PlayerDistanceY < 0)
                {
                    miniBoss.PlayerDistanceY *= -1; //If its a negative then mutliply by -1 to make it a positive
                }

                miniBoss.Angle = (float)GetAngleBetweenObjects(rectMiniBoss.Location, rectPlayer.Location); //Set the angle the miniboss needs to rotate at
                enemyRadians = miniBoss.Angle * (Math.PI / 180); // Convert angle to radians
                enemyX = miniBoss.Speed * Math.Cos(enemyRadians); //Calculate the x the mini boss needs to move at to reach the player
                enemyY = miniBoss.Speed * Math.Sin(enemyRadians); //Calculate the y the mini boss needs to move at to reach the plaer
                miniBoss.X = (int)enemyX; //Set the x that the mini boss has to move to reach the player
                miniBoss.Y = (int)enemyY; //Set the y that the mini boss has to move to reach the player

                shotDistanceX = 400; //The x distance the enemy has to be at or under to shoot
                shotDistanceY = 300; //The y distance the enemy ahs to be at or under to shoot

                if (miniBoss.PlayerDistanceX > shotDistanceX) //If the enemy is too far then move towards the player
                {
                    rectMiniBoss.X += miniBoss.X;
                }

                foreach (Rectangle r in rectWalls) //For each wall if the mini boss intersects with it then do the opposite of the last movement
                {
                    if (rectMiniBoss.IntersectsWith(r))
                    {
                        rectMiniBoss.X -= miniBoss.X;
                    }
                }

                if (miniBoss.PlayerDistanceY > shotDistanceY) //If the enemy is too far then move towards the player
                {
                    rectMiniBoss.Y += miniBoss.Y;
                }

                foreach (Rectangle r in rectWalls) //For each wall if the mini boss intersects with it then do the opposite of the last movement
                {
                    if (rectMiniBoss.IntersectsWith(r))
                    {
                        rectMiniBoss.Y -= miniBoss.Y;
                    }

                }
                #endregion

                #region MiniBossShooting

                if (miniBoss.BulDelay <= 0) //If there is no bullet delay
                {
                    //railgunBlastPlayer.Ctlcontrols.play();
                    rectMiniBossClip[miniBoss.ClipCount].Location = new Point(rectMiniBoss.X, rectMiniBoss.Y);
                    //Set the lasers location to where the mini boss is

                    rotateAngle = (float)GetAngleBetweenObjects(miniBoss.EnemyPoint, playerPoint);
                    //Set the angle at which the lasers have to rotate

                    miniBoss.EnemyClip[miniBoss.ClipCount].BMP = RotateImage(miniBoss.EnemyClip[miniBoss.ClipCount].OgBMP, rotateAngle, false);
                    //Set the BMP based on the original BMP and the angle between the enemy and player

                    miniBoss.EnemyClip[miniBoss.ClipCount].Angle = rotateAngle; //Set the angle for the mini boss to rotate at
                    enemyBulRadians = rotateAngle * (Math.PI / 180); //Calculate the radians using the angle

                    miniBoss.EnemyClip[miniBoss.ClipCount].X = (int)(miniBoss.EnemyClip[miniBoss.ClipCount].Speed * Math.Cos(enemyBulRadians));
                    //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                    miniBoss.EnemyClip[miniBoss.ClipCount].Y = (int)(miniBoss.EnemyClip[miniBoss.ClipCount].Speed * Math.Sin(enemyBulRadians));
                    //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                    miniBoss.EnemyClip[miniBoss.ClipCount].Move = true; //Set the laser that was just shot to moving so that the newxt piece of code can move it
                    miniBoss.BulDelay = 30; //Set a delay so that the mini boss is not constantly shooting
                    miniBoss.ClipCount--; //Decrease the clipcount to go to the next laser on next shot
                    //railgunChargePlayer.Ctlcontrols.play();
                }
                miniBoss.BulDelay--; //If there is delay then decrease it by 1 for each tick untill it reaches 0, allowing another shot

                if (miniBoss.ClipCount <= 0) //If the last laser in the "clip" is shot reset it 19,                                                
                {                           //this doesn't mean the enemys have a limit it just exists to reset so that the enemies can always shoot
                    miniBoss.ClipCount = 19;
                }
                #endregion                           
            }

            #region MiniBossLaserMovement 
            for (int i = 0; i < miniBoss.EnemyClip.Length; i++) //for each of the mini bosses lasers
            {
                if (miniBoss.EnemyClip[i].Move) //If the laser is moving then increase the X and Y by the values calculated above
                {
                    rectMiniBossClip[i].X += miniBoss.EnemyClip[i].X;
                    rectMiniBossClip[i].Y += miniBoss.EnemyClip[i].Y;
                }
            }
            #endregion

            #region LaserCollisionDetection
            for (int i = 0; i < miniBoss.ProjectileNum; i++) //Foreach laser
            {
                if (rectMiniBossClip[i].IntersectsWith(rectPlayer)) //If a laser intersects with a player then move the laser set its move to false
                {
                    rectMiniBossClip[i].Location = new Point(3000, 3000);
                    miniBoss.EnemyClip[i].Move = false;
                    if (iFrames <= 0) //If the player has no immunity frames then decrease their current health and give them immunity frames
                    {
                        //lifeLostPlayer.Ctlcontrols.play();
                        currentHealth--;
                        iFrames = 5;
                    }
                }
                if (!rectMiniBossClip[i].IntersectsWith(rectScreen))
                {
                    rectMiniBossClip[i].Location = new Point(3000, 3000);
                    miniBoss.EnemyClip[i].Move = false;
                }
            }
            #endregion
            #endregion
        }

        public void PlayerTickCode()
        {
            #region PlayerCode

            #region PlayerMovement

            if (left) rectPlayer.X -= 10; //If the player hits A then move left 
            {
                foreach (Rectangle r in rectWalls)//If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                {
                    {
                        if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                            rectPlayer.X += 10;
                    }
                }
            }



            if (right) rectPlayer.X += 10; //If the player hits D then move right
            {
                foreach (Rectangle r in rectWalls) //If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                {
                    if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                    {
                        rectPlayer.X -= 10;
                    }
                }
            }



            if (up) rectPlayer.Y -= 10; //If the player hits W then move up
            {
                foreach (Rectangle r in rectWalls) //If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                {
                    if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                    {
                        rectPlayer.Y += 10;
                    }
                }
            }


            if (down) rectPlayer.Y += 10; //If the player hits S then move down
            {
                foreach (Rectangle r in rectWalls) //If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                {
                    if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                    {
                        rectPlayer.Y -= 10;
                    }
                }
            }

            if (space)
            {
                dashAngle = (float)GetAngleBetweenObjects(playerPoint, Cursor.Position); //Get the angle the player needs to move at to move towards the cursor
                dashRadians = dashAngle * (Math.PI / 180); //Convert the angle into radians
                dashX = 50 * Math.Cos(dashRadians); //Calculate the X that needs to be incremented to move along the angle using the radians
                dashY = 50 * Math.Sin(dashRadians); //Calculate the Y that needs to be incremented to move along the angle using the radians
                dashing = true; //Set dashing to true so the next piece of code runs
            }

            if (dashing)
            {
                if (dashCount < 5) //Run the code to move the player by the calculated x and y 5 times which looks like a dash
                {
                    rectPlayer.X += (int)dashX;
                    foreach (Rectangle r in rectWalls) //If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                    {
                        if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                        {
                            rectPlayer.X -= (int)dashX;
                        }
                    }

                    rectPlayer.Y += (int)dashY;
                    foreach (Rectangle r in rectWalls)  //If the player intersects with a wall or the screen boundary then do the opposite movement just done to get them out
                    {
                        if (rectPlayer.IntersectsWith(r) || !rectPlayer.IntersectsWith(rectScreen))
                        {
                            rectPlayer.Y -= (int)dashY;
                        }
                    }
                    dashCount++;
                }
                else
                {
                    dashing = false; //Set dashing to false so the code does not repeat unless the space bar is pressed again
                    dashCount = 0;
                }

            }

            #endregion

            #region PlayerShooting          

            if (shoot)
            {
                if (bulDelay <= 0)
                {
                    if (user.Weapon == "SMG")
                    {
                        rectBullet[clipCount].Location = new Point(rectPlayer.X, rectPlayer.Y);
                        //Sets the bullets position to the players position

                        myClip[clipCount].BMP = (RotateImage(myClip[clipCount].OgBMP, (float)GetAngleBetweenObjects(playerPoint, Cursor.Position), false));
                        //Sets the BMP to the rotated version of the original using the angle between the player and the cursor

                        rotateAngle = (float)GetAngleBetweenObjects(playerPoint, Cursor.Position);
                        //Sets the angle at which the bullet has to move along to go from the player to the cursor

                        bulRadians = rotateAngle * (Math.PI / 180); // Convert angle to radians

                        myClip[clipCount].X = (int)(myClip[clipCount].Speed * Math.Cos(bulRadians));
                        //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                        myClip[clipCount].Y = (int)(myClip[clipCount].Speed * Math.Sin(bulRadians));
                        //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                        myClip[clipCount].Move = true; //Set bullet move to true so that the bullet movement code can run
                        bulDelay = 2; //Set bulet delay so that the player can't spam the shoot button
                        shotCount++; //Increment shot count to track the players remaining ammo before reloading
                        clipCount--; //Decrease clipcount so the next bullet can be shot
                        //smgShotPlayer.Ctlcontrols.play();
                    }
                    else if (user.Weapon == "SHOTGUN")
                    {
                        rotateAngle = (float)GetAngleBetweenObjects(playerPoint, Cursor.Position) - 12;
                        //Sets the angle at which the bullet has to move along to go from the player to the cursor
                        for (int i = 0; i < 10; i++)
                        {
                            rectBullet[clipCount].Location = new Point(rectPlayer.X, rectPlayer.Y);
                            //Sets the bullets position to the players position

                            myClip[clipCount].BMP = RotateImage(myClip[clipCount].OgBMP, (float)GetAngleBetweenObjects(playerPoint, Cursor.Position), false);
                            //Sets the BMP to the rotated version of the original using the angle between the player and the cursor

                            bulRadians = rotateAngle * (Math.PI / 180); // Convert angle to radians

                            myClip[clipCount].X = (int)(myClip[clipCount].Speed * Math.Cos(bulRadians));
                            //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myClip[clipCount].Y = (int)(myClip[clipCount].Speed * Math.Sin(bulRadians));
                            //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                            myClip[clipCount].Move = true; //Set bullet move to true so that the bullet movement code can run
                            clipCount--;  //Decrease clipcount so the next bullet can be shot
                            rotateAngle += 2; //Increase the angle so the next bullet has a different path
                            bulDelay = 9; //Set bulet delay so that the player can't spam the shoot button
                            //shotgunShotPlayer.Ctlcontrols.play();
                        }
                        shotCount++; //Increment shot count to track the players remaining ammo before reloading
                    }
                    else if (user.Weapon == "SWORD")
                    {
                        rectBullet[clipCount].Location = new Point(rectPlayer.X, rectPlayer.Y);
                        //Sets the sword slashes position to the players position

                        myClip[clipCount].BMP = (RotateImage(myClip[clipCount].OgBMP, (float)GetAngleBetweenObjects(playerPoint, Cursor.Position), false));
                        //Sets the BMP to the rotated version of the original using the angle between the player and the cursor

                        rotateAngle = (float)GetAngleBetweenObjects(playerPoint, Cursor.Position);
                        //Sets the angle at which the sword slash has to move along to go from the player to the cursor

                        bulRadians = rotateAngle * (Math.PI / 180); // Convert angle to radians

                        myClip[clipCount].X = (int)(myClip[clipCount].Speed * Math.Cos(bulRadians));
                        //Calculate the X neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                        myClip[clipCount].Y = (int)(myClip[clipCount].Speed * Math.Sin(bulRadians));
                        //Calculate the Y neccesary to move along the angle calculated by using the radians and the speed (distance per tick) you want it to travel at

                        myClip[clipCount].Move = true; //Set move to true so that the movement code can run
                        bulDelay = 8; //Set bullet delay so that the player can't spam the shoot button
                        shotCount++; //Increment shot count to track the players remaining ammo before reloading
                        clipCount--; //Decrease clipcount so the next sword slash can be fired
                        //swordSlashPlayer.Ctlcontrols.play();
                    }
                }
            }
            bulDelay--; //For every tick there is bullet delay bulDelay is decreased by 1 to act as a timer before the shoot code can run again



            for (int i = 0; i < projectileNum; i++) //Fore every projectile in the players clip
            {
                if (myClip[i].Move) //If the projectile is moving
                {
                    if (user.Weapon == "SWORD") //If its a sword then increment the x and y untill bulDelay hits 1, where it then pauses for a tick 
                    {
                        if (bulDelay > 1)
                        {
                            rectBullet[i].X += myClip[i].X / 4;
                            rectBullet[i].Y += myClip[i].Y / 4;
                        }
                        else if (bulDelay == 0) //Once the tick of it being statioonary finished then set move to false and take it off screen
                        {
                            rectBullet[0].Location = new Point(3000, 3000);
                            myClip[0].Move = false;
                        }
                    }
                    else //If its an SMG or shotgun then just increment the X and Y no matter what
                    {
                        rectBullet[i].X += myClip[i].X / 4;
                        rectBullet[i].Y += myClip[i].Y / 4;
                    }
                }
            }

            if (clipCount < 0 && user.Weapon != "SWORD") //Once the clipcount is less than 0 and every projectile has been shot, reset the clipcount
            {
                clipCount = 19; //To 19 for SMG and shotgun
            }
            else if (clipCount < 0)
            {
                clipCount = 1; //To 1 for sword
            }

            #endregion

            #region PlayerAndPlayerBulletCollision

            foreach (Rectangle r in rectBullet)
            {
                foreach (Rectangle re in rectEnemy)
                {
                    if (r.IntersectsWith(re)) //If any bullet intersects with any enemy increment dead counter 
                    {
                        //enemyHitPlayer.Ctlcontrols.play();
                        deadCounter++;
                        if (deadCounter == spawnAmount) //If all of the enemies spawn are dead 
                        {
                            for (int i = 0; i < 6; i++) //Look for the last one to be killed and set a healthPickup at its location
                            {
                                if (myEnemy[i].EnemyActive)
                                {
                                    healthPickup[pickUpNum].Location = rectEnemy[i].Location;
                                }
                            }
                            pickUpNum++; //pickUpNum allows is for the array of healthpickups allowing for multiple on the screen at once
                            if (pickUpNum == 5) //Reset it when it hits 5
                            {
                                pickUpNum = 0;
                            }
                        }

                        if (user.Weapon != "SWORD") //If its not the sword, set the projectiles move to false and move it off screen
                        {
                            rectBullet[bulCount].Location = new Point(3000, 3000);
                            myClip[bulCount].Move = false;
                        }

                        rectEnemy[enCount].Location = new Point(5000, 5000); //Move the enemy off screen
                        myEnemy[enCount].EnemyActive = false; //Set active off so that enemy code doesn't play
                        score++; //Increment score for score keeping on the leaderboard
                    }
                    enCount++;
                }
                enCount = 0;
                bulCount++;
            }
            bulCount = 0;

            foreach (Rectangle r in rectBullet)
            {
                if (r.IntersectsWith(rectMiniBoss)) //If any bullets intersect with the boss 
                {
                    //enemyHitPlayer.Ctlcontrols.play();
                    if (user.Weapon != "SWORD") //If its not the sword, set the projectiles move to false and move it off screen
                    {
                        rectBullet[bulCount].Location = new Point(3000, 3000);
                        myClip[bulCount].Move = false;
                    }
                    miniBossHealth--;

                    if (miniBossHealth == 0) //When the boss dies reset its health, add score and add to dead counter
                    {
                        miniBossHealth = 15;
                        score += 10;
                        deadCounter++;
                        healthAddition.Location = rectMiniBoss.Location; //Set a health addition for the player where the miniboss is
                        rectMiniBoss.Location = new Point(5000, 5000); //Take the mini boss off screen
                        miniBoss.EnemyActive = false; //Set the mini boss active to false
                    }
                }
                bulCount++;
            }
            bulCount = 0;

            foreach (Rectangle r in rectBullet)
            {
                if (r.IntersectsWith(rectBoss)) //If any bullet intersects with the boss
                {
                    //enemyHitPlayer.Ctlcontrols.play();
                    if (user.Weapon != "SWORD")  //If its not the sword, set the projectiles move to false and move it off screen
                    {
                        rectBullet[bulCount].Location = new Point(3000, 3000);
                        myClip[bulCount].Move = false;
                    }

                    if (!shielded)
                    {
                        bossHealth -= 1;
                    }

                    if (bossHealth <= 0 && bossStage == 1) //If the boss reaches 0 health in stage 1 reset health, make him stop moving and go to next boss stage
                    {
                        bossHealth = 30;
                        boss.EnemyActive = false;
                        bossStage++;
                        roundDelay = 0;
                    }
                    else if (bossHealth <= 0 && bossStage == 2) //If the boss reaches 0 health in stage 2 reset health, make him stop,
                    {                                            //increase his speed, go to next boss stage and set game state to dialogue                    
                        bossHealth = 30;
                        boss.EnemyActive = false;
                        bossStage++;
                        boss.Speed = 15;
                        roundDelay = 0;
                        gameState = "Dialogue";
                    }
                    else if (bossHealth <= 0 && bossStage == 3) //If the boss reaches 0 health in stage 3 go to next boss stage,
                    {                                    //add 100 score and go to dialogie game state                                     
                        bossStage++;
                        score += 100;
                        gameState = "Dialogue";
                    }
                }
                bulCount++;
            }
            bulCount = 0;



            foreach (Rectangle b in rectBullet)
            {
                foreach (Rectangle w in rectWalls)
                {
                    if (b.IntersectsWith(w) || !b.IntersectsWith(rectScreen)) //if any bullets intersect with a wall or go past the screen rectangle then 
                    {                                                         //Move them off screen and set their move to false
                        rectBullet[bulCount].Location = new Point(3000, 3000);
                        myClip[bulCount].Move = false;
                    }
                }
                bulCount++;
            }
            bulCount = 0;

            for (int i = 0; i < 5; i++)
            {
                if (rectPlayer.IntersectsWith(healthPickup[i])) //If the player intersects with any healthpickups, move the pickup and restore the players hp
                {
                    currentHealth = maxHealth;
                    healthPickup[i].Location = new Point(8000, 8000);
                }
            }

            if (rectPlayer.IntersectsWith(healthAddition)) //If the player intersects with the healthaddition then increase their max health and move 
            {                                              //the health addition off screen
                maxHealth++;
                healthAddition.Location = new Point(8000, 8000);
                currentHealth = maxHealth;
            }
            #endregion

            #region Reloading
            if (reload && !reloading) //Reload is for if the player has chosen to reload and reloading is for if the process of reloading is currently happening
            {
                if (user.Weapon == "SMG") //The sword character can't reload but the SMG and shotgun characters can
                {
                    bulDelay = 51; //Setting the delay to 51 when each tick is 100 milliseconds means that the player wont be able to shoot for 5.1 seconds
                    reloading = true; //Reloading is then set to true so the game knows to change the image in the reloading picturebox which is based on the bulDelay
                    //smgReloadPlayer.Ctlcontrols.play();
                }
                else if (user.Weapon == "SHOTGUN")
                {
                    bulDelay = 31;  //Setting the delay to 31 when each tick is 100 milliseconds means that the player wont be able to shoot for 3.1 seconds
                    reloading = true; //Reloading is then set to true so the game knows the change the image in the reloading picturebox which is based on the bulDelay
                    //shotgunReloadPlayer.Ctlcontrols.play();
                }
            }

            if (user.Weapon == "SMG") //If the player is using the SMG and they shoot 20 times and they arent already reloading, set reloading to true 
            {                     //Setting the delay to 51 when each tick is 100 milliseconds means that the player wont be able to shoot for 5.1 seconds
                if (shotCount == 20 && !reloading)
                {
                    bulDelay = 51;
                    reloading = true;
                    //smgReloadPlayer.Ctlcontrols.play();
                }

                if (bulDelay <= 0) //If the bullet delay hits 0 or less than that means reloading has finished
                {
                    reloading = false;
                }
            }
            else if (user.Weapon == "SHOTGUN")//If the player is using the shotgun and they shoot 5 times and they arent already reloading, set reloading to true 
            {                      //Setting the delay to 31 when each tick is 100 milliseconds means that the player wont be able to shoot for 3.1 seconds
                if (shotCount == 5 && !reloading)
                {
                    bulDelay = 31;
                    reloading = true;
                    //shotgunReloadPlayer.Ctlcontrols.play();

                }

                if (bulDelay <= 0) //If the bullet delay hits 0 or less than that means reloading has finished
                {
                    reloading = false;
                }
            }

            if (user.Weapon != "SWORD") //If its not the sword being used and reloading is happeneing change the reload boxs image depending on the buldelay
            {
                if (reloading)
                {
                    switch (bulDelay)
                    {
                        case 50: reloadBox.Image = Properties.Resources.Reload5; break;
                        case 40: reloadBox.Image = Properties.Resources.Reload4; break;
                        case 30: reloadBox.Image = Properties.Resources.Reload3; break;
                        case 20: reloadBox.Image = Properties.Resources.Reload2; break;
                        case 10: reloadBox.Image = Properties.Resources.Reload1; break;
                        case 1: shotCount = 0; break;
                    }
                }
                else reloadBox.Image = Properties.Resources.Reload; //The base reload image for when reloading isnt happening
            }

            if (user.Weapon == "SMG") //Change the label for displaying ammo depending on the weapon
            {
                ammoDisplayLbl.Text = 20 - shotCount + "/20";
            }
            else if (user.Weapon == "SHOTGUN")
            {
                ammoDisplayLbl.Text = 5 - shotCount + "/5";
            }
            else ammoDisplayLbl.Text = "INFINITE";

            #endregion

            #endregion
        }

        public void BossTickCode()
        {
            #region BossCode

            #region Bossmovement
            if (boss.EnemyActive && shielded) //If the boss is active and shielded
            {
                boss.PlayerDistanceX = rectPlayer.X - rectBoss.X; //The difference in X between the player and boss
                if (boss.PlayerDistanceX < 0)
                {
                    boss.PlayerDistanceX *= -1; //If its negative multiply by -1 as it needs to be positive
                }

                boss.PlayerDistanceY = rectPlayer.Y - rectBoss.Y; //The difference in Y between the player and boss

                if (boss.PlayerDistanceY < 0)
                {
                    boss.PlayerDistanceY *= -1; //If its negative multiply by -1 as it needs to be positive
                }

                boss.Angle = (float)GetAngleBetweenObjects(rectBoss.Location, rectPlayer.Location);
                //Calculate the angle between the boss and player

                enemyRadians = boss.Angle * (Math.PI / 180); // Convert angle to radians
                boss.Y = (int)(boss.Speed * Math.Cos(enemyRadians));
                //Calculate the Y the boss needs to travel to move along the angle calculated

                boss.X = (int)(boss.Speed * Math.Sin(enemyRadians));
                //Calculate the X the boss needs to travel to move along the angle calculated

                if (bossStage < 3) //If the boss isn't on stage 3 yet he will stay far away
                {
                    shotDistanceX = 400;
                    shotDistanceY = 300;
                }
                else //If the boss is on stage 3 he will get close to the player
                {
                    shotDistanceX = 10;
                    shotDistanceY = 10;
                }

                if (boss.PlayerDistanceX > shotDistanceX) //If the boss is far away enough on the x from the player then increaes the x
                {
                    rectBoss.X += boss.X;
                }

                if (boss.PlayerDistanceY > shotDistanceY) //If the boss is far away enough on the y from the player then increaes the y
                {
                    rectBoss.Y += boss.Y;
                }
            }
            #endregion

            #region BossAttacking
            if (bossStage == 3) //If the boss is on stage 3 then if the player and boss intersect and the player has no Immunity frames take away 1 health
            {
                if (rectBoss.IntersectsWith(rectPlayer))
                {
                    if (iFrames <= 0)
                    {
                        //lifeLostPlayer.Ctlcontrols.play();
                        currentHealth--;
                        iFrames = 5;
                    }
                }
            }
            #endregion

            #endregion
        }
        #endregion

        #region MethodsFromStackOverFlow
        public static double GetAngleBetweenObjects(Point p1, Point p2) //https://stackoverflow.com/questions/12891516/math-calculation-to-retrieve-angle-between-two-points
        {
            float xDiff = p2.X - p1.X;
            float yDiff = p2.Y - p1.Y;
            return Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }

        private Bitmap RotateImage(Bitmap bmp, float angle, bool playerOrEnemy) //https://stackoverflow.com/questions/12024406/how-can-i-rotate-an-image-by-any-degree
        {
            float height = bmp.Height;
            float width = bmp.Width;
            int hypotenuse = System.Convert.ToInt32(System.Math.Floor(Math.Sqrt(height * height + width * width)));
            Bitmap rotatedImage = new Bitmap(hypotenuse, hypotenuse);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2);
                g.RotateTransform((float)angle);
                g.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2);
                g.DrawImage(bmp, (hypotenuse - width) / 2, (hypotenuse - height) / 2, width, height);

                if (!playerOrEnemy) //my own addition to the code (not from website)
                {
                    myClip[clipCount].BMP = rotatedImage; //If the BMP being rotated is an enemy or player, set the BMP to object at position
                }                                          //whatever clipcount is in the my clip array
                return rotatedImage;
            }
        }
        #endregion
    }
}
#endregion