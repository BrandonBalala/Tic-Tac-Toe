using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String[] gameBoard = new String[9];
        int turnCntr = 0;
        int computerMove = 1;
        int undoCntr = 0;
        int playerXWins = 0;
        int playerOWins = 0;
        int ties = 0;
        int boardNum;
        int boardNumAI;
        String symbol;
        Boolean languageEnglish = true;
        Boolean pVp = true;
        Boolean easy = false;
        Boolean medium = false;
        Boolean hard = false;

        /**
         * This method displays message box asking if user wants to
         * load a previous game.
         */
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("./savegame.txt"))
            {
                String message;
                String title = "Tic Tac Toe";

                message = "Do you want to load a previous game?\n"
                        + "Voulez-vous ouvrir un jeu précédent?";

                DialogResult dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    loadDataFromSequentialFile();
                }
            }
        }

        /**
         *This method displays a message asking
         *wether user wants to save game or not
         *If not, it just closes the game.
         */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            String message;
            String title = "Tic Tac Toe";


            if (languageEnglish == true)
                message = "Do you want to save the games progress?";
            else
                message = "Voulez-vous sauvegarder vos données?";

            DialogResult dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                saveToFile();
            }
        }

        /**
         * Changes the language of the application to english 
         */
        private void changeLanguageEnglish()
        {
            playerToolStripMenuItem.Text = "Player";
            humanVsHumanToolStripMenuItem.Text = "Human vs Human";
            humanVsComputerToolStripMenuItem.Text = "Human vs Computer";
            languageToolStripMenuItem.Text = "Language";
            englishToolStripMenuItem.Text = "English";
            frenchToolStripMenuItem.Text = "French";
            scoreCountGroupBox.Text = "Score Count";
            winLabel.Text = "Wins";
            lossLabel.Text = "Losses";
            tieLabel.Text = "Ties:";
            totalLabel.Text = "TOTAL GAMES:";
            playAgainButton.Text = "Play Again";
            undoButton.Text = "Undo";
            easyToolStripMenuItem.Text = "Novice";
            mediocreToolStripMenuItem.Text = "Intermediate";
            difficultToolStripMenuItem.Text = "Expert";
            resetToolStripMenuItem.Text = "Reset";
            languageEnglish = true;

            if (pVp)
            {
                playerXlabel.Text = "Player X:";
                playerOlabel.Text = "Player O:";
            }
            else
            {
                playerXlabel.Text = "Player";
                playerOlabel.Text = "Computer";
            }
        }

        /**
         * Changes the language of the application to french
         */
        private void changeLanguageFrench()
        {
            playerToolStripMenuItem.Text = "Joueur";
            humanVsHumanToolStripMenuItem.Text = "Humain vs Humain";
            humanVsComputerToolStripMenuItem.Text = "Humain vs Ordinateur";
            languageToolStripMenuItem.Text = "Langage";
            englishToolStripMenuItem.Text = "Anglais";
            frenchToolStripMenuItem.Text = "Français";
            scoreCountGroupBox.Text = "Pointage";
            winLabel.Text = "Victoires";
            lossLabel.Text = "Défaites";
            tieLabel.Text = "Égalités:";
            totalLabel.Text = "PARTIES:";
            playAgainButton.Text = "Rejouer";
            undoButton.Text = "Annuler";
            easyToolStripMenuItem.Text = "Facile";
            mediocreToolStripMenuItem.Text = "Moyen";
            difficultToolStripMenuItem.Text = "Difficile";
            resetToolStripMenuItem.Text = "Réinitialiser";
            languageEnglish = false;

            if (pVp)
            {
                playerXlabel.Text = "Joueur X:";
                playerOlabel.Text = "Joueur O:";
            }
            else
            {
                playerXlabel.Text = "Joueur";
                playerOlabel.Text = "Ordinateur";
            }
        }

        /**
         * Displays values of variables
         * Used for debugging only if seen in other methods
         */
        private void changeLabels()
        {
            label1.Text = turnCntr.ToString();
            label2.Text = computerMove.ToString();
            label3.Text = undoCntr.ToString();
            label4.Text = boardNum.ToString();
            label5.Text = boardNumAI.ToString();
            label6.Text = pVp.ToString();
        }

        /**
         * Checks the game board if a winning case has been 
         * reached by a player.
         */
        private Boolean checkWin()
        {
            if (!string.IsNullOrEmpty(gameBoard[0]) && (gameBoard[0].Equals(gameBoard[1])) && (gameBoard[0].Equals(gameBoard[2])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[3]) && (gameBoard[3].Equals(gameBoard[4])) && (gameBoard[3].Equals(gameBoard[5])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[6]) && (gameBoard[6].Equals(gameBoard[7])) && (gameBoard[6].Equals(gameBoard[8])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[0]) && (gameBoard[0].Equals(gameBoard[3])) && (gameBoard[0].Equals(gameBoard[6])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[1]) && (gameBoard[1].Equals(gameBoard[4])) && (gameBoard[1].Equals(gameBoard[7])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[2]) && (gameBoard[2].Equals(gameBoard[5])) && (gameBoard[2].Equals(gameBoard[8])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[0]) && (gameBoard[0].Equals(gameBoard[4])) && (gameBoard[0].Equals(gameBoard[8])))
                return true;
            if (!string.IsNullOrEmpty(gameBoard[2]) && (gameBoard[2].Equals(gameBoard[4])) && (gameBoard[2].Equals(gameBoard[6])))
                return true;

            return false;
        }

        /**
         * Put in play deffense strategies if detects a threat for opponent to win
         * else it just gets one of the 4 corners if available 
         */
        private int computerDefendOrGetCorner()
        {
            turnCntr++;
            setSymbol();

            //strategy defense 1
            if (gameBoard[1] == symbol && gameBoard[5] == symbol && gameBoard[6] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[3]))
                    return 3;
                if (string.IsNullOrEmpty(gameBoard[7]))
                    return 7;
                if (string.IsNullOrEmpty(gameBoard[0]))
                    return 0;
                if (string.IsNullOrEmpty(gameBoard[8]))
                    return 8;
            }
            if (gameBoard[2] == symbol && gameBoard[3] == symbol && gameBoard[7] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[1]))
                    return 1;
                if (string.IsNullOrEmpty(gameBoard[4]))
                    return 4;
                if (string.IsNullOrEmpty(gameBoard[0]))
                    return 0;
                if (string.IsNullOrEmpty(gameBoard[8]))
                    return 8;
            }
            //strategy defense 2
            if ((gameBoard[0] == symbol && gameBoard[8] == symbol) || (gameBoard[2] == symbol && gameBoard[6] == symbol))
            {
                if (string.IsNullOrEmpty(gameBoard[1]))
                    return 1;
                if (string.IsNullOrEmpty(gameBoard[3]))
                    return 3;
                if (string.IsNullOrEmpty(gameBoard[5]))
                    return 5;
                if (string.IsNullOrEmpty(gameBoard[7]))
                    return 7;
            }
            //strategy defense 3
            if (gameBoard[0] == symbol)
            {
                if (gameBoard[5] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[2]))
                        return 2;
                    if (string.IsNullOrEmpty(gameBoard[1]))
                        return 1;
                    if (string.IsNullOrEmpty(gameBoard[7]))
                        return 7;
                }
                else if (gameBoard[7] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[6]))
                        return 6;
                    if (string.IsNullOrEmpty(gameBoard[3]))
                        return 3;
                    if (string.IsNullOrEmpty(gameBoard[5]))
                        return 5;
                }
            }
            if (gameBoard[2] == symbol)
            {
                if (gameBoard[3] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[0]))
                        return 0;
                    if (string.IsNullOrEmpty(gameBoard[1]))
                        return 1;
                    if (string.IsNullOrEmpty(gameBoard[7]))
                        return 7;
                }
                else if (gameBoard[7] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[8]))
                        return 8;
                    if (string.IsNullOrEmpty(gameBoard[5]))
                        return 5;
                    if (string.IsNullOrEmpty(gameBoard[3]))
                        return 3;
                }
            }
            if (gameBoard[6] == symbol)
            {
                if (gameBoard[1] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[0]))
                        return 0;
                    if (string.IsNullOrEmpty(gameBoard[3]))
                        return 3;
                    if (string.IsNullOrEmpty(gameBoard[5]))
                        return 5;
                }
                else if (gameBoard[5] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[8]))
                        return 8;
                    if (string.IsNullOrEmpty(gameBoard[7]))
                        return 7;
                    if (string.IsNullOrEmpty(gameBoard[1]))
                        return 1;
                }
            }
            if (gameBoard[8] == symbol)
            {
                if (gameBoard[1] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[2]))
                        return 2;
                    if (string.IsNullOrEmpty(gameBoard[5]))
                        return 5;
                    if (string.IsNullOrEmpty(gameBoard[3]))
                        return 3;
                }
                else if (gameBoard[3] == symbol)
                {
                    if (string.IsNullOrEmpty(gameBoard[6]))
                        return 6;
                    if (string.IsNullOrEmpty(gameBoard[7]))
                        return 7;
                    if (string.IsNullOrEmpty(gameBoard[1]))
                        return 1;
                }
            }
            //strategy defense 4
            if (gameBoard[5] == symbol && gameBoard[7] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[8]))
                    return 8;
            }
            //get corner
            if (string.IsNullOrEmpty(gameBoard[0]))
                return 0;
            if (string.IsNullOrEmpty(gameBoard[2]))
                return 2;
            if (string.IsNullOrEmpty(gameBoard[6]))
                return 6;
            if (string.IsNullOrEmpty(gameBoard[8]))
                return 8;
            return -1;
        }

        /**
         * AI will get middle case
         */
        private int computerGetMiddle()
        {
            if (string.IsNullOrEmpty(gameBoard[4]))
                return 4;
            else
                return -1;
        }

        /**
         * If computer has the possibility to play offensively it will do that
         * else it will return the first open space it finds
         */
        private int computerOpenSpace()
        {
            //strategy offense
            if (gameBoard[0] == symbol && gameBoard[4] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[1]))
                    return 1;
                if (string.IsNullOrEmpty(gameBoard[3]))
                    return 3;
            }

            if (gameBoard[2] == symbol && gameBoard[4] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[1]))
                    return 1;
                if (string.IsNullOrEmpty(gameBoard[5]))
                    return 5;
            }

            if (gameBoard[6] == symbol && gameBoard[4] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[3]))
                    return 3;
                if (string.IsNullOrEmpty(gameBoard[7]))
                    return 7;
            }

            if (gameBoard[8] == symbol && gameBoard[4] == symbol)
            {
                if (string.IsNullOrEmpty(gameBoard[5]))
                    return 5;
                if (string.IsNullOrEmpty(gameBoard[7]))
                    return 7;
            }

            //returns first empty spot
            for (int cntr = 0; cntr < gameBoard.Length; cntr++)
            {
                if (string.IsNullOrEmpty(gameBoard[cntr]))
                    return cntr;
            }

            //impossible
            return -1;
        }

        /**
         * If it receives symbol for computer, and if it has the possibility to win, it will return the missing number.
         * If it receives symbol for opponent, and if it finds a possibility for opponent to win it will return number 
         * to block.
         */
        private int computerWinOrBlock(string symbol)
        {
            //WIN OR BLOCK WITH HORIZONTAL
            if ((gameBoard[0] == symbol) && (gameBoard[1] == symbol) && (string.IsNullOrEmpty(gameBoard[2])))
                return 2;
            if ((gameBoard[1] == symbol) && (gameBoard[2] == symbol) && (string.IsNullOrEmpty(gameBoard[0])))
                return 0;
            if ((gameBoard[2] == symbol) && (gameBoard[0] == symbol) && (string.IsNullOrEmpty(gameBoard[1])))
                return 1;

            if ((gameBoard[3] == symbol) && (gameBoard[4] == symbol) && (string.IsNullOrEmpty(gameBoard[5])))
                return 5;
            if ((gameBoard[4] == symbol) && (gameBoard[5] == symbol) && (string.IsNullOrEmpty(gameBoard[3])))
                return 3;
            if ((gameBoard[5] == symbol) && (gameBoard[3] == symbol) && (string.IsNullOrEmpty(gameBoard[4])))
                return 4;

            if ((gameBoard[6] == symbol) && (gameBoard[7] == symbol) && (string.IsNullOrEmpty(gameBoard[8])))
                return 8;
            if ((gameBoard[7] == symbol) && (gameBoard[8] == symbol) && (string.IsNullOrEmpty(gameBoard[6])))
                return 6;
            if ((gameBoard[8] == symbol) && (gameBoard[6] == symbol) && (string.IsNullOrEmpty(gameBoard[7])))
                return 7;

            //WIN OR BLOCK WITH VERTICAL
            if ((gameBoard[0] == symbol) && (gameBoard[3] == symbol) && (string.IsNullOrEmpty(gameBoard[6])))
                return 6;
            if ((gameBoard[3] == symbol) && (gameBoard[6] == symbol) && (string.IsNullOrEmpty(gameBoard[0])))
                return 0;
            if ((gameBoard[6] == symbol) && (gameBoard[0] == symbol) && (string.IsNullOrEmpty(gameBoard[3])))
                return 3;

            if ((gameBoard[1] == symbol) && (gameBoard[4] == symbol) && (string.IsNullOrEmpty(gameBoard[7])))
                return 7;
            if ((gameBoard[4] == symbol) && (gameBoard[7] == symbol) && (string.IsNullOrEmpty(gameBoard[1])))
                return 1;
            if ((gameBoard[7] == symbol) && (gameBoard[1] == symbol) && (string.IsNullOrEmpty(gameBoard[4])))
                return 4;

            if ((gameBoard[2] == symbol) && (gameBoard[5] == symbol) && (string.IsNullOrEmpty(gameBoard[8])))
                return 8;
            if ((gameBoard[5] == symbol) && (gameBoard[8] == symbol) && (string.IsNullOrEmpty(gameBoard[2])))
                return 2;
            if ((gameBoard[8] == symbol) && (gameBoard[2] == symbol) && (string.IsNullOrEmpty(gameBoard[5])))
                return 5;

            //WIN OR BLOCK WITH DIAGONAL
            if ((gameBoard[0] == symbol) && (gameBoard[4] == symbol) && (string.IsNullOrEmpty(gameBoard[8])))
                return 8;
            if ((gameBoard[4] == symbol) && (gameBoard[8] == symbol) && (string.IsNullOrEmpty(gameBoard[0])))
                return 0;
            if ((gameBoard[8] == symbol) && (gameBoard[0] == symbol) && (string.IsNullOrEmpty(gameBoard[4])))
                return 4;

            if ((gameBoard[2] == symbol) && (gameBoard[4] == symbol) && (string.IsNullOrEmpty(gameBoard[6])))
                return 6;
            if ((gameBoard[4] == symbol) && (gameBoard[6] == symbol) && (string.IsNullOrEmpty(gameBoard[2])))
                return 2;
            if ((gameBoard[6] == symbol) && (gameBoard[2] == symbol) && (string.IsNullOrEmpty(gameBoard[4])))
                return 4;

            return -1;
        }

        /**
         * This method is used to display message of which player won or if it finished in a tie.
         * It also takes care of updating the score board when the game comes to an end.
         */
        private void displayMessage()
        {
            if (checkWin())
            {
                if (symbol.Equals("X"))
                {
                    playerXWins++;
                    playerXWinLabel.Text = playerXWins.ToString();
                    playerOLossLabel.Text = playerXWins.ToString();
                    numGamesLabel.Text = (playerXWins + playerOWins + ties).ToString();
                }
                else
                {
                    playerOWins++;
                    playerOWinLabel.Text = playerOWins.ToString();
                    playerXLossLabel.Text = playerOWins.ToString();
                    numGamesLabel.Text = (playerXWins + playerOWins + ties).ToString();
                }

                if (pVp)
                {
                    if (languageEnglish)
                        MessageBox.Show("Player " + symbol + " won!");
                    else
                        MessageBox.Show("Joueur " + symbol + " a gagné!");
                }
                else
                {
                    //HUMAN VS COMPUTER, HUMAN IS ALWAYS "X"
                    if (symbol.Equals("X"))
                    {
                        if (languageEnglish)
                            MessageBox.Show("Player won!");
                        else
                            MessageBox.Show("Joueur a gagné!");
                    }
                    else 
                    {
                        if (languageEnglish)
                            MessageBox.Show("Computer won!");
                        else
                            MessageBox.Show("L'ordinateur a gagné!");
                    }
                }

                playAgainButton.Visible = true;
                undoButton.Visible = false;
            }
            else if (turnCntr == 8)
            {
                ties++;
                numTieLabel.Text = ties.ToString();
                numGamesLabel.Text = (playerXWins + playerOWins + ties).ToString();

                if (languageEnglish)
                    MessageBox.Show("Tie");
                else
                    MessageBox.Show("Égalité");

                playAgainButton.Visible = true;
                undoButton.Visible = false;
            }
        }

        /**
         * Translates everything into English
         */
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguageEnglish();
        }

        /**
         * Translates everything into French
         */
        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguageFrench();
        }

        /**
         * Contains the strategy for the Novice difficulty
         * Makes use of Random object to get a number between 0 and 8
         * Performs while until you get a number that is not being used
         */
        private int getChoiceEasy()
        {
            int number;
            Random randomNumber = new Random();

            number = randomNumber.Next(0, 8);

            while (!string.IsNullOrEmpty(gameBoard[number]))
            {
                number = randomNumber.Next(0, 8);
            }

            return number;
        }

        /**
         * Contains the strategy for the Expert difficulty
         * PRIORITIES
         * 1- Check for win
         * 2- Block opponent
         * 3- Get middle if available
         * 4- Perform defensive strategy
         * 5- Get corner if available
         * 6- Perform offensive strategy
         * 7- Get first open space
         */
        private int getChoiceHard()
        {
            int number = -1;

            //check win
            number = computerWinOrBlock(symbol);

            //check block
            if (number == -1)
            {
                //put symbol of opponent
                turnCntr++;
                setSymbol();

                number = computerWinOrBlock(symbol);

                //put back symbol of computer
                turnCntr--;
                setSymbol();
            }

            //get middle if available;
            if (number == -1)
            {
                number = computerGetMiddle();
            }

            //opponent played a corner
            if (number == -1)
            {
                number = computerDefendOrGetCorner();

                if (number != -1)
                {
                    turnCntr--;
                    setSymbol();
                }
            }

            //return any open board number
            if (number == -1)
            {
                number = computerOpenSpace();
            }

            return number;
        }

        /**
         * Contains the strategy for the Intermediate difficulty
         * Makes use of Random Object
         * If number is bigger than 25, perform choice of hard, else performs choice of easy
         * Basicaly, 75 % chance of executing strategy of hard and 25% of performing strategy of easy
         */
        private int getChoiceMedium()
        {
            //if number is bigger than 50, perform choice of hard, else performs choice of easy
            int number;
            Random randomNumber = new Random();

            number = randomNumber.Next(0, 100);

            if (number > 50)
                return getChoiceHard();
            else
                return getChoiceEasy();

        }
        
        /**
         * Display a exclamation point when right clicking on a specific grid
         */
        private void gridBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (sender == pictureBox1)
                    pictureBox1.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox2)
                    pictureBox2.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox3)
                    pictureBox3.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox4)
                    pictureBox4.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox5)
                    pictureBox5.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox6)
                    pictureBox6.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox7)
                    pictureBox7.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox8)
                    pictureBox8.BackgroundImage = Properties.Resources.exclamationImage;
                if (sender == pictureBox9)
                    pictureBox9.BackgroundImage = Properties.Resources.exclamationImage;
            }
        }

        /**
         * Changes the grid back to null after letting go of right click
         */
        private void gridBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (sender == pictureBox1)
                    pictureBox1.BackgroundImage = null;
                if (sender == pictureBox2)
                    pictureBox2.BackgroundImage = null;
                if (sender == pictureBox3)
                    pictureBox3.BackgroundImage = null;
                if (sender == pictureBox4)
                    pictureBox4.BackgroundImage = null;
                if (sender == pictureBox5)
                    pictureBox5.BackgroundImage = null;
                if (sender == pictureBox6)
                    pictureBox6.BackgroundImage = null;
                if (sender == pictureBox7)
                    pictureBox7.BackgroundImage = null;
                if (sender == pictureBox8)
                    pictureBox8.BackgroundImage = null;
                if (sender == pictureBox9)
                    pictureBox9.BackgroundImage = null;
            }
        }

        /**
         * This method is used to load data from the file.
         */
        private void loadDataFromSequentialFile()
        {
            string fileName = "./savegame.txt";

            StreamReader fileReader = null;

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileReader = new StreamReader(input);

                string record = fileReader.ReadLine();
                string[] fields;

                if (record != null)
                {
                    fields = record.Split('*');

                    //set board
                    for (int cntr = 0; cntr < 9; cntr++)
                    {
                        gameBoard[cntr] = fields[cntr];
                    }

                    turnCntr = int.Parse(fields[9]);
                    computerMove = int.Parse(fields[10]);
                    undoCntr = int.Parse(fields[11]);
                    playerXWins = int.Parse(fields[12]);
                    playerOWins = int.Parse(fields[13]);
                    ties = int.Parse(fields[14]);
                    boardNum = int.Parse(fields[15]);
                    boardNumAI = int.Parse(fields[16]);
                    symbol = fields[17];
                    languageEnglish = Convert.ToBoolean(fields[18]);
                    pVp = Convert.ToBoolean(fields[19]);
                    easy = Convert.ToBoolean(fields[20]);
                    medium = Convert.ToBoolean(fields[21]);
                    hard = Convert.ToBoolean(fields[22]);

                    //undo button
                    if (Convert.ToBoolean(fields[23]))
                        undoButton.Visible = true;
                    else
                        undoButton.Visible = false;

                    //play again button
                    if (Convert.ToBoolean(fields[24]))
                        playAgainButton.Visible = true;
                    else
                        playAgainButton.Visible = false;

                    if (languageEnglish)
                        changeLanguageEnglish();
                    else
                        changeLanguageFrench();

                    updateScore();
                    updateBoard();
                    changeLabels();
                }
                else
                {
                    fileReader.Close();
                }

            }
            catch (IOException)
            {
                if (languageEnglish == true)
                    MessageBox.Show("Error reading from file");
                else
                    MessageBox.Show("Erreur de la lecture du fichier");
            }
            finally
            {
                fileReader.Close();
            }
        }

        /**
         * When user clicks on the play again button,
         * it clears the board
         */
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            resetBoard();
        }

        /**
         * Resets the board and put everything to its initial value
         */
        private void resetBoard()
        {
            Array.Clear(gameBoard, 0, gameBoard.Length);
            turnCntr = 0;
            undoCntr = 0;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            playAgainButton.Visible = false;
            undoButton.Visible = true;
        }

        /**
         * Resets the scoreboard back to 0
         */
        private void resetScore()
        {
            playerXWins = 0;
            playerOWins = 0;
            ties = 0;

            playerXWinLabel.Text = playerXWins.ToString();
            playerOWinLabel.Text = playerOWins.ToString();
            playerXLossLabel.Text = playerOWins.ToString();
            playerOLossLabel.Text = playerXWins.ToString();
            numTieLabel.Text = ties.ToString();
            numGamesLabel.Text = (playerXWins + playerOWins + ties).ToString();
        }

        /**
         * Once reset button is clicked, it display a message box confirming if you want
         * to really reset the board and the score count
         */
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message;
            String title;

            if (languageEnglish == true)
            {
                message = "Do you really want to reset the board and the score count?";
                title = "Reset Tic Tac Toe";

            }
            else
            {
                message = "Voulez-vous vraiment recommencer la partie et remettre le pointage à zéro?";
                title = "Recommencer Tic Tac Toe";
            }

            DialogResult dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                resetBoard();
                resetScore();
            }
        }

        /**
         * Sets an X or an O on the game board
         */
        private void setChoice(object sender, EventArgs e)
        {

            computerMove = turnCntr + 1;

            //PLAYER MOVE
            if (!checkWin())
            {
                if (sender == pictureBox1)
                    boardNum = 0;
                if (sender == pictureBox2)
                    boardNum = 1;
                if (sender == pictureBox3)
                    boardNum = 2;
                if (sender == pictureBox4)
                    boardNum = 3;
                if (sender == pictureBox5)
                    boardNum = 4;
                if (sender == pictureBox6)
                    boardNum = 5;
                if (sender == pictureBox7)
                    boardNum = 6;
                if (sender == pictureBox8)
                    boardNum = 7;
                if (sender == pictureBox9)
                    boardNum = 8;

                if (string.IsNullOrEmpty(gameBoard[boardNum]))
                {
                    setSymbol();

                    if (sender == pictureBox1)
                    {
                        if (symbol.Equals("X"))
                            pictureBox1.Image = Properties.Resources.Ximage;
                        else
                            pictureBox1.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox2)
                    {
                        if (symbol.Equals("X"))
                            pictureBox2.Image = Properties.Resources.Ximage;
                        else
                            pictureBox2.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox3)
                    {
                        if (symbol.Equals("X"))
                            pictureBox3.Image = Properties.Resources.Ximage;
                        else
                            pictureBox3.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox4)
                    {
                        if (symbol.Equals("X"))
                            pictureBox4.Image = Properties.Resources.Ximage;
                        else
                            pictureBox4.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox5)
                    {
                        if (symbol.Equals("X"))
                            pictureBox5.Image = Properties.Resources.Ximage;
                        else
                            pictureBox5.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox6)
                    {
                        if (symbol.Equals("X"))
                            pictureBox6.Image = Properties.Resources.Ximage;
                        else
                            pictureBox6.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox7)
                    {
                        if (symbol.Equals("X"))
                            pictureBox7.Image = Properties.Resources.Ximage;
                        else
                            pictureBox7.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox8)
                    {
                        if (symbol.Equals("X"))
                            pictureBox8.Image = Properties.Resources.Ximage;
                        else
                            pictureBox8.Image = Properties.Resources.Oimage;
                    }
                    else if (sender == pictureBox9)
                    {
                        if (symbol.Equals("X"))
                            pictureBox9.Image = Properties.Resources.Ximage;
                        else
                            pictureBox9.Image = Properties.Resources.Oimage;
                    }//if sender

                    gameBoard[boardNum] = symbol;
                    if (undoCntr == turnCntr)
                        undoButton.Visible = true;
                    
                    displayMessage();

                    turnCntr++;
                    setSymbol();
                }//gameboard
                
                if (!checkWin() && computerMove == turnCntr)
                {
                    if (easy)
                    {
                        boardNumAI = getChoiceEasy();
                        setComputerChoice();
                    }

                    else if (medium)
                    {
                        boardNumAI = getChoiceMedium();
                        setComputerChoice();
                    }

                    else if (hard)
                    {
                        boardNumAI = getChoiceHard();
                        setComputerChoice();
                    }

                    if (turnCntr > 8)
                        displayMessage();
                }
            }//!checkwin 
            
            changeLabels();
        }//end setChoice

        /**
         * This sets the choice of computer onto the board.
         */
        private void setComputerChoice()
        {
            setSymbol();

            switch (boardNumAI)
            {
                case 0:
                    if (symbol.Equals("X"))
                        pictureBox1.Image = Properties.Resources.Ximage;
                    else
                        pictureBox1.Image = Properties.Resources.Oimage;
                    break;
                case 1:
                    if (symbol.Equals("X"))
                        pictureBox2.Image = Properties.Resources.Ximage;
                    else
                        pictureBox2.Image = Properties.Resources.Oimage;
                    break;
                case 2:
                    if (symbol.Equals("X"))
                        pictureBox3.Image = Properties.Resources.Ximage;
                    else
                        pictureBox3.Image = Properties.Resources.Oimage;
                    break;
                case 3:
                    if (symbol.Equals("X"))
                        pictureBox4.Image = Properties.Resources.Ximage;
                    else
                        pictureBox4.Image = Properties.Resources.Oimage;
                    break;
                case 4:
                    if (symbol.Equals("X"))
                        pictureBox5.Image = Properties.Resources.Ximage;
                    else
                        pictureBox5.Image = Properties.Resources.Oimage;
                    break;
                case 5:
                    if (symbol.Equals("X"))
                        pictureBox6.Image = Properties.Resources.Ximage;
                    else
                        pictureBox6.Image = Properties.Resources.Oimage;
                    break;
                case 6:
                    if (symbol.Equals("X"))
                        pictureBox7.Image = Properties.Resources.Ximage;
                    else
                        pictureBox7.Image = Properties.Resources.Oimage;
                    break;
                case 7:
                    if (symbol.Equals("X"))
                        pictureBox8.Image = Properties.Resources.Ximage;
                    else
                        pictureBox8.Image = Properties.Resources.Oimage;
                    break;
                case 8:
                    if (symbol.Equals("X"))
                        pictureBox9.Image = Properties.Resources.Ximage;
                    else
                        pictureBox9.Image = Properties.Resources.Oimage;
                    break;
            }
            if (turnCntr < 9)
            {
                gameBoard[boardNumAI] = symbol;
                displayMessage();
                turnCntr++;
                setSymbol();
            }           
        }

        /**
         * Sets the difficulty/mode of the game.
         * If changing difficulty, won't reset the scoreboard, but if you change game mode
         * from 2 player to 1 player, it will reset score
         */
        private void setDifficulty(object sender, EventArgs e)
        {
            if (sender == humanVsHumanToolStripMenuItem)
            {
                if (easy || medium || hard)
                {
                    resetScore();
                }
                pVp = true;
                easy = false;
                medium = false;
                hard = false;
                resetBoard();

                setPlayerNamesPVP();
            }

            if (sender == easyToolStripMenuItem)
            {
                if (pVp)
                {
                    resetScore();
                }
                pVp = false;
                easy = true;
                medium = false;
                hard = false;
                resetBoard();

                setPlayerNamesComputer();
            }

            if (sender == mediocreToolStripMenuItem)
            {
                if (pVp)
                {
                    resetScore();
                }
                pVp = false;
                easy = false;
                medium = true;
                hard = false;
                resetBoard();
            }

            if (sender == difficultToolStripMenuItem)
            {
                if (pVp)
                {
                    resetScore();
                }
                pVp = false;
                easy = false;
                medium = false;
                hard = true;
                resetBoard();
            }
        }

        /**
         * Sets the player names in the scoreboard when playing against computer 
         */
        private void setPlayerNamesComputer()
        {
            if (languageEnglish)
            {
                playerXlabel.Text = "Player";
                playerOlabel.Text = "Computer";
            }
            else
            {
                playerXlabel.Text = "Joueur";
                playerOlabel.Text = "Ordinateur";
            }
        }

        /**
         * Sets the player names in the scoreboard when it players against player
         */
        private void setPlayerNamesPVP()
        {
            if (languageEnglish)
            {
                playerXlabel.Text = "Player X:";
                playerOlabel.Text = "Player O:";
            }
            else
            {
                playerXlabel.Text = "Joueur X:";
                playerOlabel.Text = "Joueur O:";
            }
        }

        /**
         * Sets the symbol
         */
        private void setSymbol()
        {
            if (turnCntr % 2 == 0)
            {
                symbol = "X";
            }
            else
            {
                symbol = "O";
            }
        }

        /**
         * Undoes previous move of a player.
         * Previous move will be greyed out.
         * A player can only use 1 undo per turn.
         * If playing against the AI greys out both
         * the player and the AI's moves
         */
        private void undoButton_Click(object sender, EventArgs e)
        {
            if(!pVp)
            {
                if (gameBoard[boardNumAI] != null)
                {
                    switch (boardNumAI)
                    {
                        case 0:
                            pictureBox1.Image = Properties.Resources.grayImg;
                            break;
                        case 1:
                            pictureBox2.Image = Properties.Resources.grayImg;
                            break;
                        case 2:
                            pictureBox3.Image = Properties.Resources.grayImg;
                            break;
                        case 3:
                            pictureBox4.Image = Properties.Resources.grayImg;
                            break;
                        case 4:
                            pictureBox5.Image = Properties.Resources.grayImg;
                            break;
                        case 5:
                            pictureBox6.Image = Properties.Resources.grayImg;
                            break;
                        case 6:
                            pictureBox7.Image = Properties.Resources.grayImg;
                            break;
                        case 7:
                            pictureBox8.Image = Properties.Resources.grayImg;
                            break;
                        case 8:
                            pictureBox9.Image = Properties.Resources.grayImg;
                            break;
                    }      
                }
                gameBoard[boardNumAI] = null;
               
            }

            if (!string.IsNullOrEmpty(gameBoard[boardNum]))
            {
                switch (boardNum)
                {
                    case 0:
                        pictureBox1.Image = Properties.Resources.grayImg;
                        break;
                    case 1:
                        pictureBox2.Image = Properties.Resources.grayImg;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.grayImg;
                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.grayImg;
                        break;
                    case 4:
                        pictureBox5.Image = Properties.Resources.grayImg;
                        break;
                    case 5:
                        pictureBox6.Image = Properties.Resources.grayImg;
                        break;
                    case 6:
                        pictureBox7.Image = Properties.Resources.grayImg;
                        break;
                    case 7:
                        pictureBox8.Image = Properties.Resources.grayImg;
                        break;
                    case 8:
                        pictureBox9.Image = Properties.Resources.grayImg;
                        break;
                }
                gameBoard[boardNum] = null;

                if (pVp)
                {
                    undoCntr = turnCntr;
                    turnCntr--;
                }
                else
                {
                    undoCntr = turnCntr;
                    turnCntr = turnCntr - 2;
                }
                undoButton.Visible = false;
                changeLabels();
            }
        }

        /**
        * This method is used to update the board
        * and putting the appropriate image in the board.
         */
        private void updateBoard()
        {
            for (int cntr = 0; cntr < 9; cntr++)
            {
                switch (cntr)
                {
                    case 0:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox1.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox1.Image = Properties.Resources.Oimage;
                        break;
                    case 1:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox2.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox2.Image = Properties.Resources.Oimage;
                        break;
                    case 2:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox3.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox3.Image = Properties.Resources.Oimage;
                        break;
                    case 3:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox4.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox4.Image = Properties.Resources.Oimage;
                        break;
                    case 4:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox5.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox5.Image = Properties.Resources.Oimage;
                        break;
                    case 5:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox6.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox6.Image = Properties.Resources.Oimage;
                        break;
                    case 6:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox7.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox7.Image = Properties.Resources.Oimage;
                        break;
                    case 7:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox8.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox8.Image = Properties.Resources.Oimage;
                        break;
                    case 8:
                        if (gameBoard[cntr].Equals("X"))
                            pictureBox9.Image = Properties.Resources.Ximage;
                        else
                            if (gameBoard[cntr].Equals("O"))
                                pictureBox9.Image = Properties.Resources.Oimage;
                        break;
                }

            }
        }

        /**
        * This method is used to update the score board
        */
        private void updateScore()
        {
            playerXWinLabel.Text = playerXWins.ToString();
            playerOWinLabel.Text = playerOWins.ToString();
            playerXLossLabel.Text = playerOWins.ToString();
            playerOLossLabel.Text = playerXWins.ToString();
            numTieLabel.Text = ties.ToString();
            numGamesLabel.Text = (playerXWins + playerOWins + ties).ToString();
        }

        /**
        * This method is used to save data into a txt file
        */
        private void saveToFile()
        {
            string fileName = "./savegame.txt";
            String outputString = null;

            if (File.Exists(fileName))
                File.Delete(fileName);

            StreamWriter fileWriter = null;
            try
            {
                FileStream output = new FileStream(fileName,
                    FileMode.OpenOrCreate, FileAccess.Write);

                fileWriter = new StreamWriter(output);

                //gameboard
                foreach (String element in gameBoard)
                {
                    outputString = outputString + element + "*";
                }

                //the rest
                outputString = outputString + turnCntr + "*" + computerMove + "*"
                    + undoCntr + "*" + playerXWins + "*" + playerOWins + "*"
                    + ties + "*" + boardNum + "*" + boardNumAI + "*"
                    + symbol + "*" + languageEnglish + "*" + pVp + "*"
                    + easy + "*" + medium + "*" + hard + "*";

                //PLAY AGAIN + UNDO BUTTON
                outputString = outputString + undoButton.Visible
                                      + "*" + playAgainButton.Visible;

                fileWriter.WriteLine(outputString);
            }
            catch (IOException)
            {
                if (languageEnglish == true)
                    MessageBox.Show("Error writting to file");
                else
                    MessageBox.Show("Erreur écriture au fichier");
            }
            catch (FormatException)
            {
                if (languageEnglish == true)
                    MessageBox.Show("Invalid format");
                else
                    MessageBox.Show("Format invalide");
            }
            finally
            {
                if (fileWriter != null)
                {
                    try
                    {
                        fileWriter.Close();

                        if (languageEnglish == true)
                            MessageBox.Show("GAME SAVED");
                        else
                            MessageBox.Show("JEU SAUVEGARDÉ");

                    }
                    catch (IOException)
                    {
                        if (languageEnglish == true)
                            MessageBox.Show("Cannot close file");
                        else
                            MessageBox.Show("Erreur de fermeture du fichier");
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
