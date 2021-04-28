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
//Completed: April 14, 2020


namespace Optimization_Of_Rectangular_Box
{
    public partial class Form1 : Form
    {
        #region Global Fields

        private Bitmap MaterialBitmap = new Bitmap(175, 124);   //Size of MaterialPictureBox
        private Bitmap BoxBitmap = new Bitmap(570, 300);        //Size of BoxPictureBox
        private double l, w;        //Length and width

        #endregion

        #region Constructor Method

        public Form1()
        {
            InitializeComponent();

            xLabel.Text = widthLabel.Text = lengthLabel.Text = "";
            boxLength.Text = boxWidth.Text = boxHeight.Text = boxVolume.Text = "";
            xModifierLabel.Text = boxVolume.Text = "";
        }

        #endregion

        #region Event Handlers

        //Clear textboxes when clicked
        private void Length_Click(object sender, EventArgs e)
        {
            Length.Text = "";
        }

        private void Width_Click(object sender, EventArgs e)
        {
            Width.Text = "";
        }
        
        //Textboxes only accept numbers
        private void Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Draw shapes to bitmaps
        private void MaterialPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(MaterialBitmap, 0, 0);
        }

        private void BoxPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(BoxBitmap, 0, 0);
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            unitsLabel.Visible = false;
            XModifier.Value = 3;

