using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Joshua Johnson
//January 23, 2019

namespace Pascals_Triangle_and_Sierpinski_Triangle
{
    public partial class TrianglesForm : Form
    {
        #region Fields

        private Bitmap trianglesBitmap = new Bitmap(800, 800);                              //bitmap space allocated for drawing

        private Dictionary<string, Label> dictOfLabels = new Dictionary<string, Label>();   //dictionary to store all created labels of Pascal's Triangle

        private bool createLabel = true;                                                    //bool to only create labels once

        private bool drawPascalAsCombinedTriangle;                                          //bool to draw Sierpinski Triangle on Pascal's Triangle 
        private bool drawSierpinskiAsPyramid;                                               //bool to draw Sierpinski Triangle as pyramid

        #endregion

        #region Constructor Method

        public TrianglesForm()
        {
            InitializeComponent();

            //Starting configurations of input box for rows
            RowsUpDown.Value = 16;
            RowsUpDown.Maximum = 16;
            RowsUpDown.Enabled = false;

            //Starting configurations of input box for depth
            DepthUpDown.Value = 4;
            DepthUpDown.Maximum = 10;
            DepthUpDown.Enabled = false;

            //Starting configurations of input box for colour
            ColourComboBox.Items.Add("Sunset");
            ColourComboBox.Items.Add("Cool Blues");
            ColourComboBox.Items.Add("Forestry");
            ColourComboBox.SelectedIndex = 0;
            ColourComboBox.Enabled = false;
        }

        #endregion

        #region Event Handlers

        private void TrianglePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(trianglesBitmap, 0, 0);                        //draw picture box onto bitmap
        }

        private void PascalsTriangleButton_Click(object sender, EventArgs e)
        {
            //Configurations of input boxes
            RowsUpDown.Enabled = true;
            DepthUpDown.Enabled = false;
            ColourComboBox.Enabled = false;

            drawPascalAsCombinedTriangle = false;                               //regular Pascal's Triangle

            Graphics pascalsTriangle = Graphics.FromImage(trianglesBitmap);     //graphics object to draw on bitmap

            pascalsTriangle.Clear(TrianglePictureBox.BackColor);

            DrawPascalsTriangle(pascalsTriangle, new SolidBrush(ChooseColour(true)), new SolidBrush(ChooseColour(false)), ChoosePen());

            TrianglePictureBox.Refresh();                                       //raise paint event of picture box

            pascalsTriangle.Dispose();                                          //release graphics object
        }

        private void SierpinskiTriangleButton_Click(object sender, EventArgs e)
        {
            //Configurations of input boxes
            RowsUpDown.Enabled = false;
            DepthUpDown.Enabled = true;
            ColourComboBox.Enabled = false;

            drawSierpinskiAsPyramid = false;                                    //regular Sierpinski Triangle

            foreach (Label label in dictOfLabels.Values)                        //Pascal's Triangle labels not needed
                label.SendToBack();

            Graphics sierpinskiTriangle = Graphics.FromImage(trianglesBitmap);  //graphics object to draw on bitmap

            sierpinskiTriangle.Clear(TrianglePictureBox.BackColor);

            DrawSierpinskiTriangle(sierpinskiTriangle, (int)DepthUpDown.Value,
                                    new Point(285, 12), new Point(61, 388), new Point(511, 388), new SolidBrush(ChooseColour(false)), ChoosePen());

            TrianglePictureBox.Refresh();                                       //raise paint event of picture box

            sierpinskiTriangle.Dispose();                                       //release graphics object
        }

        private void CombinedTriangleButton_Click(object sender, EventArgs e)
        {
            //Configurations of input boxes
            RowsUpDown.Enabled = true;
            DepthUpDown.Enabled = false;
            ColourComboBox.Enabled = true;

            drawPascalAsCombinedTriangle = true;                                //Pascal's Triangle and Sierpinski Triangle as combined triangle

            Graphics combinedTriangle = Graphics.FromImage(trianglesBitmap);    //graphics object to draw on bitmap

            combinedTriangle.Clear(TrianglePictureBox.BackColor);

            DrawPascalsTriangle(combinedTriangle, new SolidBrush(ChooseColour(true)), new SolidBrush(ChooseColour(false)), ChoosePen());

            TrianglePictureBox.Refresh();                                       //raise paint event of picture box

            combinedTriangle.Dispose();                                         //release graphics object
        }

