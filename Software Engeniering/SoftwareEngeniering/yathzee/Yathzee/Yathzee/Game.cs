using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yathzee
{
    class Game
    {
        int scoreThisGame;
        int jackpotScore = 18;
        int highScore;
        dobbelstenen dobbelsteen1 = new dobbelstenen();
        dobbelstenen dobbelsteen2 = new dobbelstenen();
        dobbelstenen dobbelsteen3 = new dobbelstenen();
        public void StartGame()
        {
         
    
            Random rnd = new Random();
            int random = rnd.Next(0, 6);

           
            dobbelsteen1.waarde = rnd.Next(1,7);
            dobbelsteen2.waarde = rnd.Next(1, 7);
            dobbelsteen3.waarde = rnd.Next(1, 7);
            
            
           
            if (checkJackpot())
            {
                scoreThisGame = jackpotScore;
            }
            else
            {
                calcScore();
            }
            





        }


        public int ChangeCurrentDimeFirst
        {
            set
            {
                dobbelsteen1.waarde = value;
                calcScore();
            }
        }

        public int ChangeCurrentDimeSecond
        {
            set
            {
                dobbelsteen2.waarde = value;
                calcScore();
            }
        }
        public int ChangeCurrentDimeThird
        {
            set
            {
                dobbelsteen3.waarde = value;
                calcScore();
            }
        }




        public int getScore
        {
            get
            {
                return scoreThisGame;
            }
        }

     

        public int getHighscore()
        {
            return this.highScore;
        }

        public int getCurrentScore()
        {
            return this.scoreThisGame;
        }
        public int[] GetDobbelstenen()
        {

            int[] array2 = { dobbelsteen1.waarde, dobbelsteen2.waarde, dobbelsteen3.waarde };
            return array2;

        }


        public void calcScore()
        {
            int calScore = 0;

            calScore += dobbelsteen1.waarde;
            calScore += dobbelsteen2.waarde;
            calScore += dobbelsteen3.waarde;

            scoreThisGame = calScore;
        }

        public bool checkJackpot()
        {
            if (dobbelsteen1.waarde == dobbelsteen2.waarde && dobbelsteen2.waarde == dobbelsteen3.waarde)
            {
                return true;
            }
            else
                return false;
        }

        public int getJackpotScore
        {
            get { return jackpotScore; }
        }
  
    }
}
