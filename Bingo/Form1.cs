using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bingo.Class; // BE SURE TO INCLUDE CLASS FOLDER

/*
 * Duc Tran
 * Professor Frank Friedman
 * CIS 3309 - Stage 1 Bingo Project
 * Last Updated: 2/05/2019
 */

namespace Bingo
{
    public partial class Form1 : Form
    {

        public char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
        public char nextCalledLetter;
        public int nextCalledNumber;
        public int countOfCalledNumbers;
        RNGType RNGObj = new RNGType();
        int count = 2;




        public Form1()
        {
            InitializeComponent();
        }       

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name to continue", "Enter a name");
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Welcome " + txtName.Text + "!", "Welcome!");
                Player player = new Player(txtName.Text);
                btnYes.Visible = false;
                lblReady.Visible = false;
                btnNo.Text = "E&xit";
                txtName.ReadOnly = true;
                lblBingoCardTitle.Visible = true;
                createCard();
                Console.WriteLine("Welcome the new player, " + player.name);

                playTheGame();

                /*
                Random random = new Random();
                int randomIndex = random.Next(0, 5);
                char nextColHead = bingoLetters[randomIndex];
                int nextCalledNumber = nextNumberCalled(nextColHead);
                txtRNG.Text = nextColHead.ToString() + nextCalledNumber.ToString();
                Console.WriteLine("nextColHead: " + nextColHead);
                Console.WriteLine("nextCalledNumber: " + nextCalledNumber);
                */
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Named constants
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        // This next statement does three things.  See if you can figure out what they are
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];


        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;



        // Creates the Bingo Card for Play
        private void createCard()
        {
            char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
            RNGType RNGObj = new RNGType();
            Random random = new Random();
            int randomIndex = random.Next(0, 5);
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount2D;
            int bingoCountWO2D; int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            Random random = new Random();
            int randomIndex = random.Next(0, 5);

            //char nextColHead = bingoLetters[randomIndex];
            //int nextCalledNumber = nextNumberCalled(nextColHead);

            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            //Console.WriteLine("Row: " + rowID + ", Col: " + colID);

            //Console.WriteLine(randomIndex);


            
            //Console.WriteLine("Button_Click nextCalledNumber: " + nextCalledNumber);
            //Console.WriteLine("Button_Click selectedNumber: " + selectedNumber);
            
            

            //Console.WriteLine("Next Number Called: " + txtRNG.Text);


            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                InternalCardRep2DArray.recordCalledNumber(rowID, colID);
                //internalCardRepWO2DArray.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                bingoCount2D = InternalCardRep2DArray.isWinner(rowID, colID);
                //bingoCountWO2D = internalCardRepWO2DArray.isWinner(rowID, colID);
                if ((bingoCount2D > 0) /*&& (bingoCountWO2D > 0)*/)
                {
                    MessageBox.Show("You are a Winner!!", "Winner Found! \n"
                        + "Bingos count = " + bingoCount2D  + ". Game over!");
                    Close();
                }  // end inner if
                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected." + "Try again!", "Numbers Do Not Match");
            } // end outer if*/
        } // end button clickhandler

        public int convertCharToInt(char character)
        {
            string holder = character.ToString();
            //Console.WriteLine("convertCharToInt has initiated: " + holder);
            int result = int.Parse(holder);

            return result;
        }

        public int nextNumberCalled(char colHead)
        {
            char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };

            RNGType RNGObj = new RNGType();

            int nextNumber = RNGObj.getRandomValue(colHead);
            //Console.WriteLine("The next number created: " + colHead + nextNumber);

            return nextNumber;
        }

        public void getTxtRNG(char colHead, int nextNumber)
        {
            txtRNG.Text = colHead.ToString() + nextNumber.ToString();
        }

        private void btnNoHave_Click(object sender, EventArgs e)
        {
            
            playTheGame();
            label1.Text = count.ToString();
            count++;
        }

        // Driver program to play the game
        //    Initial call with -1 for row and column selection to start game.
        //    Subsequent calls with row and col index selected by player.
        // void playTheGame(int selectedRow, int selectedCol)
        void playTheGame()
        {
            if (countOfCalledNumbers < MAXBINGONUMBER)
            {
                countOfCalledNumbers++;
                nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                nextCalledLetter = bingoLetters[(nextCalledNumber - 1) / NUMBERSPERCOLUMN];
                txtRNG.Text = nextCalledLetter + " " + nextCalledNumber.ToString();
            }
            else
            {
                MessageBox.Show("All bingo numbers called.  \nYou must have missed one or more.  \nGame over.", "All Numbers Used");
                Close();
            }   // end if
        } // end playTheGame     
        
    }
}