        private void SierpinskiPyramidsButton_Click(object sender, EventArgs e)
        {
            //Configurations of input boxes
            RowsUpDown.Enabled = false;
            DepthUpDown.Enabled = true;
            ColourComboBox.Enabled = true;

            drawPascalAsCombinedTriangle = false;                               //Sierpinski Triangle as pyramids
            drawSierpinskiAsPyramid = true;

            foreach (Label label in dictOfLabels.Values)                        //Pascal's Triangle labels not needed
                label.SendToBack();

            Graphics sierpinskiPyramid = Graphics.FromImage(trianglesBitmap);   //graphics object to draw on bitmap

            sierpinskiPyramid.Clear(TrianglePictureBox.BackColor);

            //Pyramid 1
            DrawSierpinskiTriangle(sierpinskiPyramid, (int)DepthUpDown.Value,
                                    new Point(390, 120), new Point(230, 350), new Point(460, 350), new SolidBrush(ChooseColour(false)), ChoosePen());
            DrawSierpinskiTriangle(sierpinskiPyramid, (int)DepthUpDown.Value, new Point(390, 120), new Point(460, 350),
                                    new Point(510, 290), new SolidBrush(ChooseColour(false)), ChoosePen());
            //Pyramid 2
            DrawSierpinskiTriangle(sierpinskiPyramid, (int)DepthUpDown.Value, new Point(140, 70), new Point(80, 210),
                                    new Point(220, 210), new SolidBrush(ChooseColour(false)), ChoosePen());
            DrawSierpinskiTriangle(sierpinskiPyramid, (int)DepthUpDown.Value, new Point(140, 70), new Point(60, 190),
                                    new Point(80, 210), new SolidBrush(ChooseColour(false)), ChoosePen());

            TrianglePictureBox.Refresh();                                       //raise paint event of picture box

            sierpinskiPyramid.Dispose();                                        //release graphics object
        }

