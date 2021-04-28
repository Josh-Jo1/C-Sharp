using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolverApp
{
    public partial class SudokuSolver : Form
    {
        #region Global Variables

        private Bitmap gridBitmap = new Bitmap(451, 451);                                           // set to 451 x 451 to display last side properly

        private Dictionary<string, TextBox> squaresDict = new Dictionary<string, TextBox>();        // dictionary for all created input boxes of each square

        private Font largeFont = new Font("Verdana", 25), mediumFont = new Font("Verdana", 22), smallFont = new Font("Verdana", 8);     // fonts for input boxes

        private int[,] puzzle = new int[9, 9];                                                      // placeholder for input Sudoku puzzle

        private bool displayHint = false;                                                           // if HintButton was pressed (before clicking a square)

        #endregion

        #region Tests

        private int[,] easyPuzzle = new int[9, 9]
        {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };

        //Solution:
        //{
        //    { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
        //    { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
        //    { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
        //    { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
        //    { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
        //    { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
        //    { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
        //    { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
        //    { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
        //};

        
        private int[,] mediumPuzzle = new int[9, 9]
        {
            { 9, 0, 0, 0, 3, 4, 0, 0, 0 },
            { 2, 3, 0, 0, 9, 0, 0, 1, 0 },
            { 0, 0, 0, 2, 0, 0, 7, 0, 0 },
            { 6, 1, 0, 5, 0, 2, 0, 3, 7 },
            { 0, 0, 0, 0, 8, 0, 0, 0, 0 },
            { 4, 9, 0, 3, 0, 7, 0, 2, 1 },
            { 0, 0, 3, 0, 0, 8, 0, 0, 0 },
            { 0, 2, 0, 0, 5, 0, 0, 7, 4 },
            { 0, 0, 0, 4, 7, 0, 0, 0, 2 }
        };

        //Solution:
        //{
        //    { 9, 6, 1, 7, 3, 4, 2, 5, 8 },
        //    { 2, 3, 7, 8, 9, 5, 4, 1, 6 },
        //    { 5, 8, 4, 2, 1, 6, 7, 9, 3 },
        //    { 6, 1, 8, 5, 4, 2, 9, 3, 7 },
        //    { 3, 7, 2, 9, 8, 1, 6, 4, 5 },
        //    { 4, 9, 5, 3, 6, 7, 8, 2, 1 },
        //    { 7, 4, 3, 1, 2, 8, 5, 6, 9 },
        //    { 8, 2, 9, 6, 5, 3, 1, 7, 4 },
        //    { 1, 5, 6, 4, 7, 9, 3, 8, 2 }
        //};


        private int[,] hardPuzzle = new int[9, 9]
        {
            { 8, 2, 0, 0, 0, 9, 0, 0, 0 },
            { 0, 6, 0, 4, 0, 0, 3, 0, 0 },
            { 0, 0, 9, 0, 8, 0, 1, 0, 0 },
            { 0, 0, 0, 5, 0, 0, 0, 0, 3 },
            { 5, 0, 2, 0, 0, 0, 7, 0, 1 },
            { 4, 0, 0, 0, 0, 6, 0, 0, 0 },
            { 0, 0, 3, 0, 6, 0, 8, 0, 0 },
            { 0, 0, 1, 0, 0, 3, 0, 5, 0 },
            { 0, 0, 0, 9, 0, 0, 0, 3, 2 }
        };

        //Solution:
        //{
        //    { 8, 2, 4, 1, 3, 9, 5, 7, 6 },
        //    { 1, 6, 5, 4, 7, 2, 3, 9, 8 },
        //    { 3, 7, 9, 6, 8, 5, 1, 2, 4 },
        //    { 6, 1, 8, 5, 9, 7, 2, 4, 3 },
        //    { 5, 9, 2, 3, 4, 8, 7, 6, 1 },
        //    { 4, 3, 7, 2, 1, 6, 9, 8, 5 },
        //    { 2, 5, 3, 7, 6, 4, 8, 1, 9 },
        //    { 9, 4, 1, 8, 2, 3, 6, 5, 7 },
        //    { 7, 8, 6, 9, 5, 1, 4, 3, 2 }
        //};

        #endregion

        #region Constructor Method
        
        public SudokuSolver()
        {
            InitializeComponent();

            //Draw 9x9 Grid
            Graphics grid = Graphics.FromImage(gridBitmap);
            SolidBrush grayBrush = new SolidBrush(Color.LightGray);
            int rectWidth = 50, rectHeight = 50;
            
            for (int row = 0; row < 9; ++row)
            {
                for (int col = 0; col < 9; ++col)
                {
                    Rectangle rect = new Rectangle(col * rectWidth, row * rectHeight, rectWidth, rectHeight);
                    Color colour = SystemColors.Control;

                    if (row < 3 || row > 5)
                    {
                        if (col >= 3 && col <= 5)
                        {
                            grid.FillRectangle(grayBrush, rect);
                            colour = Color.LightGray;
                        }
                    }
                    else
                    {
                        if (col < 3 || col > 5)
                        {
                            grid.FillRectangle(grayBrush, rect);
                            colour = Color.LightGray;
                        }
                    }
                    
                    grid.DrawRectangle(Pens.Black, rect);

                    GenerateNewBox(row.ToString() + col.ToString(), new Point(col * rectWidth + 28, row * rectHeight + 28), colour);
                }
            }

            GridPictureBox.Refresh();       // raise paint event of GridPictureBox
            GridPictureBox.SendToBack();    // send to back to input boxes are visible and available
            grid.Dispose();                 // release graphics object
        }

        #endregion

        #region Event Handlers

        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(gridBitmap, 0, 0);                 // draw PictureBox onto Bitmap
        }

        private void EasyPuzzleButton_Click(object sender, EventArgs e)
        {
            DisplayPuzzle(easyPuzzle);
        }

        private void MediumPuzzleButton_Click(object sender, EventArgs e)
        {
            DisplayPuzzle(mediumPuzzle);
        }

        private void HardPuzzleButton_Click(object sender, EventArgs e)
        {
            DisplayPuzzle(hardPuzzle);
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            PuzzleToArray();

            if (SolveSudoku())
                DisplayPuzzle(puzzle);
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            hintLabel.Visible = true;

            PuzzleToArray();

            if (SolveSudoku())
                displayHint = true;                         // user can now select a square to show hint
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < 9; ++row)
            {
                for (int col = 0; col < 9; ++col)
                {
                    squaresDict[row.ToString() + col.ToString()].Text = "";
                }
            }
        }

        #endregion

        #region Other Methods

        private void PuzzleToArray()
        {
            for (int row = 0; row < 9; ++row)
            {
                for (int col = 0; col < 9; ++col)
                {
                    string textBoxNum = squaresDict[row.ToString() + col.ToString()].Text;

                    if (textBoxNum == "")
                        puzzle[row, col] = 0;
                    else
                        puzzle[row, col] = Convert.ToInt32(textBoxNum);
                }
            }
        }

        // Translated from algorithm developed in Python
        private bool SolveSudoku()
        {
            for (int row = 0; row < 9; ++row)
            {
                for (int col = 0; col < 9; ++col)
                {
                    if (puzzle[row, col] == 0)
                    {
                        for (int x = 1; x < 10; ++x)
                        {
                            bool valid = true;

                            for (int i = 0; i < 9; ++i)
                            {
                                if (puzzle[row, i] == x || puzzle[i, col] == x)
                                {
                                    valid = false;
                                    break;
                                }
                            }

                            if (valid)
                            {
                                for (int m = 0; m < 3; ++m)
                                {
                                    for (int n = 0; n < 9; ++n)
                                    {
                                        if (puzzle[row/3*3 + m, col/3*3 + m] == x)
                                        {
                                            valid = false;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (valid)
                            {
                                puzzle[row, col] = x;
                                bool trial = SolveSudoku();

                                if (trial)
                                    return trial;
                                else
                                    puzzle[row, col] = 0;
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        private void DisplayPuzzle(int[,] puzzle)
        {
            for (int row = 0; row < 9; ++row)
            {
                for (int col = 0; col < 9; ++col)
                {
                    if (puzzle[row, col] == 0)
                        squaresDict[row.ToString() + col.ToString()].Text = "";
                    else
                        squaresDict[row.ToString() + col.ToString()].Text = puzzle[row, col].ToString();
                }
            }
        }

        private void GenerateNewBox(string key, Point location, Color colour)
        {
            TextBox inputBox = new TextBox
            {
                Name = key,
                Location = location,
                Size = new Size(42, 42),
                BackColor = colour,
                BorderStyle = BorderStyle.None,
                Font = largeFont,
                TextAlign = HorizontalAlignment.Center,
                MaxLength = 9,
                Multiline = true
            };

            void TextChanged(object sender, EventArgs e)                        // change size of text in textbox based on length
            {
                switch (inputBox.Text.Length)
                {
                    case 0:
                    case 1:
                        inputBox.Font = largeFont;
                        break;
                    case 2:
                        inputBox.Font = mediumFont;
                        break;
                    default:
                        inputBox.Font = smallFont;
                        break;
                }
            }

            void KeyPress(object sender, KeyPressEventArgs e)                   // only accept number and control keys
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }

            void Click(object sender, EventArgs e)
            {
                if (displayHint)
                {
                    int row = Convert.ToInt32(inputBox.Name[0].ToString());
                    int col = Convert.ToInt32(inputBox.Name[1].ToString());
                    inputBox.Text = puzzle[row, col].ToString();

                    hintLabel.Visible = false;
                    displayHint = false;
                }
            }

            Controls.Add(inputBox);
            inputBox.TextChanged += new EventHandler(TextChanged);
            inputBox.KeyPress += new KeyPressEventHandler(KeyPress);
            inputBox.Click += new EventHandler(Click);

            squaresDict.Add(key, inputBox);                                     // add new textbox to dictionary
        }

        #endregion
    }
}
