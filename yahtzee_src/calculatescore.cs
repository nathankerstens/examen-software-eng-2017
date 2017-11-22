
using System;


public class CalculateScore
{
  private int Total = 0;
  public int TotalScore
  {
    get { return Total; }	
  }

  private int UpperTotal = 0;
  public int UpperTotalScore
  {
    get {	return UpperTotal; }
  }

  private int LowerTotal = 0;
  public int LowerTotalScore
  {
    get {	return LowerTotal; }
  }

  public bool UpperBonus = false;

  public CalculateScore()
  {
  }

  public void ResetScores()
  {
    Total = 0;
    UpperTotal = 0;
    LowerTotal = 0;
    UpperBonus = false;
  }

  public void UpdateTotals( int Score, bool UpperScore )
  {
    if( UpperScore == true )
    {
      UpperTotal += Score;
      if( UpperTotal >= 63 )
        UpperBonus = true;
    }
    else
    {
      LowerTotal += Score;
    }

    Total = 0;
    Total += UpperTotal;
    if( UpperBonus == true )
      Total += 35;
    Total += LowerTotal;
  }

  public int AddUpDice( int DieNumber, Dice[] myDice )
  {
    int Sum = 0;

    for( int i = 0; i < 5; i++ )
    {
      if( myDice[i].RollNumber == DieNumber )
      {
        Sum += DieNumber;
      }
    }

    return Sum;
  }

 
  ///Three of a Kind Score
  public int CalculateThreeOfAKind( Dice[] myDice )
  {
    int Sum = 0;

    bool ThreeOfAKind = false;

    for( int i = 1; i <= 6; i++ )
    {
      int Count = 0;
      for( int j = 0; j < 5; j++ )
      {
        if( myDice[j].RollNumber == i )
        Count++;

        if( Count > 2 )
        ThreeOfAKind = true;
      }
    }

    if( ThreeOfAKind )
    {
      for( int k = 0; k < 5; k++ )
      {
        Sum += myDice[k].RollNumber;
      }
    }

    return Sum;
  }

 
  /// Four of a Kind Score
  public int CalculateFourOfAKind( Dice[] myDice )
  {
    int Sum = 0;

    bool FourOfAKind = false;

    for( int i = 1; i <= 6; i++ )
    {
      int Count = 0;
      for( int j = 0; j < 5; j++ )
      {
        if( myDice[j].RollNumber == i )
        Count++;

        if( Count > 3 )
        FourOfAKind = true;
      }
    }

    if( FourOfAKind )
    {
      for( int k = 0; k < 5; k++ )
      {
        Sum += myDice[k].RollNumber;
      }
    }

    return Sum;
  }


  ///Full House Score

  public int CalculateFullHouse( Dice[] myDice )
  {
    int Sum = 0;

    int[] i = new int[5];

    i[0] = myDice[0].RollNumber;
    i[1] = myDice[1].RollNumber;
    i[2] = myDice[2].RollNumber;
    i[3] = myDice[3].RollNumber;
    i[4] = myDice[4].RollNumber;

    Array.Sort(i);

    if( (((i[0] == i[1]) && (i[1] == i[2])) && // Three of a Kind
         (i[3] == i[4]) && // Two of a Kind
         (i[2] != i[3])) ||
        ((i[0] == i[1]) && // Two of a Kind
         ((i[2] == i[3]) && (i[3] == i[4])) && // Three of a Kind
         (i[1] != i[2])) )
    {
      Sum = 25;
    }

    return Sum;
  }

  /// Small Straight Score

  public int CalculateSmallStraight( Dice[] myDice )
  {
    int Sum = 0;

    int[] i = new int[5];

    i[0] = myDice[0].RollNumber;
    i[1] = myDice[1].RollNumber;
    i[2] = myDice[2].RollNumber;
    i[3] = myDice[3].RollNumber;
    i[4] = myDice[4].RollNumber;

    Array.Sort(i);

    for( int j = 0; j < 4; j++ )
    {
      int temp = 0;
      if( i[j] == i[j+1] )
      {
        temp = i[j];

        for( int k = j; k < 4; k++ )
        {
          i[k] = i[k+1];
        }
      
        i[4] = temp;
      }
    }

    if( ((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
        ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
        ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
        ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
        ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
        ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)) )
    {
      Sum = 30;
    }

    return Sum;
  }


  ///Large Straight Score

  public int CalculateLargeStraight( Dice[] myDice )
  {
    int Sum = 0;

    int[] i = new int[5];

    i[0] = myDice[0].RollNumber;
    i[1] = myDice[1].RollNumber;
    i[2] = myDice[2].RollNumber;
    i[3] = myDice[3].RollNumber;
    i[4] = myDice[4].RollNumber;

    Array.Sort(i);

    if( ((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
        ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)) )
    {
      Sum = 40;
    }

    return Sum;
  }

  /// Yahtzee Score
 
  public int CalculateYahtzee( Dice[] myDice )
  {
    int Sum = 0;

    for( int i = 1; i <= 6; i++ )
    {
      int Count = 0;
      for( int j = 0; j < 5; j++ )
      {
        if( myDice[j].RollNumber == i )
        Count++;

        if( Count > 4 )
        Sum = 50;
      }
    }

    return Sum;
  }

  public int AddUpChance( Dice[] myDice )
  {
    int Sum = 0;

    for( int i = 0; i < 5; i++ )
    {
      Sum += myDice[i].RollNumber;
    }

    return Sum;
  }
}