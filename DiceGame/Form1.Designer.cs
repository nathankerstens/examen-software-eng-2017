namespace DiceGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_p1dice5 = new System.Windows.Forms.Label();
            this.lbl_p1dice3 = new System.Windows.Forms.Label();
            this.lbl_p1dice2 = new System.Windows.Forms.Label();
            this.lbl_p1dice4 = new System.Windows.Forms.Label();
            this.lbl_p1dice1 = new System.Windows.Forms.Label();
            this.btn_p1_rollDice = new System.Windows.Forms.Button();
            this.lbl_p1displayResults = new System.Windows.Forms.Label();
            this.lbl_p2displayResults = new System.Windows.Forms.Label();
            this.btn_p2_rollDice = new System.Windows.Forms.Button();
            this.lbl_p2dice5 = new System.Windows.Forms.Label();
            this.lbl_p2dice3 = new System.Windows.Forms.Label();
            this.lbl_p2dice2 = new System.Windows.Forms.Label();
            this.lbl_p2dice4 = new System.Windows.Forms.Label();
            this.lbl_p2dice1 = new System.Windows.Forms.Label();
            this.lbl_winnerResult = new System.Windows.Forms.Label();
            this.lbl_p1Name = new System.Windows.Forms.Label();
            this.lbl_p2Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_p1dice5
            // 
            this.lbl_p1dice5.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice5.Location = new System.Drawing.Point(476, 304);
            this.lbl_p1dice5.Name = "lbl_p1dice5";
            this.lbl_p1dice5.Size = new System.Drawing.Size(90, 90);
            this.lbl_p1dice5.TabIndex = 4;
            // 
            // lbl_p1dice3
            // 
            this.lbl_p1dice3.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice3.Location = new System.Drawing.Point(284, 304);
            this.lbl_p1dice3.Name = "lbl_p1dice3";
            this.lbl_p1dice3.Size = new System.Drawing.Size(90, 90);
            this.lbl_p1dice3.TabIndex = 3;
            // 
            // lbl_p1dice2
            // 
            this.lbl_p1dice2.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice2.Location = new System.Drawing.Point(188, 304);
            this.lbl_p1dice2.Name = "lbl_p1dice2";
            this.lbl_p1dice2.Size = new System.Drawing.Size(90, 90);
            this.lbl_p1dice2.TabIndex = 2;
            // 
            // lbl_p1dice4
            // 
            this.lbl_p1dice4.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice4.Location = new System.Drawing.Point(380, 304);
            this.lbl_p1dice4.Name = "lbl_p1dice4";
            this.lbl_p1dice4.Size = new System.Drawing.Size(90, 90);
            this.lbl_p1dice4.TabIndex = 1;
            // 
            // lbl_p1dice1
            // 
            this.lbl_p1dice1.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p1dice1.Location = new System.Drawing.Point(92, 304);
            this.lbl_p1dice1.Name = "lbl_p1dice1";
            this.lbl_p1dice1.Size = new System.Drawing.Size(90, 90);
            this.lbl_p1dice1.TabIndex = 0;
            // 
            // btn_p1_rollDice
            // 
            this.btn_p1_rollDice.Location = new System.Drawing.Point(228, 514);
            this.btn_p1_rollDice.Name = "btn_p1_rollDice";
            this.btn_p1_rollDice.Size = new System.Drawing.Size(220, 70);
            this.btn_p1_rollDice.TabIndex = 5;
            this.btn_p1_rollDice.Text = "Roll Dice!";
            this.btn_p1_rollDice.UseVisualStyleBackColor = true;
            this.btn_p1_rollDice.Click += new System.EventHandler(this.btn_p1_rollDice_Click);
            // 
            // lbl_p1displayResults
            // 
            this.lbl_p1displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1displayResults.Location = new System.Drawing.Point(19, 646);
            this.lbl_p1displayResults.Name = "lbl_p1displayResults";
            this.lbl_p1displayResults.Size = new System.Drawing.Size(640, 182);
            this.lbl_p1displayResults.TabIndex = 6;
            this.lbl_p1displayResults.Text = "Roll the dice";
            this.lbl_p1displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1displayResults.Click += new System.EventHandler(this.lbl_displayResults_Click);
            // 
            // lbl_p2displayResults
            // 
            this.lbl_p2displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2displayResults.Location = new System.Drawing.Point(796, 646);
            this.lbl_p2displayResults.Name = "lbl_p2displayResults";
            this.lbl_p2displayResults.Size = new System.Drawing.Size(640, 182);
            this.lbl_p2displayResults.TabIndex = 13;
            this.lbl_p2displayResults.Text = "Roll the dice";
            this.lbl_p2displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_p2_rollDice
            // 
            this.btn_p2_rollDice.Location = new System.Drawing.Point(997, 523);
            this.btn_p2_rollDice.Name = "btn_p2_rollDice";
            this.btn_p2_rollDice.Size = new System.Drawing.Size(220, 70);
            this.btn_p2_rollDice.TabIndex = 12;
            this.btn_p2_rollDice.Text = "Roll Dice!";
            this.btn_p2_rollDice.UseVisualStyleBackColor = true;
            this.btn_p2_rollDice.Click += new System.EventHandler(this.btn_p2_rollDice_Click);
            // 
            // lbl_p2dice5
            // 
            this.lbl_p2dice5.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice5.Location = new System.Drawing.Point(1245, 313);
            this.lbl_p2dice5.Name = "lbl_p2dice5";
            this.lbl_p2dice5.Size = new System.Drawing.Size(90, 90);
            this.lbl_p2dice5.TabIndex = 11;
            // 
            // lbl_p2dice3
            // 
            this.lbl_p2dice3.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice3.Location = new System.Drawing.Point(1053, 313);
            this.lbl_p2dice3.Name = "lbl_p2dice3";
            this.lbl_p2dice3.Size = new System.Drawing.Size(90, 90);
            this.lbl_p2dice3.TabIndex = 10;
            // 
            // lbl_p2dice2
            // 
            this.lbl_p2dice2.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice2.Location = new System.Drawing.Point(957, 313);
            this.lbl_p2dice2.Name = "lbl_p2dice2";
            this.lbl_p2dice2.Size = new System.Drawing.Size(90, 90);
            this.lbl_p2dice2.TabIndex = 9;
            // 
            // lbl_p2dice4
            // 
            this.lbl_p2dice4.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice4.Location = new System.Drawing.Point(1149, 313);
            this.lbl_p2dice4.Name = "lbl_p2dice4";
            this.lbl_p2dice4.Size = new System.Drawing.Size(90, 90);
            this.lbl_p2dice4.TabIndex = 8;
            // 
            // lbl_p2dice1
            // 
            this.lbl_p2dice1.Image = global::DiceGame.Properties.Resources.dice_blank;
            this.lbl_p2dice1.Location = new System.Drawing.Point(861, 313);
            this.lbl_p2dice1.Name = "lbl_p2dice1";
            this.lbl_p2dice1.Size = new System.Drawing.Size(90, 90);
            this.lbl_p2dice1.TabIndex = 7;
            // 
            // lbl_winnerResult
            // 
            this.lbl_winnerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerResult.Location = new System.Drawing.Point(287, -5);
            this.lbl_winnerResult.Name = "lbl_winnerResult";
            this.lbl_winnerResult.Size = new System.Drawing.Size(817, 153);
            this.lbl_winnerResult.TabIndex = 14;
            this.lbl_winnerResult.Text = "Waiting for roll.";
            this.lbl_winnerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // lbl_p1Name
            // 
            this.lbl_p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Name.Location = new System.Drawing.Point(87, 183);
            this.lbl_p1Name.Name = "lbl_p1Name";
            this.lbl_p1Name.Size = new System.Drawing.Size(485, 121);
            this.lbl_p1Name.TabIndex = 15;
            this.lbl_p1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2Name
            // 
            this.lbl_p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Name.Location = new System.Drawing.Point(850, 183);
            this.lbl_p2Name.Name = "lbl_p2Name";
            this.lbl_p2Name.Size = new System.Drawing.Size(485, 121);
            this.lbl_p2Name.TabIndex = 16;
            this.lbl_p2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 912);
            this.Controls.Add(this.lbl_p2Name);
            this.Controls.Add(this.lbl_p1Name);
            this.Controls.Add(this.lbl_winnerResult);
            this.Controls.Add(this.lbl_p2displayResults);
            this.Controls.Add(this.btn_p2_rollDice);
            this.Controls.Add(this.lbl_p2dice5);
            this.Controls.Add(this.lbl_p2dice3);
            this.Controls.Add(this.lbl_p2dice2);
            this.Controls.Add(this.lbl_p2dice4);
            this.Controls.Add(this.lbl_p2dice1);
            this.Controls.Add(this.lbl_p1displayResults);
            this.Controls.Add(this.btn_p1_rollDice);
            this.Controls.Add(this.lbl_p1dice5);
            this.Controls.Add(this.lbl_p1dice3);
            this.Controls.Add(this.lbl_p1dice2);
            this.Controls.Add(this.lbl_p1dice4);
            this.Controls.Add(this.lbl_p1dice1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_p1dice1;
        private System.Windows.Forms.Label lbl_p1dice4;
        private System.Windows.Forms.Label lbl_p1dice2;
        private System.Windows.Forms.Label lbl_p1dice3;
        private System.Windows.Forms.Label lbl_p1dice5;
        private System.Windows.Forms.Button btn_p1_rollDice;
        private System.Windows.Forms.Label lbl_p1displayResults;
        private System.Windows.Forms.Label lbl_p2displayResults;
        private System.Windows.Forms.Button btn_p2_rollDice;
        private System.Windows.Forms.Label lbl_p2dice5;
        private System.Windows.Forms.Label lbl_p2dice3;
        private System.Windows.Forms.Label lbl_p2dice2;
        private System.Windows.Forms.Label lbl_p2dice4;
        private System.Windows.Forms.Label lbl_p2dice1;
        private System.Windows.Forms.Label lbl_winnerResult;
        private System.Windows.Forms.Label lbl_p1Name;
        private System.Windows.Forms.Label lbl_p2Name;
    }
}