            if (Length.Text == "" | Width.Text == "" | Length.Text == "ONLY #" | Width.Text == "ONLY #")
            {
                Length.Text = Width.Text = "ONLY #";
            }
            else
            {
                //Draw rectangle for material
                Graphics square = Graphics.FromImage(MaterialBitmap);

                square.DrawRectangle(Pens.Black, 0, 0, 130, 100);
                square.DrawRectangle(Pens.Black, 0, 0, 25, 25);
                DrawX(square, new Point(0, 0), new Point(25, 25), new Point(0, 25), new Point(25, 0));
                square.DrawRectangle(Pens.Black, 105, 0, 25, 25);
                DrawX(square, new Point(105, 0), new Point(130, 25), new Point(105, 25), new Point(130, 0));
                square.DrawRectangle(Pens.Black, 0, 75, 25, 25);
                DrawX(square, new Point(0, 75), new Point(25, 100), new Point(0, 100), new Point(25, 75));
                square.DrawRectangle(Pens.Black, 105, 75, 25, 25);
                DrawX(square, new Point(105, 75), new Point(130, 100), new Point(130, 75), new Point(75, 130));

                MaterialPictureBox.Refresh();
                square.Dispose();

                l = Convert.ToDouble(Length.Text);
                w = Convert.ToDouble(Width.Text);

                //Make sure sides are at least 1 unit because volume will round to 0 otherwise
                if (l < 1)
                {
                    Length.Text = "1";
                    l = 1;
                    unitsLabel.Visible = true;
                }

                if (w < 1)
                {
                    Width.Text = "1";
                    w = 1;
                    unitsLabel.Visible = true;
                }

                //Make sure length is longer side
                if (w > l)
                {
                    l = Convert.ToDouble(Width.Text);
                    w = Convert.ToDouble(Length.Text);
                }

                //Update dimensions on square
                lengthLabel.Text = l.ToString() + " - 2x";
                widthLabel.Text = w.ToString() + " - 2x";
                xLabel.Text = "x";

                //Box
                DrawCube(0);

                //Make slider to adjust x visible
                XModifier.Visible = true;

                //Calculate optimal dimensions and update display
                double x = Optimization(l, w);

                boxLength.Text = "Length: " + Math.Round(l - 2 * x, 2).ToString();
                boxWidth.Text = "Width: " + Math.Round(w - 2 * x, 2).ToString();
                boxHeight.Text = "Height: " + x.ToString();
                boxVolume.Text = "Volume: " + Math.Round((l - 2 * x) * (w - 2 * x) * x, 2).ToString() + " cm³";

                xModifierLabel.Text = x.ToString();
            }
        }
    
        private void XModifier_Scroll(object sender, EventArgs e)
        {
            DrawCube(XModifier.Value - 3);

            double x = Convert.ToDouble(xModifierLabel.Text);

            if (XModifier.Value > 3)
            {
                x = Math.Round(x * Math.Pow(1.05, XModifier.Value - 3), 2);
            }
            else if (Convert.ToDouble(XModifier.Value) < 3)
            {
                x = Math.Round(x / Math.Pow(1.05, Math.Abs(XModifier.Value - 3)), 2);
            }

            boxLength.Text = "Length: " + Math.Round(l - 2 * x, 2).ToString();
            boxWidth.Text = "Width: " + Math.Round(w - 2 * x, 2).ToString();
            boxHeight.Text = "Height: " + x.ToString();
            boxVolume.Text = "Volume: " + Math.Round((l - 2 * x) * (w - 2 * x) * x, 2).ToString() + " cm³";
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            Length.Text = "60";
            Width.Text = "40";

            CalculateButton.PerformClick();
        }

        #endregion

        #region Other Methods

        private double Optimization(double l, double w)
        {
            //V = (l - 2x)(w - 2x)x
            //V = 4x^3 - (2*l + 2*w)x^2 + l*w*x

            double b = -(2 * l + 2 * w);
            //V' = 12x^2 + 2*bx + l*w
            //V' = 12x^2 - 2*(2*l + 2*w)x + l*w
            //V' = 0, solve for x


            /* IMPORTANT: In this context, the root when subtracting the discriminant is the only possible answer
             * because the root when adding the discriminant will result in a negative side length. For this
             * reason, it is unnecessary to check if V'' is < 0 to indicate max. */

            #region V''

            //double xWhenSubtraction = (-(b * 2) - Math.Sqrt(Math.Pow(b * 2, 2) - 4 * 12 * (l * w))) / (2 * 12);
            //double xWhenAddition = (-(b * 2) + Math.Sqrt(Math.Pow(b * 2, 2) - 4 * 12 * (l * w))) / (2 * 12);

            //V'' = 24x + 2*b
            //V'' = 24x - 2*(2*l + 2*w)

            //if (24 * xWhenSubtraction + 2 * b < 0)          //concave down means max
            //    return Math.Round(xWhenSubtraction, 2);
            //else
            //    return Math.Round(xWhenAddition, 2);

            #endregion

            return Math.Round((-(b * 2) - Math.Sqrt(Math.Pow(b * 2, 2) - 4 * 12 * (l * w))) / (2 * 12), 2);
        }

        private void DrawCube(int i)
        {
            scaleLabel.Visible = true;

            //
            //         * * * * * * * * * * * *
            //       * A                B  * *
            //     *                     *   *
            //   *                     *     *
            //  * * * * * * * * * * * *      *
            //  * C                 D *      *
            //  *                     *      *
            //  *                     *    E *
            //  *                     *     *
            //  *                     *   *
            //  * F                 G * *
            //  * * * * * * * * * * * *
            //

            //Change in length
            //Point A = new Point(220, 80), B = new Point(370 - i * 20, 80), C = new Point(180, 130),
            //    D = new Point(330 - i * 20, 130), E = new Point(370 - i * 20, 180), F = new Point(180, 230),
            //    G = new Point(330 - i * 20, 230);

            //Change in width
            //Point A = new Point(220 - i * 5, 80 + i * 6), B = new Point(370 - i * 5, 80 + i * 6), C = new Point(180, 130),
            //    D = new Point(330, 130), E = new Point(370 - i * 5, 180 + i * 6), F = new Point(180, 230),
            //    G = new Point(330, 230);

            //Change in height
            //Point A = new Point(220, 80 - i * 10), B = new Point(370, 80 - i * 10), C = new Point(180, 130 - i * 10),
            //    D = new Point(330, 130 - i * 10), E = new Point(370, 180), F = new Point(180, 230),
            //    G = new Point(330, 230);

            //Sum of above changes for final box
            Point A = new Point(120 - i * 5, 40 - i * 4), B = new Point(330 - i * 25, 40 - i * 4), C = new Point(60, 90 - i * 10),
                D = new Point(270 - i * 20, 90 - i * 10), E = new Point(330 - i * 25, 120 + i * 6), F = new Point(60, 170),
                G = new Point(270 - i * 20, 170);

            Graphics cube = Graphics.FromImage(BoxBitmap);

            cube.Clear(BoxPictureBox.BackColor);

            //Start with top-left coordinate and continue clockwise
            Point[] frontFace = { C, D, G, F };
            Point[] topFace = { A, B, D, C };
            Point[] sideFace = { B, E, G, D };

            cube.DrawPolygon(Pens.Blue, frontFace);
            cube.DrawPolygon(Pens.Blue, topFace);
            cube.DrawPolygon(Pens.Blue, sideFace);
            DrawX(cube, A, D, B, C);

            BoxPictureBox.Refresh();
            cube.Dispose();
        }

        private void DrawX(Graphics graphic, Point A, Point B, Point C, Point D)
        {
            graphic.DrawLine(Pens.Red, A, B);
            graphic.DrawLine(Pens.Red, C, D);
        }

        #endregion
    }
}
