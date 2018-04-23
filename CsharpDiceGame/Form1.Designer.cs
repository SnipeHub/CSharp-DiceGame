namespace CsharpDiceGame
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
            this.lbl_dice1 = new System.Windows.Forms.Label();
            this.lbl_dice2 = new System.Windows.Forms.Label();
            this.lbl_dice3 = new System.Windows.Forms.Label();
            this.lbl_dice4 = new System.Windows.Forms.Label();
            this.lbl_dice5 = new System.Windows.Forms.Label();
            this.btn_rollDice = new System.Windows.Forms.Button();
            this.lbl_dice6 = new System.Windows.Forms.Label();
            this.lbl_displayResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_dice1
            // 
            this.lbl_dice1.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice1.Location = new System.Drawing.Point(258, 148);
            this.lbl_dice1.Name = "lbl_dice1";
            this.lbl_dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice1.TabIndex = 0;
            // 
            // lbl_dice2
            // 
            this.lbl_dice2.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice2.Location = new System.Drawing.Point(314, 148);
            this.lbl_dice2.Name = "lbl_dice2";
            this.lbl_dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice2.TabIndex = 1;
            // 
            // lbl_dice3
            // 
            this.lbl_dice3.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice3.Location = new System.Drawing.Point(370, 148);
            this.lbl_dice3.Name = "lbl_dice3";
            this.lbl_dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice3.TabIndex = 2;
            // 
            // lbl_dice4
            // 
            this.lbl_dice4.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice4.Location = new System.Drawing.Point(426, 148);
            this.lbl_dice4.Name = "lbl_dice4";
            this.lbl_dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice4.TabIndex = 3;
            // 
            // lbl_dice5
            // 
            this.lbl_dice5.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice5.Location = new System.Drawing.Point(482, 148);
            this.lbl_dice5.Name = "lbl_dice5";
            this.lbl_dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice5.TabIndex = 4;
            // 
            // btn_rollDice
            // 
            this.btn_rollDice.Location = new System.Drawing.Point(322, 224);
            this.btn_rollDice.Name = "btn_rollDice";
            this.btn_rollDice.Size = new System.Drawing.Size(200, 50);
            this.btn_rollDice.TabIndex = 5;
            this.btn_rollDice.Text = "Roll Dice";
            this.btn_rollDice.UseVisualStyleBackColor = true;
            this.btn_rollDice.Click += new System.EventHandler(this.btn_rollDice_Click);
            // 
            // lbl_dice6
            // 
            this.lbl_dice6.Image = global::CsharpDiceGame.Properties.Resources.dice_blank;
            this.lbl_dice6.Location = new System.Drawing.Point(538, 148);
            this.lbl_dice6.Name = "lbl_dice6";
            this.lbl_dice6.Size = new System.Drawing.Size(50, 50);
            this.lbl_dice6.TabIndex = 6;
            // 
            // lbl_displayResults
            // 
            this.lbl_displayResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayResults.Location = new System.Drawing.Point(300, 306);
            this.lbl_displayResults.Name = "lbl_displayResults";
            this.lbl_displayResults.Size = new System.Drawing.Size(250, 50);
            this.lbl_displayResults.TabIndex = 7;
            this.lbl_displayResults.Text = "Roll the Dice";
            this.lbl_displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_displayResults);
            this.Controls.Add(this.lbl_dice6);
            this.Controls.Add(this.btn_rollDice);
            this.Controls.Add(this.lbl_dice5);
            this.Controls.Add(this.lbl_dice4);
            this.Controls.Add(this.lbl_dice3);
            this.Controls.Add(this.lbl_dice2);
            this.Controls.Add(this.lbl_dice1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_dice1;
        private System.Windows.Forms.Label lbl_dice2;
        private System.Windows.Forms.Label lbl_dice3;
        private System.Windows.Forms.Label lbl_dice4;
        private System.Windows.Forms.Label lbl_dice5;
        private System.Windows.Forms.Button btn_rollDice;
        private System.Windows.Forms.Label lbl_dice6;
        private System.Windows.Forms.Label lbl_displayResults;
    }
}

