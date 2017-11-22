using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yathzee
{
    class GameUI : Game
    {
        int _nbrOfPlayedGames = 0;
        private int theScore = 0;
        private int totalTries = 3;
        private int highScore;

        
        private int minimumScore = 40;

      public void getScore()
        {
            highScore = getHighscore();
            theScore = getCurrentScore();

          
        }

        public int nbrOfPlayedGames
        {
            set
            {
                _nbrOfPlayedGames = value;
            }

            get
            {
                return _nbrOfPlayedGames;
            }
        }

        public void newGameStart()
        {
            _nbrOfPlayedGames++;
        }


    }
}
