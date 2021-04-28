using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KochSnowflake
{
    public partial class KochSnowflakeForm : Form
    {
        #region Fields

        // Static Field: All constants must be static because their values cannot
        // vary at all, and hence, cannot vary across instances of a class.
        private const double ONE_THIRD = 0.3333333333333333; //To save CPU time.

        /**
         * The class 'Bitmap' encapsulates a GDI+ bitmap. 
         * A GDI + bitmap consists of the pixel data for a graphics image, as well as the attributes 
         * of the image.
         * 
         * When the 'Bitmap' class is used to create a 'Bitmap' object, space is allocated in memory 
         * to store the bitmap data. Whenever a drawing method is executed, the image data are updated
         * in memory. However, NOTHING is displayed until the 'Paint' event is raised on the control 
         * on which the drawing is displayed. Drawing images in this way is much faster than drawing 
         * directly to a form, picture box or other control on which images can be drawn. 
         * */
        
        // Instance Field: Bitmap data CAN vary across instances of the class
        private Bitmap kochSnowflakeBitmap = new Bitmap(800, 600);

        private int recursiveDepth = 0;

        #endregion

        public KochSnowflakeForm()
        {
            InitializeComponent();

            pointAtextbox.Text = "300";
            pointBtextbox.Text = "50";
            pointCtextbox.Text = "550";
        }

        private void KochSnowflakePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(kochSnowflakeBitmap, 0, 0);
        }

        private void DisplayKochSnowflakeButton_Click(object sender, EventArgs e)
        {
            // A "Graphics" object ENCAPSULATES a GDI+ drawing surface.
            // Think of it as a drawing/painting canvas that comes with an 
            // extensive set of drawing/painting tools. The term "encapsulate"
            // means that the drawing surface and all associated tools are 
            // "packaged" together in a single object.
            Graphics kochSnowflakeImage = Graphics.FromImage(kochSnowflakeBitmap);

            Pen drawPen = new Pen(Color.Red);
            
            kochSnowflakeImage.Clear(KochSnowflakePictureBox.BackColor);

            // Begin with equilateral triangle ABC
            int triangleHeight = (int)(250 * Math.Sqrt(3));
            Point A = new Point(Convert.ToInt16(pointAtextbox.Text), 0);                //No checks for numerical
            Point B = new Point(Convert.ToInt16(pointBtextbox.Text), triangleHeight);
            Point C = new Point(Convert.ToInt16(pointCtextbox.Text), triangleHeight);

            // Apply the Koch snowflake algorithm to each side of the triangle.
            KochSnowflake(kochSnowflakeImage, drawPen, B, A);
            KochSnowflake(kochSnowflakeImage, drawPen, C, B);
            KochSnowflake(kochSnowflakeImage, drawPen, A, C);

            KochSnowflakePictureBox.Refresh(); // Raise the "Paint" event
        }


        private void KochSnowflake(Graphics drawingSurface, Pen drawingPen, Point P, Point Q)
        {
            // Create position vectors OP and OQ
            Vector2 OP = new Vector2(P.X, P.Y);
            Vector2 OQ = new Vector2(Q.X, Q.Y);

            // Form vector PQ, which is parallel to line segment PQ
            Vector2 PQ = OQ.subtract(OP);

            // Divide PQ into thirds: PA, AB, BP
            // Form position vectors for points A and B
            Vector2 AB = PQ.timesScalar(ONE_THIRD);
            Vector2 OA = OP.add(AB);
            Vector2 OB = OP.add(AB.timesScalar(2.0d));

            // Rotate AB by 300 degrees counterclockwise (60 degrees clockwise)
            Vector2 AM = AB.rotateDeg(300.0d);
            Vector2 OM = OA.add(AM);

            Point A = new Point((int)OA.X, (int)OA.Y);
            Point B = new Point((int)OB.X, (int)OB.Y);
            Point M = new Point((int)OM.X, (int)OM.Y);

            //Allow recursion to end by specifying desired recursion depth
            if (recursiveDepth < 4)
            {
                recursiveDepth++;

                KochSnowflake(drawingSurface, drawingPen, P, A);
                KochSnowflake(drawingSurface, drawingPen, A, M);
                KochSnowflake(drawingSurface, drawingPen, M, B);
                KochSnowflake(drawingSurface, drawingPen, B, Q);

                recursiveDepth--;
            }
            else
            {
                drawingSurface.DrawLine(drawingPen, P, A);
                drawingSurface.DrawLine(drawingPen, B, Q);
                drawingSurface.DrawLine(drawingPen, A, M);
                drawingSurface.DrawLine(drawingPen, B, M);
            }

            //if (PQ.magnitude() > 15) //Continue the recursion if PQ's length > 15 pixels
            //{
            //    // Apply the algorithm recursively to segments PA, AM, MB, BQ
            //    KochSnowflake(drawingSurface, drawingPen, P, A);
            //    KochSnowflake(drawingSurface, drawingPen, A, M);
            //    KochSnowflake(drawingSurface, drawingPen, M, B);
            //    KochSnowflake(drawingSurface, drawingPen, B, Q);
            //}
            //else //End the recursion
            //{
            //    drawingSurface.DrawLine(drawingPen, P, A);
            //    drawingSurface.DrawLine(drawingPen, B, Q);
            //    drawingSurface.DrawLine(drawingPen, A, M);
            //    drawingSurface.DrawLine(drawingPen, B, M);
            //}
        }
    }
}
