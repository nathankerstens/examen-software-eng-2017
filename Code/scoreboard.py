from functools import partial

class Scoreboard:
    _round = 1
    _players = 1
    _upperScore = 0
    _lowerScore = 0
    _totalScore = _upperScore + _lowerScore
    _yahtzee = False

    _optionsUpper = ["Count all 1's", "Count all 2's", "Count all 3's", "Count all 4's", "Count all 5's", "Count all 6's"]
    _optionsLower = ["3 of a kind", "4 of a kind", "Small Straight", "Large Straight", "Full House", "Yahtzee", "Chance"]
    _blockedList = []
    def __init__(self, players = _players):
        self._players = players

    def showScoreboard(self):
        print " --------------------------------"
        print "    Round #{}   ".format(self._round)
        print "    Upper Score {}   ".format(self._upperScore)
        print "    Lower Score {}   ".format(self._lowerScore)
        print " --------------------------------"
    def addScoreUpper(self, score, option):
        self._upperScore += score
        self.addScore(score, option)
    def addScoreLower(self, score, option = 0):
        self._lowerScore += score
        self.addScore(score, option)
    def addScore(self, score, option = 0):
        self.blockOption(option)
        print "\nYou\'ve received {} points!\n".format(score)
        self._totalScore += score
        self._round += 1
    def getRound(self):
        return self._round
    def blockOption(self, option = 0):
        self._blockedList.append(option)
    def endOfGame(self):
        print " -------------------"
        if self._upperScore > 62:
            self._upperScore += 35
            print "    Received 35 bonus points!   "
        print "    Game finished!   "
        print "    Upper Score {}   ".format(self._upperScore)
        print "    Lower Score {}   ".format(self._lowerScore)
        print "    Total Score {}   ".format(self._totalScore)
        print " -------------------"

    def upper1(self, rolls):
        self.upper(rolls, 1)
    def upper2(self, rolls):
        self.upper(rolls, 2)
    def upper3(self, rolls):
        self.upper(rolls, 3)
    def upper4(self, rolls):
        self.upper(rolls, 4)
    def upper5(self, rolls):
        self.upper(rolls, 5)
    def upper6(self, rolls):
        self.upper(rolls, 6)
    def upper(self, rolls, dice):
        count = rolls.count(dice)
        score = count * dice
        self.addScoreUpper(score, dice)

    def threeOfAKind(self, rolls):
        self.ofAKind(rolls, 3)
    def fourOfAKind(self, rolls):
        self.ofAKind(rolls, 4)
    def ofAKind(self, rolls, kind):
        score = 0
        for i in range(1, 7):
            if rolls.count(i) >= kind:
                score = rolls.count(i) * i
                break
        self.addScoreLower(score, kind+4)

    def smallStraight(self, rolls):
        options = [[1, 2, 3, 4], [2, 3, 4 ,5], [3, 4 ,5, 6]]
        score = self.straight(rolls, options, 30)
        self.addScoreLower(score, 9)

    def largeStraight(self, rolls):
        options = [[1, 2, 3, 4 ,5],[2, 3, 4 ,5, 6]]
        score = self.straight(rolls, options, 40)
        self.addScoreLower(score, 10)

    def straight(self, rolls, options, points):
        score = 0
        for i in range(len(options)):
            if set(options[i]).issubset(rolls):
                score = points
                break
        for i in range(1, 7):
            if rolls.count(i) == 5:
                score = points
                break
        return score

    def fullHouse(self, rolls):
        check2 = check3 = False
        score = 0
        for i in range(1, 7):
            if rolls.count(i) == 3:
                check3 = True
            if rolls.count(i) == 2:
                check2 = True
            if rolls.count(i) == 5:
                check2 = check3= True
                break
        if check2 and check3:
            score = 25
        self.addScoreLower(score, 11)

    def yahtzee(self, rolls):
        score = 0
        option = 0
        for i in range(1, 7):
            if rolls.count(i) == 5:
                if self._yahtzee:
                    score = 100
                else:
                    self._yahtzee = True
                    score = 50
        if score == 0: option = 12
        self.addScoreLower(score, option)

    def chance(self, rolls):
        score = 0
        for i in range(len(rolls)):
            score += rolls[i]
        self.addScoreLower(score, 13)

    def optionsScreen(self):
        print "--Upper Bracket--\n"
        for i in range(len(self._optionsUpper)):
            if i+1 not in self._blockedList:
                 print "{}. {}\n".format(i+1, self._optionsUpper[i])
        print "--Lower Bracket--\n"
        for i in range(len(self._optionsLower)):
            if i+1+len(self._optionsUpper) not in self._blockedList:
                print "{}. {}\n".format(i+len(self._optionsUpper)+1, self._optionsLower[i])

    def optionsInput(self, rolls):

        while True:
            try:
                option = int(raw_input("Choose which number to score\n"))

                if option in self._blockedList:
                    print "You already chose this option.\n"
                    self.optionsInput(rolls)
                    break
                elif option > 13 or option < 1:
                    print "Number has to be between 1 and 13.\n"
                    self.optionsInput(rolls)
                    break
                else:
                    self.optionsAddScore(option, rolls)
                    break
            except ValueError:
               print("\nWrong input! Your input has to be a number\n")
               self.optionsInput(rolls)


    def optionsAddScore(self, option, rolls):
        switcher = {
            1: self.upper1,
            2: self.upper2,
            3: self.upper3,
            4: self.upper4,
            5: self.upper5,
            6: self.upper6,
            7: self.threeOfAKind,
            8: self.fourOfAKind,
            9: self.smallStraight,
            10: self.largeStraight,
            11: self.fullHouse,
            12: self.yahtzee,
            13: self.chance,
            }
        if option not in self._blockedList: switcher[option](rolls)
