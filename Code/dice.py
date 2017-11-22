import random
from customFunctions import isUniqueList

class Dice:
    _eyes = 6
    _rerollText = "\nReroll #\'s? (no spaces) / or press enter to keep\n"

    def __init__(self, eyes = _eyes):
        self._eyes = eyes

    def roll(self):
        roll = random.randint(1, self._eyes)
        return roll

    def rollX(self, x = 1):
        rolls = []
        for i in range(0, x):
            rolls.append(self.roll())
        return rolls

    def printRolls(self, rolls):
        print " -------------------"
        print "|                   |"
        for i, val in enumerate(rolls):
            print "|   Roll #" + str(i+1) + "     " + str(val) + "   |"
            print "|                   |"
        print " -------------------\n"

    def reroll(self, rolls, input):
        rolls2 = self.rollX(len(input))
        # place rolls2 in rolls at index from rerollInput - 1
        for i, val in enumerate(input):
            rolls[int(val)-1] = rolls2[i]

        return rolls
    def rerollInput(self, rolls, chances = 1):
        #rerolls until chances are 0
        if chances < 1:
            return rolls

        # check if input is integer or enter
        while True:
            try:
                input = raw_input(self._rerollText)
                if input == "": break
                input = list(input)
                if len(input) > 5:
                    print("\nWrong input! Max 5 numbers")
                    self.rerollInput(rolls, chances)
                elif isUniqueList(input) == False:
                    print("\nWrong input! Numbers have to be unique")
                    self.rerollInput(rolls, chances)
                else:
                    chances -= 1
                    rolls = self.reroll(rolls, input)
                    self.printRolls(rolls)
                    self.rerollInput(rolls, chances)

            except ValueError:
               print("\nWrong input! press enter or max 5 numbers")
               self.rerollInput(rolls, chances)
            except IndexError:
               print("\nWrong input! Numbers must be between 1 and 5")
               self.rerollInput(rolls, chances)
            else:
                break
