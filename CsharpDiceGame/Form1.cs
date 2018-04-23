#region using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace CsharpDiceGame
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages; // our image array to hold the images
        int[] dice; // integer array, will hold each number of our dice
        Random rand;

        #endregion

        #region Initialisation

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_blank;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;

            dice = new int[6] { 0, 0, 0, 0, 0, 0 };

            rand = new Random();
        }

        #endregion

        #region Private Methods

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            RollDice(); // we are calling the private void bellow called RollDice() whenever the button "Roll Dice" is pressed it will do what is written below
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i] = rand.Next(1, 7);

            lbl_dice1.Image = diceImages[dice[0]];
            lbl_dice2.Image = diceImages[dice[1]];
            lbl_dice3.Image = diceImages[dice[2]];
            lbl_dice4.Image = diceImages[dice[3]];
            lbl_dice5.Image = diceImages[dice[4]];
            lbl_dice6.Image = diceImages[dice[5]];
        }

        #endregion
    }
}
