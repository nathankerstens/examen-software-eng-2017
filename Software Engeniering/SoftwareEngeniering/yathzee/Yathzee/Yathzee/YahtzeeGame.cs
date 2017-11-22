using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yathzee
{
    public partial class YahtzeeGame : Form
    {
        int nbrOfPlayedGames = 0;
        private int theScore = 0;
        private int totalTries = 3;
        private int highScore;
        private int changeAbilities = 3;
        
        private int minimumScore = 40;

        Game NewGame = new Game();
        int[] DEWAARDES = new int[3];

        public YahtzeeGame()
        {
            InitializeComponent();

            



        }

        public void SetPicturebox1(int value)
        {

            switch (value)
            {
                case 1:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen1;
                    break;
                case 2:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen2;
                    break;
                case 3:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen3;
                    break;

                case 4:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen4;
                    break;
                case 5:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen5;
                    break;
                case 6:
                    pictureBox1.Image = Yathzee.Properties.Resources.dobbelsteen6;
                    break;
                default:
                    break;
            }
            pictureBox1.Invalidate();
        }
        public void SetPicturebox2(int value)
        {

            switch (value)
            {
                case 1:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen1;
                    break;
                case 2:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen2;
                    break;
                case 3:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen3;
                    break;

                case 4:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen4;
                    break;
                case 5:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen5;
                    break;
                case 6:
                    pictureBox2.Image = Yathzee.Properties.Resources.dobbelsteen6;
                    break;
                default:
                    break;
            }
            pictureBox1.Invalidate();
        }
        public void SetPicturebox3(int value)
        {

            switch (value)
            {
                case 1:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen1;
                    break;
                case 2:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen2;
                    break;
                case 3:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen3;
                    break;

                case 4:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen4;
                    break;
                case 5:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen5;
                    break;
                case 6:
                    pictureBox3.Image = Yathzee.Properties.Resources.dobbelsteen6;
                    break;
                default:
                    break;
            }
            pictureBox1.Invalidate();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            PictureVisibleTrue();

            if (totalTries > 0)
            {
                
                OnlyButton1Visible();
                totalTries -= 1;
            
          
            NewGame.StartGame();
            
           
            



                

                if (NewGame.getScore == NewGame.getJackpotScore)
                {
                    Gewonnen("Jackpot!");
                }

                else
                {
                    theScore += NewGame.getScore;
                }

            label4.Text = theScore.ToString();

                

             DEWAARDES = NewGame.GetDobbelstenen();
            SetPicturebox1(DEWAARDES[0]);
            SetPicturebox2(DEWAARDES[1]);
            SetPicturebox3(DEWAARDES[2]);


                if (theScore > highScore)
                {
                    highScore = theScore;
                }
                label4.Text= theScore.ToString();
                label5.Text = highScore.ToString();
            }

           

            else
            {
              
                OnlyButton2Visible();
            }

            if (totalTries == 0)
            {
               
                OnlyButton2Visible();
            }

            if (totalTries == 0 && theScore < minimumScore)
            {
                Verloren();
            }
            
            if (totalTries == 0 && theScore > minimumScore)
            {
                Gewonnen("gewonnen");
            }

        }




      
        public void Gewonnen(string tekst)
        {
            lblGewonnen.Visible = true;
            lblGewonnen.Text = tekst;

            OnlyButton2Visible();
        
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        public void Verloren()
        {
            lblGewonnen.Visible = true;
            lblGewonnen.Text = "Oops, verloren";

           

            OnlyButton2Visible();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StartNewGame();
            lblGewonnen.Visible = false;
            label6.Text = nbrOfPlayedGames.ToString();
            OnlyButton1Visible();
            changeAbilities = 3;
            PictureVisibleFalse();
        }
        #region private voids
        private void YahtzeeGame_Load(object sender, EventArgs e)
        {
            OnlyButton2Visible();
            label6.Text = nbrOfPlayedGames.ToString();
            NothingVisibleExecptNewGame();
        }
        private void OnlyButton1Visible()
        {
            button1.Visible = true;
            button2.Visible = false;
        }
        private void OnlyButton2Visible()
        {
            button1.Visible = false;
            button2.Visible = true;
        }
        private void StartNewGame()
        {
            nbrOfPlayedGames++;

            totalTries = 3;
            theScore = 0;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            lblGewonnen.Visible = true;
            lblHighscore.Visible = true;
            lblPlayedGames.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            ScoreThisGame.Visible = true;
            label4.Text = theScore.ToString();
            label5.Text = highScore.ToString();
            label6.Text = nbrOfPlayedGames.ToString();
        }
        private void NothingVisibleExecptNewGame ()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            lblGewonnen.Visible = false;
            lblHighscore.Visible = false;
            lblPlayedGames.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            ScoreThisGame.Visible = false;



            button1.Visible = false;
        }

        private void PictureVisibleFalse()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void PictureVisibleTrue()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }



        #endregion

        #region pictureBox Changing

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // change current dime

            if (changeAbilities > 0)
            {
                changeAbilities--;
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            NewGame.ChangeCurrentDimeFirst = random;
            int[] NieuweWAARDES = new int[3];

            NieuweWAARDES = NewGame.GetDobbelstenen();
            SetPicturebox1(NieuweWAARDES[0]);
            int NewScore = NewGame.getScore;
            label4.Text = NewScore.ToString();

            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (changeAbilities > 0)
            {
                changeAbilities--;
                Random rnd = new Random();
                int random = rnd.Next(0, 6);

                NewGame.ChangeCurrentDimeSecond = random;
                int[] NieuweWAARDES = new int[3];

                NieuweWAARDES = NewGame.GetDobbelstenen();
                SetPicturebox2(NieuweWAARDES[1]);
                int NewScore = NewGame.getScore;
                label4.Text = NewScore.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            changeAbilities--;
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

            NewGame.ChangeCurrentDimeThird = random;
            int[] NieuweWAARDES = new int[3];

            NieuweWAARDES = NewGame.GetDobbelstenen();
            SetPicturebox3(NieuweWAARDES[2]);
            int NewScore = NewGame.getScore;
            label4.Text = NewScore.ToString();

        }

        #endregion
    }
}
