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
        int[] diceResults; // integer array to store the rolled results
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

            dice = new int[6] { 0, 0, 0, 0, 0, 0 }; // The number of dice we have, starting at 0. If you want more die, add another { 0 } in here and then
            // add another array under RollDice() incrementing it by one and then adding a new dice blank image in the windows form designer

            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 }; // whats in the brackets denotes each side of the dice

            rand = new Random();
        }

        #endregion

        #region Private Methods

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            RollDice(); // we are calling the private void bellow called RollDice() whenever the button "Roll Dice" is pressed it will do what is written below

            GetResults();

            ResetResults();
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++) //for int i = 0, if dice is less than i; increment by +1
            {
                dice[i] = rand.Next(1, 7);

                switch (dice[i])
                {
                    case 1: // dice side number 1
                        diceResults[0]++; // if we see the dice shown as one, increment the amount of dice by +1. This needs to be done for all sides
                        break;
                    case 2: // dice side number 2
                        diceResults[1]++;
                        break;
                    case 3:
                        diceResults[2]++;
                        break;
                    case 4:
                        diceResults[3]++;
                        break;
                    case 5:
                        diceResults[4]++;
                        break;
                    case 6:
                        diceResults[5]++;
                        break;
                }
            }

            lbl_dice1.Image = diceImages[dice[0]];
            lbl_dice2.Image = diceImages[dice[1]];
            lbl_dice3.Image = diceImages[dice[2]];
            lbl_dice4.Image = diceImages[dice[3]];
            lbl_dice5.Image = diceImages[dice[4]];
            lbl_dice6.Image = diceImages[dice[5]];
        }

        private void GetResults()
        {
            bool fiveKind = false, fourKind = false, highStraight = false, lowStraight = false,
                fullHouse = false, threeKind = false, twoPair = false, onePair = false, haveSix = false,
                haveFive = false, haveFour = false, haveThree = false, haveTwo = false, haveOne = false; // up to 8.59
        }

        private void ResetResults()
        {

        }

        #endregion
    }
}
