using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleGDIPlusExample
{
    public partial class DrawGridForm : Form
    {
        #region Instance Fields
        /**
         * The class 'Bitmap' encapsulates a GDI+ bitmap. 
         * A GDI + bitmap consists of the pixel data for a graphics image, as well as the attributes of the image.
         * 
         * When the 'Bitmap' class is used to create a 'Bitmap' object, space is allocated in memory to store the 
         * bitmap data. Whenever a drawing method is executed, the image data are updated in memory. However, 
         * NOTHING is displayed until the 'Paint' event is raised on the control on which the drawing is 
         * displayed. Drawing images in this way is much faster than drawing directly to a form, picture box 
         * or other control on which images can be drawn. 
         * */
        Bitmap GridBitmap = new Bitmap(401, 401); //The size of the bitmap is set to 401 pixels x 401 pixels.

        int numFlashes = 0; //Used for the "flash" effect
        
        #endregion

        #region Constructor Method

        public DrawGridForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers

        // Whenever the "Paint" event is raised, the data in the "Bitmap" object are used
        // to draw on "GridPictureBox"
        private void GridPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(GridBitmap, 0, 0);
        }

        private void DrawGridButton_Click(object sender, EventArgs e)
        {
            // Draw a 8 x 8 grid in which each "cell" has dimensions 50 pixels by 50 pixels
            // "false" -> means only draw a grid, not a checkerboard
            DrawGrid(8, 8, 50, 50, false);
        }

        private void DrawCheckerBoardButton_Click(object sender, EventArgs e)
        {
            // Draw an 8 x 8 checkerboard in which each square has dimensions 50 pixels by 50 pixels
            // "true" -> means draw a checkerboard as well as a grid
            DrawGrid(8, 8, 50, 50, true);
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            Graphics grid = Graphics.FromImage(GridBitmap);
            grid.Clear(GridPictureBox.BackColor);

            GridPictureBox.Refresh(); // Raise the "Paint" event
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            if (numFlashes % 2 == 0)
            {
                DrawGrid(8, 8, 50, 50, false);
            }
            else
            {
                DrawGrid(8, 8, 50, 50, true);
            }

            numFlashes++;
        }

        private void FlashButton_Click(object sender, EventArgs e)
        {
            if (FlashButton.Text == "Flash")
            {
                numFlashes = 0;
                FlashTimer.Enabled = true;
                FlashButton.Text = "Pause Flash";
            }
            else
            {
                FlashTimer.Enabled = false;
                FlashButton.Text = "Flash";
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Other Methods


        // Draw a grid, and possibly also a checkerboard (if drawCheckerBoard == true),
        // that has "rows" rows and "columns" columns, and in which each cell has dimensions 
        // "rectangleWidth" pixels by "rectangleHeight"

        private void DrawGrid(int rows, int columns, int rectangleWidth, int rectangleHeight, bool drawCheckerBoard)
        {
            Graphics grid = Graphics.FromImage(GridBitmap);
            SolidBrush fillColourBrush = new SolidBrush(Color.Red); //Needed only for checkerboard

            grid.Clear(GridPictureBox.BackColor);

            for (int row = 0; row <= rows; row++)
            {
                for (int column = 0; column <= columns; column++)
                {
                    // Draw unfilled rectangle
                    grid.DrawRectangle(Pens.Black, row * rectangleWidth, column * rectangleHeight,
                                                                        rectangleWidth, rectangleHeight);
                    if (drawCheckerBoard) // Fill rectangle with black or red
                    {
                        // Select the brush colour (alternate red and black)
                        fillColourBrush.Color = ((row + column) % 2 == 0) ? Color.Black : Color.Red;

                        // Fill the rectangle
                        grid.FillRectangle(fillColourBrush, row * rectangleWidth, column * rectangleHeight,
                                                                        rectangleWidth, rectangleHeight);
                    }
                }
            }

            //Raise the 'Paint' event on 'GridPictureBox.'
            GridPictureBox.Refresh();

            //Release resources used by the graphics object.
            grid.Dispose();
        }
        #endregion
    }
}
