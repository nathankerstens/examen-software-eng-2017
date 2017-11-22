from dice import Dice
from scoreboard import Scoreboard
import time
# Make a class of dice
dice = Dice()
score = Scoreboard()
print "\nWelcome to Yahtzee, where you roll dice to score points.\nWhen you score 63 or more points in the upper bracket, you receive an additional 35 points!\n"
time.sleep(2)
while(score.getRound() <= 13):
    score.showScoreboard()
    rolls = dice.rollX(5)
    dice.printRolls(rolls)
    dice.rerollInput(rolls, 2)
    score.optionsScreen()
    score.optionsInput(rolls)
score.endOfGame()
raw_input("Press any key to exit")