        private void RowsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (drawPascalAsCombinedTriangle)
                CombinedTriangleButton.PerformClick();
            else
                PascalsTriangleButton.PerformClick();
        }

        private void DepthUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (drawSierpinskiAsPyramid)
                SierpinskiPyramidsButton.PerformClick();
            else
                SierpinskiTriangleButton.PerformClick();
        }

        private void ColourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drawPascalAsCombinedTriangle)
                CombinedTriangleButton.PerformClick();
            else
                SierpinskiPyramidsButton.PerformClick();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// This method will draw the Pascal's Triangle for the input rows and colour selected if possible
        /// </summary>

        private void DrawPascalsTriangle(Graphics triangle, SolidBrush brushForEven, SolidBrush brushForOdd, Pen penForSides)
        {
            //Coordinates for first hexagon, offset 30 pixels left
            Point top = new Point(255, 12);
            Point rightUp = new Point(270, 20);
            Point rightDown = new Point(270, 35);
            Point bottom = new Point(255, 43);
            Point leftDown = new Point(240, 35);
            Point leftUp = new Point(240, 20);

            int rows = (int)RowsUpDown.Value, cells = 1;                                                //input rows and cell count for each row
            
            for (int row = 0; row < rows; row++)
            {
                for (int cell = 0; cell <= row; cell++)
                {
                    top.X += 30; rightUp.X += 30; rightDown.X += 30; bottom.X += 30; leftDown.X += 30; leftUp.X += 30;

                    Point[] hexPoints = { top, rightUp, rightDown, bottom, leftDown, leftUp, top };     //points for hexagon, including top again to complete shape

                    string key = row.ToString() + "_" + cell.ToString();                                //key for each label

                    if (createLabel)
                        GenerateNewLabel(key, new Point(leftUp.X + 1, leftUp.Y), CalculateCombination(cells - 1, cell).ToString());
                    
                    if (drawPascalAsCombinedTriangle)
                    {
                        dictOfLabels.TryGetValue(key, out Label label);                                 //get label at given key

                        if (Convert.ToInt16(label.Text) % 2 == 0)
                        {
                            label.BackColor = brushForEven.Color;
                            triangle.FillPolygon(brushForEven, hexPoints);
                        }
                        else
                        {
                            label.BackColor = brushForOdd.Color;
                            triangle.FillPolygon(brushForOdd, hexPoints);
                        }

                        triangle.DrawPolygon(penForSides, hexPoints);
                    }
                    else
                    {
                        foreach (Label label in dictOfLabels.Values)
                            label.BackColor = Color.Transparent;
                        
                        triangle.DrawLines(Pens.Blue, hexPoints.Take(3).ToArray());
                        triangle.DrawLines(Pens.Green, hexPoints.Skip(2).Take(3).ToArray());
                        triangle.DrawLines(Pens.Red, hexPoints.Skip(4).ToArray());
                    }
                }
                cells++;

                //Reset x-coordinates for next row
                top.X = 255 - 15 * (row + 1); rightUp.X = 270 - 15 * (row + 1); rightDown.X = 270 - 15 * (row + 1);
                bottom.X = 255 - 15 * (row + 1); leftDown.X = 240 - 15 * (row + 1); leftUp.X = 240 - 15 * (row + 1);

                //Reset y-coordinates for next row
                top.Y = 12 + 23 * (row + 1); rightUp.Y = 20 + 23 * (row + 1); rightDown.Y = 35 + 23 * (row + 1);
                bottom.Y = 43 + 23 * (row + 1); leftDown.Y = 35 + 23 * (row + 1); leftUp.Y = 20 + 23 * (row + 1);
            }

            createLabel = false;                                                                        //stops labels from being created again

            //Send all labels to back
            foreach (Label label in dictOfLabels.Values)
                label.SendToBack();
            
            //Bring all necessary labels to front given input rows
            for (int row = 0; row < rows; row++)
                for (int cell = 0; cell <= row; cell++)
                    dictOfLabels[row.ToString() + "_" + cell.ToString()].BringToFront();
        }

        /// <summary>
        /// This method will draw the Sierpinski Triangle for the input depth and colour selected if possible
        /// </summary>

        private void DrawSierpinskiTriangle(Graphics triangle, int depth, Point top, Point left, Point right, SolidBrush brushForFaces, Pen penForSides)
        {
            if (depth == 0)                                                                             //outer triangle
            {
                if (drawSierpinskiAsPyramid)
                {
                    Point[] pyramidFace = { top, left, right };
                    triangle.FillPolygon(brushForFaces, pyramidFace);

                    triangle.DrawLine(penForSides, top, left);
                    triangle.DrawLine(penForSides, top, right);
                    triangle.DrawLine(penForSides, left, right);
                }
                else
                {
                    triangle.DrawLine(Pens.Blue, top, left);
                    triangle.DrawLine(Pens.Red, top, right);
                    triangle.DrawLine(Pens.Green, left, right);
                }
            }
            else                                                                                        //smaller triangle at each vertex within
            {
                Point midOfLeft = new Point((top.X + left.X) / 2, (top.Y + left.Y) / 2);
                Point midOfRight = new Point((top.X + right.X) / 2, (top.Y + right.Y) / 2);
                Point midOfBottom = new Point((left.X + right.X) / 2, (left.Y + right.Y) / 2);

                DrawSierpinskiTriangle(triangle, depth - 1, top, midOfLeft, midOfRight, brushForFaces, penForSides);
                DrawSierpinskiTriangle(triangle, depth - 1, midOfLeft, left, midOfBottom, brushForFaces, penForSides);
                DrawSierpinskiTriangle(triangle, depth - 1, midOfRight, midOfBottom, right, brushForFaces, penForSides);
            }
        }

        /// <summary>
        /// This method will make the labels required for the Pascal's Triangle
        /// </summary>

        //Refactored method of Mr.Nolfi's source code
        private void GenerateNewLabel(string key, Point location, string text)
        {
            Label newLabel = new Label                                                                  //new label and configurations
            {
                Name = "label_" + key,
                Location = location,
                Size = new Size(29, 15),
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            while (newLabel.Width < TextRenderer.MeasureText(newLabel.Text, newLabel.Font).Width)       //reduce width of label while less than width of text
                newLabel.Font = new Font(newLabel.Font.FontFamily, newLabel.Font.Size - 0.2f);

            Controls.Add(newLabel);                                                                     //add new label to controls

            dictOfLabels.Add(key, newLabel);                                                            //add new label to dictionary of labels
        }

        /// <summary>
        /// This method will calculate the values for the Pascal's Triangle
        /// </summary>

        private double CalculateCombination(int totalChoices, int successes)
        {
            double Factorial(int number)
            {
                double fac = 1;

                for (int i = 2; i <= number; i++)
                    fac *= i;

                return fac;
            }

            return Factorial(totalChoices) / (Factorial(totalChoices - successes) * Factorial(successes));
        }

        /// <summary>
        /// This method will choose a pen based on the input colour
        /// </summary>

        private Pen ChoosePen()
        {
            if (ColourComboBox.SelectedItem.ToString() == "Sunset")
                return Pens.DarkRed;
            else if (ColourComboBox.SelectedItem.ToString() == "Cool Blues")
                return Pens.Blue;
            else
                return Pens.Brown;
        }

        /// <summary>
        /// This method will choose a colour based on the input colour
        /// </summary>

        private Color ChooseColour(bool evenColour)
        {
            if (ColourComboBox.SelectedItem.ToString() == "Sunset")
            {
                if (evenColour)
                    return Color.Orange;
                else
                    return Color.OrangeRed;
            }
            else if (ColourComboBox.SelectedItem.ToString() == "Cool Blues")
            {
                if (evenColour)
                    return Color.Aqua;
                else
                    return Color.DarkTurquoise;
            }
            else
            {
                if (evenColour)
                    return Color.GreenYellow;
                else
                    return Color.Green;
            }
        }

        #endregion
    }
}
