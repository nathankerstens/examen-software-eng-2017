/*
 * Main File for Yahtzee application
 * Downloaded from www.publicjoe.co.uk
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the author(s) be held liable for any damages arising from
 * the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Summary description for dieroller.
/// </summary>
class YahtzeeForm : Form
{
  // Visual Components
  private Dice[] TheDice = new Dice[5]{ null, null, null, null, null };

  private Button RollButton;
  private Button HoldButton0;
  private Button HoldButton1;
  private Button HoldButton2;
  private Button HoldButton3;
  private Button HoldButton4;

  private Button AcesButton;
  private Button TwosButton;
  private Button ThreesButton;
  private Button FoursButton;
  private Button FivesButton;
  private Button SixesButton;
  private Button ThreeOfAKindButton;
  private Button FourOfAKindButton;
  private Button FullHouseButton;
  private Button SmallStraightButton;
  private Button LargeStraightButton;
  private Button YahtzeeButton;
  private Button ChanceButton;
  private Button YahtzeeBonusButton;

  private Label AcesScore;
  private Label TwosScore;
  private Label ThreesScore;
  private Label FoursScore;
  private Label FivesScore;
  private Label SixesScore;
  private Label UpperTotalScore;
  private Label UpperTotalBonusScore;
  private Label ThreeOfAKindScore;
  private Label FourOfAKindScore;
  private Label FullHouseScore;
  private Label SmallStraightScore;
  private Label LargeStraightScore;
  private Label YahtzeeScore;
  private Label ChanceScore;
  private Label YahtzeeBonusScore;
  private Label LowerTotalScore;
  private Label TotalScore;

  private Label UpperTotalLabel;
  private Label UpperTotalBonusLabel;
  private Label LowerTotalLabel;
  private Label TotalLabel;

  private MainMenu mainMenu;

  private int RollCount = 0;
  private int ScoreCount = 0;

  private CalculateScore TheScore = new CalculateScore();

  private HighScoreTable highScoreTable = new HighScoreTable();

  /// <summary> 
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.Container components = null;

  public YahtzeeForm()
  {
    InitializeComponent();

    // Add File Menu
    MenuItem File = mainMenu.MenuItems.Add("&File");
    File.MenuItems.Add( new MenuItem( "&High Scores",
	            new EventHandler( this.FileScore_Clicked ),
	            Shortcut.CtrlH ));
    File.MenuItems.Add("-"); // Gives us a seperator
    File.MenuItems.Add( new MenuItem( "E&xit", 
	            new EventHandler( this.FileExit_Clicked ),
	            Shortcut.CtrlX ));

    // Add About Menu
    MenuItem About = mainMenu.MenuItems.Add("&About");
    About.MenuItems.Add( new MenuItem( "&About",
	             new EventHandler( this.About_Clicked ),
	             Shortcut.CtrlA ));

    // Load high score table...
    highScoreTable.Load( Application.StartupPath+@"\score.txt" );
  }

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  protected override void Dispose( bool disposing )
  {
    if( disposing )
    {
      if (components != null) 
      {
        components.Dispose();
      }
    }
    base.Dispose( disposing );
  }

  void InitializeComponent()
  {
    Random RandomScore = new Random();

    TheDice[0] = new Dice( RandomScore.Next() );
    TheDice[1] = new Dice( RandomScore.Next() );
    TheDice[2] = new Dice( RandomScore.Next() );
    TheDice[3] = new Dice( RandomScore.Next() );
    TheDice[4] = new Dice( RandomScore.Next() );

    SuspendLayout();

    //
    // myDice1
    //
    TheDice[0].Location = new Point( 90, 10 );
    TheDice[0].TabIndex = 0;

    //
    // myDice2
    //
    TheDice[1].Location = new Point( 140, 10 );
    TheDice[1].TabIndex = 0;

    //
    // myDice3
    //
    TheDice[2].Location = new Point( 190, 10 );
    TheDice[2].TabIndex = 0;

    //
    // myDice4
    //
    TheDice[3].Location = new Point( 240, 10 );
    TheDice[3].TabIndex = 0;

    //
    // myDice5
    //
    TheDice[4].Location = new Point( 290, 10 );
    TheDice[4].TabIndex = 0;

    //
    // RollButton
    //
    RollButton = new Button();
    RollButton.Text = "Roll Dice";
    RollButton.Location = new Point( 10, 30 );
    RollButton.Size = new Size( 70, 20 );
    RollButton.Click += new EventHandler(RollButton_Clicked);
    RollButton.TabIndex = 0;
    RollButton.BackColor = Color.LightGray;

    //
    // HoldButton0
    //
    HoldButton0 = new Button();
    HoldButton0.Text = "Hold";
    HoldButton0.Location = new Point( 90, 65 );
    HoldButton0.Size = new Size( 50, 20 );
    HoldButton0.Click += new EventHandler(HoldButton0_Clicked);
    HoldButton0.TabIndex = 0;
    HoldButton0.BackColor = Color.LightGray;

    //
    // HoldButton1
    //
    HoldButton1 = new Button();
    HoldButton1.Text = "Hold";
    HoldButton1.Location = new Point( 140, 65 );
    HoldButton1.Size = new Size( 50, 20 );
    HoldButton1.Click += new EventHandler(HoldButton1_Clicked);
    HoldButton1.TabIndex = 0;
    HoldButton1.BackColor = Color.LightGray;

    //
    // HoldButton2
    //
    HoldButton2 = new Button();
    HoldButton2.Text = "Hold";
    HoldButton2.Location = new Point( 190, 65 );
    HoldButton2.Size = new Size( 50, 20 );
    HoldButton2.Click += new EventHandler(HoldButton2_Clicked);
    HoldButton2.TabIndex = 0;
    HoldButton2.BackColor = Color.LightGray;
    //
    // HoldButton3
    //
    HoldButton3 = new Button();
    HoldButton3.Text = "Hold";
    HoldButton3.Location = new Point( 240, 65 );
    HoldButton3.Size = new Size( 50, 20 );
    HoldButton3.Click += new EventHandler(HoldButton3_Clicked);
    HoldButton3.TabIndex = 0;
    HoldButton3.BackColor = Color.LightGray;

    //
    // HoldButton4
    //
    HoldButton4 = new Button();
    HoldButton4.Text = "Hold";
    HoldButton4.Location = new Point( 290, 65 );
    HoldButton4.Size = new Size( 50, 20 );
    HoldButton4.Click += new EventHandler(HoldButton4_Clicked);
    HoldButton4.TabIndex = 0;
    HoldButton4.BackColor = Color.LightGray;

    //
    // AcesButton
    //
    AcesButton = new Button();
    AcesButton.Text = "Aces (Total 1's)";
    AcesButton.Location = new Point( 50, 100 );
    AcesButton.Size = new Size( 160, 20 );
    AcesButton.Click += new EventHandler(AcesButton_Clicked);
    AcesButton.TabIndex = 0;
    AcesButton.BackColor = Color.LightGray;

    //
    // AcesScore
    //
    AcesScore = new Label();
    AcesScore.Location = new Point( 220, 100 );
    AcesScore.TabIndex = 0;
    AcesScore.Text = "";
    AcesScore.Size = new Size( 70, 20 );
    AcesScore.TextAlign = ContentAlignment.MiddleCenter;
    AcesScore.BackColor = Color.White;
    AcesScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // TwosButton
    //
    TwosButton = new Button();
    TwosButton.Text = "Twos (Total 2's)";
    TwosButton.Location = new Point( 50, 120 );
    TwosButton.Size = new Size( 160, 20 );
    TwosButton.Click += new EventHandler(TwosButton_Clicked);
    TwosButton.TabIndex = 0;
    TwosButton.BackColor = Color.LightGray;

    //
    // TwosScore
    //
    TwosScore = new Label();
    TwosScore.Location = new Point( 220, 120 );
    TwosScore.TabIndex = 0;
    TwosScore.Text = "";
    TwosScore.Size = new Size( 70, 20 );
    TwosScore.TextAlign = ContentAlignment.MiddleCenter;
    TwosScore.BackColor = Color.White;
    TwosScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // ThreesButton
    //
    ThreesButton = new Button();
    ThreesButton.Text = "Threes (Total 3's)";
    ThreesButton.Location = new Point( 50, 140 );
    ThreesButton.Size = new Size( 160, 20 );
    ThreesButton.Click += new EventHandler(ThreesButton_Clicked);
    ThreesButton.TabIndex = 0;
    ThreesButton.BackColor = Color.LightGray;

    //
    // ThreesScore
    //
    ThreesScore = new Label();
    ThreesScore.Location = new Point( 220, 140 );
    ThreesScore.TabIndex = 0;
    ThreesScore.Text = "";
    ThreesScore.Size = new Size( 70, 20 );
    ThreesScore.TextAlign = ContentAlignment.MiddleCenter;
    ThreesScore.BackColor = Color.White;
    ThreesScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // FoursButton
    //
    FoursButton = new Button();
    FoursButton.Text = "Fours (Total 4's)";
    FoursButton.Location = new Point( 50, 160 );
    FoursButton.Size = new Size( 160, 20 );
    FoursButton.Click += new EventHandler(FoursButton_Clicked);
    FoursButton.TabIndex = 0;
    FoursButton.BackColor = Color.LightGray;

    //
    // FoursScore
    //
    FoursScore = new Label();
    FoursScore.Location = new Point( 220, 160 );
    FoursScore.TabIndex = 0;
    FoursScore.Text = "";
    FoursScore.Size = new Size( 70, 20 );
    FoursScore.TextAlign = ContentAlignment.MiddleCenter;
    FoursScore.BackColor = Color.White;
    FoursScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // FivesButton
    //
    FivesButton = new Button();
    FivesButton.Text = "Fives (Total 5's)";
    FivesButton.Location = new Point( 50, 180 );
    FivesButton.Size = new Size( 160, 20 );
    FivesButton.Click += new EventHandler(FivesButton_Clicked);
    FivesButton.TabIndex = 0;
    FivesButton.BackColor = Color.LightGray;

    //
    // FivesScore
    //
    FivesScore = new Label();
    FivesScore.Location = new Point( 220, 180 );
    FivesScore.TabIndex = 0;
    FivesScore.Text = "";
    FivesScore.Size = new Size( 70, 20 );
    FivesScore.TextAlign = ContentAlignment.MiddleCenter;
    FivesScore.BackColor = Color.White;
    FivesScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // SixesButton
    //
    SixesButton = new Button();
    SixesButton.Text = "Sixes (Total 6's)";
    SixesButton.Location = new Point( 50, 200 );
    SixesButton.Size = new Size( 160, 20 );
    SixesButton.Click += new EventHandler(SixesButton_Clicked);
    SixesButton.TabIndex = 0;
    SixesButton.BackColor = Color.LightGray;

    //
    // SixesScore
    //
    SixesScore = new Label();
    SixesScore.Location = new Point( 220, 200 );
    SixesScore.TabIndex = 0;
    SixesScore.Text = "";
    SixesScore.Size = new Size( 70, 20 );
    SixesScore.TextAlign = ContentAlignment.MiddleCenter;
    SixesScore.BackColor = Color.White;
    SixesScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // UpperTotalLabel
    //
    UpperTotalLabel = new Label();
    UpperTotalLabel.Location = new Point( 50, 220 );
    UpperTotalLabel.Name = "UpperTotalLabel";
    UpperTotalLabel.Size = new Size( 160, 20 );
    UpperTotalLabel.Text = "Upper Total :";
    UpperTotalLabel.TextAlign = ContentAlignment.MiddleRight;
    UpperTotalLabel.Font = new Font(UpperTotalLabel.Font, FontStyle.Bold);

    //
    // UpperTotalScore
    //
    UpperTotalScore = new Label();
    UpperTotalScore.Location = new Point( 220, 220 );
    UpperTotalScore.TabIndex = 0;
    UpperTotalScore.Text = TheScore.UpperTotalScore.ToString();
    UpperTotalScore.Size = new Size( 70, 20 );
    UpperTotalScore.TextAlign = ContentAlignment.MiddleCenter;
    UpperTotalScore.BackColor = Color.White;
    UpperTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // UpperTotalBonusLabel
    //
    UpperTotalBonusLabel = new Label();
    UpperTotalBonusLabel.Location = new Point( 120, 240 );
    UpperTotalBonusLabel.Name = "UpperTotalBonusLabel";
    UpperTotalBonusLabel.Size = new Size( 90, 20 );
    UpperTotalBonusLabel.Text = "Bonus :";
    UpperTotalBonusLabel.TextAlign = ContentAlignment.MiddleRight;
    UpperTotalBonusLabel.Font = new Font(UpperTotalBonusLabel.Font, FontStyle.Bold);

    //
    // UpperTotalBonusScore
    //
    UpperTotalBonusScore = new Label();
    UpperTotalBonusScore.Location = new Point( 220, 240 );
    UpperTotalBonusScore.TabIndex = 0;
    UpperTotalBonusScore.Text = "0";
    UpperTotalBonusScore.Size = new Size( 70, 20 );
    UpperTotalBonusScore.TextAlign = ContentAlignment.MiddleCenter;
    UpperTotalBonusScore.BackColor = Color.White;
    UpperTotalBonusScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // ThreeOfAKindButton
    //
    ThreeOfAKindButton = new Button();
    ThreeOfAKindButton.Text = "Three of a Kind (Total Dice)";
    ThreeOfAKindButton.Location = new Point( 50, 260 );
    ThreeOfAKindButton.Size = new Size( 160, 20 );
    ThreeOfAKindButton.Click += new EventHandler(ThreeOfAKindButton_Clicked);
    ThreeOfAKindButton.TabIndex = 0;
    ThreeOfAKindButton.BackColor = Color.LightGray;

    //
    // ThreeOfAKindScore
    //
    ThreeOfAKindScore = new Label();
    ThreeOfAKindScore.Location = new Point( 220, 260 );
    ThreeOfAKindScore.TabIndex = 0;
    ThreeOfAKindScore.Text = "";
    ThreeOfAKindScore.Size = new Size( 70, 20 );
    ThreeOfAKindScore.TextAlign = ContentAlignment.MiddleCenter;
    ThreeOfAKindScore.BackColor = Color.White;
    ThreeOfAKindScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // FourOfAKindButton
    //
    FourOfAKindButton = new Button();
    FourOfAKindButton.Text = "Four of a Kind (Total Dice)";
    FourOfAKindButton.Location = new Point( 50, 280 );
    FourOfAKindButton.Size = new Size( 160, 20 );
    FourOfAKindButton.Click += new EventHandler(FourOfAKindButton_Clicked);
    FourOfAKindButton.TabIndex = 0;
    FourOfAKindButton.BackColor = Color.LightGray;

    //
    // FourOfAKindScore
    //
    FourOfAKindScore = new Label();
    FourOfAKindScore.Location = new Point( 220, 280 );
    FourOfAKindScore.TabIndex = 0;
    FourOfAKindScore.Text = "";
    FourOfAKindScore.Size = new Size( 70, 20 );
    FourOfAKindScore.TextAlign = ContentAlignment.MiddleCenter;
    FourOfAKindScore.BackColor = Color.White;
    FourOfAKindScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // FullHouseButton
    //
    FullHouseButton = new Button();
    FullHouseButton.Text = "Full House (Score 25)";
    FullHouseButton.Location = new Point( 50, 300 );
    FullHouseButton.Size = new Size( 160, 20 );
    FullHouseButton.Click += new EventHandler(FullHouseButton_Clicked);
    FullHouseButton.TabIndex = 0;
    FullHouseButton.BackColor = Color.LightGray;

    //
    // FullHouseScore
    //
    FullHouseScore = new Label();
    FullHouseScore.Location = new Point( 220, 300 );
    FullHouseScore.TabIndex = 0;
    FullHouseScore.Text = "";
    FullHouseScore.Size = new Size( 70, 20 );
    FullHouseScore.TextAlign = ContentAlignment.MiddleCenter;
    FullHouseScore.BackColor = Color.White;
    FullHouseScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // SmallStraightButton
    //
    SmallStraightButton = new Button();
    SmallStraightButton.Text = "Small Straight (Score 30)";
    SmallStraightButton.Location = new Point( 50, 320 );
    SmallStraightButton.Size = new Size( 160, 20 );
    SmallStraightButton.Click += new EventHandler(SmallStraightButton_Clicked);
    SmallStraightButton.TabIndex = 0;
    SmallStraightButton.BackColor = Color.LightGray;

    //
    // SmallStraightScore
    //
    SmallStraightScore = new Label();
    SmallStraightScore.Location = new Point( 220, 320 );
    SmallStraightScore.TabIndex = 0;
    SmallStraightScore.Text = "";
    SmallStraightScore.Size = new Size( 70, 20 );
    SmallStraightScore.TextAlign = ContentAlignment.MiddleCenter;
    SmallStraightScore.BackColor = Color.White;
    SmallStraightScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // LargeStraightButton
    //
    LargeStraightButton = new Button();
    LargeStraightButton.Text = "Large Straight (Score 40)";
    LargeStraightButton.Location = new Point( 50, 340 );
    LargeStraightButton.Size = new Size( 160, 20 );
    LargeStraightButton.Click += new EventHandler(LargeStraightButton_Clicked);
    LargeStraightButton.TabIndex = 0;
    LargeStraightButton.BackColor = Color.LightGray;

    //
    // LargeStraightScore
    //
    LargeStraightScore = new Label();
    LargeStraightScore.Location = new Point( 220, 340 );
    LargeStraightScore.TabIndex = 0;
    LargeStraightScore.Text = "";
    LargeStraightScore.Size = new Size( 70, 20 );
    LargeStraightScore.TextAlign = ContentAlignment.MiddleCenter;
    LargeStraightScore.BackColor = Color.White;
    LargeStraightScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // YahtzeeButton
    //
    YahtzeeButton = new Button();
    YahtzeeButton.Text = "Yahtzee (Score 50)";
    YahtzeeButton.Location = new Point( 50, 360 );
    YahtzeeButton.Size = new Size( 160, 20 );
    YahtzeeButton.Click += new EventHandler(YahtzeeButton_Clicked);
    YahtzeeButton.TabIndex = 0;
    YahtzeeButton.BackColor = Color.LightGray;

    //
    // YahtzeeScore
    //
    YahtzeeScore = new Label();
    YahtzeeScore.Location = new Point( 220, 360 );
    YahtzeeScore.TabIndex = 0;
    YahtzeeScore.Text = "";
    YahtzeeScore.Size = new Size( 70, 20 );
    YahtzeeScore.TextAlign = ContentAlignment.MiddleCenter;
    YahtzeeScore.BackColor = Color.White;
    YahtzeeScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // ChanceButton
    //
    ChanceButton = new Button();
    ChanceButton.Text = "Chance (Total Dice)";
    ChanceButton.Location = new Point( 50, 380 );
    ChanceButton.Size = new Size( 160, 20 );
    ChanceButton.Click += new EventHandler(ChanceButton_Clicked);
    ChanceButton.TabIndex = 0;
    ChanceButton.BackColor = Color.LightGray;

    //
    // ChanceScore
    //
    ChanceScore = new Label();
    ChanceScore.Location = new Point( 220, 380 );
    ChanceScore.TabIndex = 0;
    ChanceScore.Text = "";
    ChanceScore.Size = new Size( 70, 20 );
    ChanceScore.TextAlign = ContentAlignment.MiddleCenter;
    ChanceScore.BackColor = Color.White;
    ChanceScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // YahtzeeBonusButton
    //
    YahtzeeBonusButton = new Button();
    YahtzeeBonusButton.Text = "Yahtzee Bonus (Score 100)";
    YahtzeeBonusButton.Location = new Point( 50, 400 );
    YahtzeeBonusButton.Size = new Size( 160, 20 );
    YahtzeeBonusButton.Click += new EventHandler(YahtzeeBonusButton_Clicked);
    YahtzeeBonusButton.TabIndex = 0;
    YahtzeeBonusButton.BackColor = Color.LightGray;

    //
    // YahtzeeBonusScore
    //
    YahtzeeBonusScore = new Label();
    YahtzeeBonusScore.Location = new Point( 220, 400 );
    YahtzeeBonusScore.TabIndex = 0;
    YahtzeeBonusScore.Text = "";
    YahtzeeBonusScore.Size = new Size( 70, 20 );
    YahtzeeBonusScore.TextAlign = ContentAlignment.MiddleCenter;
    YahtzeeBonusScore.BackColor = Color.White;
    YahtzeeBonusScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // LowerTotalLabel
    //
    LowerTotalLabel = new Label();
    LowerTotalLabel.Location = new Point( 50, 420 );
    LowerTotalLabel.Name = "LowerTotalLabel";
    LowerTotalLabel.Size = new Size( 160, 20 );
    LowerTotalLabel.Text = "Lower Total :";
    LowerTotalLabel.TextAlign = ContentAlignment.MiddleRight;
    LowerTotalLabel.Font = new Font(LowerTotalLabel.Font, FontStyle.Bold);

    //
    // LowerTotalScore
    //
    LowerTotalScore = new Label();
    LowerTotalScore.Location = new Point( 220, 420 );
    LowerTotalScore.TabIndex = 0;
    LowerTotalScore.Text = TheScore.LowerTotalScore.ToString();
    LowerTotalScore.Size = new Size( 70, 20 );
    LowerTotalScore.TextAlign = ContentAlignment.MiddleCenter;
    LowerTotalScore.BackColor = Color.White;
    LowerTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    //
    // TotalLabel
    //
    TotalLabel = new Label();
    TotalLabel.Location = new Point( 50, 460 );
    TotalLabel.Name = "TotalLabel";
    TotalLabel.Size = new Size( 160, 20 );
    TotalLabel.Text = "Total :";
    TotalLabel.TextAlign = ContentAlignment.MiddleRight;
    TotalLabel.Font = new Font(TotalLabel.Font, FontStyle.Bold);

    //
    // TotalScore
    //
    TotalScore = new Label();
    TotalScore.Location = new Point( 220, 460 );
    TotalScore.TabIndex = 0;
    TotalScore.Text = TheScore.TotalScore.ToString();
    TotalScore.Size = new Size( 70, 20 );
    TotalScore.TextAlign = ContentAlignment.MiddleCenter;
    TotalScore.BackColor = Color.White;
    TotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;  

    this.Controls.AddRange(new System.Windows.Forms.Control[] { TheDice[0],
                                                                TheDice[1],
                                                                TheDice[2],
                                                                TheDice[3],
                                                                TheDice[4],
                                                                RollButton,
                                                                HoldButton0,
                                                                HoldButton1,
                                                                HoldButton2,
                                                                HoldButton3,
                                                                HoldButton4,
                                                                AcesButton,
                                                                TwosButton,
                                                                ThreesButton,
                                                                FoursButton,
                                                                FivesButton,
                                                                SixesButton,
                                                                AcesScore,
                                                                TwosScore,
                                                                ThreesScore,
                                                                FoursScore,
                                                                FivesScore,
                                                                SixesScore,
                                                                UpperTotalLabel,
                                                                UpperTotalScore,
                                                                UpperTotalBonusLabel,
                                                                UpperTotalBonusScore,
                                                                ThreeOfAKindButton,
                                                                ThreeOfAKindScore,
                                                                FourOfAKindButton,
                                                                FourOfAKindScore,
                                                                FullHouseButton,
                                                                FullHouseScore,
                                                                SmallStraightButton,
                                                                SmallStraightScore,
                                                                LargeStraightButton,
                                                                LargeStraightScore,
                                                                YahtzeeButton,
                                                                YahtzeeScore,
                                                                ChanceButton,
                                                                ChanceScore,
                                                                YahtzeeBonusButton,
                                                                YahtzeeBonusScore,
                                                                LowerTotalLabel,
                                                                LowerTotalScore,
                                                                TotalLabel,
                                                                TotalScore });

    // Add main menu component
    mainMenu = new MainMenu();

    this.ClientSize = new Size( 350, 500 );
    this.Name = "Yahtzee";
    this.Text = "Yahtzee";
    this.BackColor = Color.Green;
    this.ResumeLayout(false);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.MaximizeBox = false;
    this.Menu = mainMenu;
  }

  private void RollButton_Clicked( object ob, EventArgs e )
  {
    if( RollCount < 3 )
    {
      if( RollCount == 0 )
      {
        TheDice[0].HoldState = false;
        TheDice[1].HoldState = false;
        TheDice[2].HoldState = false;
        TheDice[3].HoldState = false;
        TheDice[4].HoldState = false;

        HoldButton0.Text = "Hold";
        HoldButton1.Text = "Hold";
        HoldButton2.Text = "Hold";
        HoldButton3.Text = "Hold";
        HoldButton4.Text = "Hold";
      }

      TheDice[0].Roll();
      TheDice[1].Roll();
      TheDice[2].Roll();
      TheDice[3].Roll();
      TheDice[4].Roll();

      RollCount++;

      if( RollCount == 3 )
      {
        TheDice[0].HoldState = true;
        TheDice[1].HoldState = true;
        TheDice[2].HoldState = true;
        TheDice[3].HoldState = true;
        TheDice[4].HoldState = true;
      }
    }
  }

  private void HoldButton0_Clicked( object ob, EventArgs e )
  {
    if( RollCount != 0 )
    {
      if( TheDice[0].HoldState == true )
      {
        TheDice[0].HoldState = false;
        HoldButton0.Text = "Hold";
      }
      else
      {
        TheDice[0].HoldState = true;
        HoldButton0.Text = "Free";
      }
    }
  }

  private void HoldButton1_Clicked( object ob, EventArgs e )
  {
    if( RollCount != 0 )
    {
      if( TheDice[1].HoldState == true )
      {
        TheDice[1].HoldState = false;
        HoldButton1.Text = "Hold";
      }
      else
      {
        TheDice[1].HoldState = true;
        HoldButton1.Text = "Free";
      }
    }
  }

  private void HoldButton2_Clicked( object ob, EventArgs e )
  {
    if( RollCount != 0 )
    {
      if( TheDice[2].HoldState == true )
      {
        TheDice[2].HoldState = false;
        HoldButton2.Text = "Hold";
      }
      else
      {
        TheDice[2].HoldState = true;
        HoldButton2.Text = "Free";
      }
    }
  }

  private void HoldButton3_Clicked( object ob, EventArgs e )
  {
    if( RollCount != 0 )
    {
      if( TheDice[3].HoldState == true )
      {
        TheDice[3].HoldState = false;
        HoldButton3.Text = "Hold";
      }
      else
      {
        TheDice[3].HoldState = true;
        HoldButton3.Text = "Free";
      }
    }
  }

  private void HoldButton4_Clicked( object ob, EventArgs e )
  {
    if( RollCount != 0 )
    {
      if( TheDice[4].HoldState == true )
      {
        TheDice[4].HoldState = false;
        HoldButton4.Text = "Hold";
      }
      else
      {
        TheDice[4].HoldState = true;
        HoldButton4.Text = "Free";
      }
    }
  }

  private void AcesButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (AcesScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(1, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Aces Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        AcesScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void TwosButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (TwosScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(2, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Twos Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        TwosScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void ThreesButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (ThreesScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(3, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Threes Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        ThreesScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void FoursButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (FoursScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(4, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Fours Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        FoursScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void FivesButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (FivesScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(5, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Fives Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        FivesScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void SixesButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (SixesScore.Text == "") )
    {
      int Score = TheScore.AddUpDice(6, TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Sixes Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        SixesScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, true );
        Reset();
      }
    }
  }

  private void ThreeOfAKindButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (ThreeOfAKindScore.Text == "") )
    {
      int Score = TheScore.CalculateThreeOfAKind( TheDice );

      if( Score != 0 )
      {
        string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( message, 
	                      "Three of a Kind Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          ThreeOfAKindScore.Text = Score.ToString();
          TheScore.UpdateTotals( Score, false );
          Reset();
        }
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Three of a Kind. Do you wish to accept this?", 
	                      "Three of a Kind Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          ThreeOfAKindScore.Text = "0";
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void FourOfAKindButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (FourOfAKindScore.Text == "") )
    {
      int Score = TheScore.CalculateFourOfAKind( TheDice );

      if( Score != 0 )
      {
        string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( message, 
	                      "Four of a Kind Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          FourOfAKindScore.Text = Score.ToString();
          TheScore.UpdateTotals( Score, false );
          Reset();
        }
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Four of a Kind. Do you wish to accept this?", 
	                      "Four of a Kind Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          FourOfAKindScore.Text = "0";
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void FullHouseButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (FullHouseScore.Text == "") )
    {
      int Score = TheScore.CalculateFullHouse( TheDice );

      if( Score == 25 )
      {
        FullHouseScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, false );
        Reset();
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Full House. Do you wish to accept this?", 
	                      "Full House Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          FullHouseScore.Text = "0";
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void SmallStraightButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (SmallStraightScore.Text == "") )
    {
      int Score = TheScore.CalculateSmallStraight( TheDice );

      if( Score == 30 )
      {
        SmallStraightScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, false );
        Reset();
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Small Straight. Do you wish to accept this?", 
	                      "Small Straight Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          SmallStraightScore.Text = "0";
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void LargeStraightButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (LargeStraightScore.Text == "") )
    {
      int Score = TheScore.CalculateLargeStraight( TheDice );

      if( Score == 40 )
      {
        LargeStraightScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, false );
        Reset();
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Large Straight. Do you wish to accept this?", 
	                      "Large Straight Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          LargeStraightScore.Text = "0";
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void YahtzeeButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (YahtzeeScore.Text == "") )
    {
      int Score = TheScore.CalculateYahtzee( TheDice );

      if( Score == 50 )
      {
        YahtzeeScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, false );
        Reset();
      }
      else
      {
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show( "There is no Yahtzee. Do you wish to accept this?", 
	                      "Yahtzee Total", 
	                      MessageBoxButtons.YesNo, 
	                      MessageBoxIcon.Question );

        if(result == DialogResult.Yes)
        {
          YahtzeeScore.Text = "0";
          YahtzeeBonusScore.Text = "0";
          ScoreCount++;
          TheScore.UpdateTotals( Score, true );
          Reset();
        }
      }
    }
  }

  private void ChanceButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (ChanceScore.Text == "") )
    {
      int Score = TheScore.AddUpChance(TheDice);

      string message = "The Total is " + Score.ToString() + ". Do you wish to accept this?";
      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( message, 
	                    "Chance Total", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if(result == DialogResult.Yes)
      {
        ChanceScore.Text = Score.ToString();
        TheScore.UpdateTotals( Score, false );
        Reset();
      }
    }
  }

  private void YahtzeeBonusButton_Clicked( object ob, EventArgs e )
  {
    if( (RollCount > 0) && (YahtzeeBonusScore.Text == "") && (YahtzeeScore.Text != ""))
    {
      int Score = TheScore.CalculateYahtzee( TheDice );

      if( Score == 50 )
      {
        YahtzeeBonusScore.Text = "100";
        TheScore.UpdateTotals( 100, false );
        Reset();
      }
      else
      {
        YahtzeeBonusScore.Text = "0";
        TheScore.UpdateTotals( 0, true );
        Reset();
      }
    }
  }

  private void Reset()
  {
    RollCount = 0;
    ScoreCount++;
    HoldButton0.Text = "Hold";
    HoldButton1.Text = "Hold";
    HoldButton2.Text = "Hold";
    HoldButton3.Text = "Hold";
    HoldButton4.Text = "Hold";

    TheDice[0].HoldState = true;
    TheDice[1].HoldState = true;
    TheDice[2].HoldState = true;
    TheDice[3].HoldState = true;
    TheDice[4].HoldState = true;

    UpperTotalScore.Text = TheScore.UpperTotalScore.ToString();
    if( TheScore.UpperBonus == true )
      UpperTotalBonusScore.Text = "35";
    else
      UpperTotalBonusScore.Text = "0";

    LowerTotalScore.Text = TheScore.LowerTotalScore.ToString();
    TotalScore.Text = TheScore.TotalScore.ToString();

    if( ScoreCount == 14 )
    {
      CheckHighScore();

      DialogResult result;

      // Displays the MessageBox.
      result = MessageBox.Show( "Your Score is " + TotalScore.Text + ". Would You like to play again?", 
	                    "End Of Game", 
	                    MessageBoxButtons.YesNo, 
	                    MessageBoxIcon.Question );

      if( result == DialogResult.Yes )
      {
        // Reset Everything
        TheScore.ResetScores();
        RollCount = 0;
        ScoreCount = 0;
        HoldButton0.Text = "Hold";
        HoldButton1.Text = "Hold";
        HoldButton2.Text = "Hold";
        HoldButton3.Text = "Hold";
        HoldButton4.Text = "Hold";
        UpperTotalScore.Text = TheScore.UpperTotalScore.ToString();
        UpperTotalBonusScore.Text = "0";
        LowerTotalScore.Text = TheScore.LowerTotalScore.ToString();
        TotalScore.Text = TheScore.TotalScore.ToString();
        AcesScore.Text = "";
        TwosScore.Text = "";
        ThreesScore.Text = "";
        FoursScore.Text = "";
        FivesScore.Text = "";
        SixesScore.Text = "";
        ThreeOfAKindScore.Text = "";
        FourOfAKindScore.Text = "";
        FullHouseScore.Text = "";
        SmallStraightScore.Text = "";
        LargeStraightScore.Text = "";
        YahtzeeScore.Text = "";
        ChanceScore.Text = "";
        YahtzeeBonusScore.Text = "";

        TheDice[0].HoldState = true;
        TheDice[0].RollNumber = 1;
        TheDice[1].HoldState = true;
        TheDice[1].RollNumber = 1;
        TheDice[2].HoldState = true;
        TheDice[2].RollNumber = 1;
        TheDice[3].HoldState = true;
        TheDice[3].RollNumber = 1;
        TheDice[4].HoldState = true;
        TheDice[4].RollNumber = 1;
      }
      else
      {
        this.Close();
      }
    }
  } 

  // File->Exit Menu item handler
  private void FileExit_Clicked( object sender, System.EventArgs e )
  {
    this.Close();
  }

  // File->High Scores Menu item handler
  private void FileScore_Clicked( object sender, System.EventArgs e )
  {
    HighScore HighScoreForm = new HighScore( highScoreTable );
    HighScoreForm.StartPosition = FormStartPosition.CenterScreen;
    HighScoreForm.Show();
  }

  // About->About Menu item handler
  private void About_Clicked( object sender, System.EventArgs e )
  {
    AboutFrm myAbout = new AboutFrm();
    myAbout.Show();
  }

  private void CheckHighScore()
  {
    highScoreTable.Load( Application.StartupPath+@"\score.txt" );

    int score = Int32.Parse(TotalScore.Text);

    int scoreIndex = highScoreTable.GetIndexOfScore( score );

    if( scoreIndex > -1 )
    {
      string name = "";
      using( Form2 aForm = new Form2() )
      {
        aForm.StartPosition = FormStartPosition.CenterScreen;

        if( aForm.ShowDialog() == DialogResult.OK )
        {
          name = aForm.textBox1.Text;

          highScoreTable.Update( name, score );
        }
      }
    }
  }

  public static void Main(string[] args)
  {
    Application.Run( new YahtzeeForm() );
  }
}
