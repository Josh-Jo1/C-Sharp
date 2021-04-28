using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class TowerOfHanoiForm : Form
    {
        #region Static (Class) Fields

        /*
         * Fields (aka data fields) are global variables or objects within a class.
         * Static (class) fields are used to store information that does not vary from one
         * instance of a class to anbother.
         */

        // Constants must be static because their values cannot change.

        private const int DISK_HEIGHT = 25, SMALLEST_DISK_WIDTH = 26, DEFAULT_PAUSE_INTERVAL = 500, DEFAULT_NUM_DISKS = 5;
        private const int DEFAULT_SOURCE_PEG = 0, DEFAULT_DEST_PEG = 1;

        /*
         * The following three arrays CAN be declared as STATIC because their data CANNOT VARY 
         * from one instance of the form to another.
         */

        // Store the location of the smallest disk for each peg when all 10 disks are stacked on that peg.
        private static Point[] smallestDiskLocation = new Point[] { new Point(165, 75), new Point(485, 75), new Point(805, 75) };

        // Declare the arrays "diskLabel" and "pegLabel" WITHOUT instantiating them. 
        // These arrays are used to represent the disks and pegs respectively.
        private static Label[] diskLabel, pegLabel;

        #endregion

        #region Instance Fields

        // Instance fields store information that can vary from one instance of a class to another.
        // e.g. The "TextBox" class is used to make text boxes. Each instance of the "TextBox" class
        // will have a different value for the "Text" property. Therefore, the field underlying 
        // the "Text" property CANNOT be declared as static.

        /*
         * The array of stacks of labels declared below CANNOT be declared as static because the data
         * stored in this array WILL VARY from one instance of the form to another.
         */

        // An array of three stacks of labels. Initially, each stack of labels is empty
        // stackForPeg[0] -> stack of disks on peg A
        // stackForPeg[1] -> stack of disks on peg B
        // stackForPeg[2] -> stack of disks on peg C
        private Stack<Label>[] stackForPeg = new Stack<Label>[3]
                                               { new Stack<Label>(), new Stack<Label>(), new Stack<Label>() };

        #endregion

        #region Constructor Method

        public TowerOfHanoiForm()
        {
            // Initialize all components on the form.
            InitializeComponent();

            // Instantiate the arrays "diskLabel" and "pegLabel"
            diskLabel = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            pegLabel = new Label[] { pegA_Label, pegB_Label, pegC_Label };

            /* "FromArgb" creates a "Color" stucture (struct) given "argb" data (alpha, red, green, blue)
             * Overload 3 is being used here: FromArgb(int red, int green, int blue)
             * Each of these parameters takes by an integer ranging from 0 to 255 inclusive.
             * The value of "alpha" determines the transparency of the colour (also 0 to 255).
             * red intensity = (int)(10 * (i - 4.5)^2 + 53)   -> 53 < red <= 255    (red is a quadratic function of i)
             * green intensity = 255 - 20 * i     -> 75 <= green <= 255   (green is a decreasing linear function of i)
             * blue intensity = 20 * i + 75       -> 75 <= blue <= 255    (blue is an increasing linear function of i)
             */

            // Set the following constant properties for each label: BackColor, AutoSize, Height, Width

            for (int i = 0; i < diskLabel.Length; i++)
            {
                diskLabel[i].BackColor = Color.FromArgb((int)(10 * (Math.Pow(i - 4.5, 2)) + 53), 255 - 20 * i, 20 * i + 75);

                // Set "AutoSize" property of each label to "false." This allows the labels to be
                // resized by setting the values of the "Width" and "Height" properties.
                diskLabel[i].AutoSize = false;

                // "AutoSize" property of a label must be set to "false" for the following
                // two statements to have a visible effect.
                diskLabel[i].Width = SMALLEST_DISK_WIDTH + diskLabel[0].Width * i;
                diskLabel[i].Height = DISK_HEIGHT;
            }

            //Initialize for following default values:  Source Peg: 0 (A)   Disks:5

            Initialize(DEFAULT_SOURCE_PEG, DEFAULT_NUM_DISKS);
        }

        #endregion

        #region Instance Methods

        // None of the following methods can be declared as static because the data that they process
        // can vary from one instance of the form to another.

        private void TowerOfHanoi(int n, int sourcePeg, int destPeg, int auxiliaryPeg, int pauseInterval)
        {
            if (n > 0) //Recursion ends when n=0
            {
                TowerOfHanoi(n - 1, sourcePeg, auxiliaryPeg, destPeg, pauseInterval);
                MoveDisk(sourcePeg, destPeg, pauseInterval);
                TowerOfHanoi(n - 1, auxiliaryPeg, destPeg, sourcePeg, pauseInterval);
            }
        }

        private void Initialize(int sourcePeg, int numDisks)
        {
            // Set the location of the smallest disk to the very top of the entire stack of disks.
            diskLabel[0].Left = smallestDiskLocation[sourcePeg].X;
            diskLabel[0].Top = smallestDiskLocation[sourcePeg].Y;

            // Clear the stacks
            for (int i = 0; i < stackForPeg.Length; i++)
            {
                stackForPeg[i] = new Stack<Label>();
            }

            // Set the Size, Location and BackColor properties of each visible disk.
            // Push visible disks onto the stack for the specified peg
            for (int i = diskLabel.Length - 1; i >= diskLabel.Length - numDisks; i--)
            {
                stackForPeg[sourcePeg].Push(diskLabel[i]);

                diskLabel[i].Visible = true;

                // Location is specified by a "Point" object (the "Point" class is found in "System.Drawing")
                diskLabel[i].Location = new Point((int)(diskLabel[0].Left - i * diskLabel[0].Width / 2.0f),
                                                                    diskLabel[0].Top + i * diskLabel[0].Height);
            }

            // Hide the disks that shouldn't be visible.
            for (int i = 0; i < diskLabel.Length - numDisks; i++)
            {
                diskLabel[i].Visible = false;
            }
        }


        private void MoveDisk(int sourcePeg, int destPeg, int pauseTime)
        {
            Label diskToMove = null;
            Label topDiskOfDestStack = null;

            if (stackForPeg[sourcePeg].Count > 0)
            {
                diskToMove = stackForPeg[sourcePeg].Peek();
            }
            else
            {
                return; // Can't move a nonexistent disk.
            }

            if (stackForPeg[destPeg].Count > 0)
            {
                topDiskOfDestStack = stackForPeg[destPeg].Peek();
            }

            // If the move is legal, carry it out. This exploits the fact that the disk sizes are 
            // ordered in the "diskLabel" array from smallest to largest in increasing index order.
            // index 0 -> smallest disk ... index 9 -> largest disk.

            if (topDiskOfDestStack != null)
            {
                if (Array.IndexOf(diskLabel, diskToMove) < Array.IndexOf(diskLabel, topDiskOfDestStack))
                {
                    stackForPeg[destPeg].Push(stackForPeg[sourcePeg].Pop());
                }
                else
                {
                    return; // Move not legal
                }
            }
            else //Destination peg is empty and therefore, the move is legal
            {
                stackForPeg[destPeg].Push(stackForPeg[sourcePeg].Pop());
            }

            // The following code can only be reached if a legal move is being attempted.
            // Move the disk to the destination peg.

            diskToMove.Location = new Point((int)(smallestDiskLocation[destPeg].X + diskLabel[0].Width / 2.0f - diskToMove.Width / 2.0f),
                                                 pegLabel[destPeg].Bottom - stackForPeg[destPeg].Count * diskLabel[0].Height);

            // Pause for the specified number of milliseconds
            Application.DoEvents(); // Used to process the messages waiting in the message queue on the 
                                    // user-interface (UI) thread when performing long-running tasks in the UI thread. 
                                    // See https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.application.doevents?view=netframework-4.7.2#System_Windows_Forms_Application_DoEvents
            Thread.Sleep(pauseTime);
        }

        #endregion

        #region Event Handlers (CANNOT be Static)

        private void SolveTowerOfHanoiButton_Click(object sender, EventArgs e)
        {
            // Very little data validation is needed here because most of it is performed 
            // in the event handlers for the input controls (numeric up down and text boxes).

            SolveTowerOfHanoiButton.Enabled = false;

            int sourcePeg = (SourcePegTextBox.Text == "A") ? 0 : ((SourcePegTextBox.Text == "B") ? 1 : 2);
            int destinationPeg = (DestinationPegTextBox.Text == "A") ? 0 : ((DestinationPegTextBox.Text == "B") ? 1 : 2);

            int auxiliaryPeg;

            if (sourcePeg==0 && destinationPeg==1 || sourcePeg==0 && destinationPeg==1)
            {
                auxiliaryPeg = 2;
            }
            else if (sourcePeg == 0 && destinationPeg == 2 || sourcePeg == 2 && destinationPeg == 0)
            {
                auxiliaryPeg = 1;
            }
            else
            {
                auxiliaryPeg = 0;
            }

            if (sourcePeg != destinationPeg)
            {
                TowerOfHanoi((int)NumDisksNumericUpDown.Value, sourcePeg, destinationPeg, auxiliaryPeg, (int)PauseNumericUpDown.Value);
            }
            else
            {
                MessageBox.Show("The destination peg must be different from the source peg.");
            }
        }

        
        private void InitializeDisksButton_Click(object sender, EventArgs e)
        {
            int sourcePeg = (SourcePegTextBox.Text == "A") ? 0 : ((SourcePegTextBox.Text == "B") ? 1 : 2);
            Initialize(sourcePeg, (int)NumDisksNumericUpDown.Value);
            SolveTowerOfHanoiButton.Enabled = true;
        }

        /*
         * The rmaining event handlers perform most of the needed data validation.
         */
        
        
        // Force the user to click "InitializeDisksButton" if the source or destination peg is changed.

        private void SourcePegTextBox_TextChanged(object sender, EventArgs e)
        {
            SolveTowerOfHanoiButton.Enabled = false;
        }

        private void DestinationPegTextBox_TextChanged(object sender, EventArgs e)
        {
            SolveTowerOfHanoiButton.Enabled = false;
        }


        // Ensure that "SourceTextBox" and "DestinationTextBox" contain only the single characters  "A," "B" or "C"
        
        private void SourcePegTextBox_Leave(object sender, EventArgs e)
        {
            string allowedChars = "ABC";

            // Restore defaults if input is invalid
            if (allowedChars.IndexOf(SourcePegTextBox.Text) < 0 || string.IsNullOrWhiteSpace(SourcePegTextBox.Text))
            {
                SourcePegTextBox.Text = "A";
            }
        }


        private void DestinationPegTextBox_Leave(object sender, EventArgs e)
        {
            string allowedChars = "ABC";

            // Restore defaults if input is invalid
            if (allowedChars.IndexOf(DestinationPegTextBox.Text) < 0 || string.IsNullOrWhiteSpace(DestinationPegTextBox.Text))
            {
                DestinationPegTextBox.Text = "B";
            }
        }

        // Ensure that "NumDisksNumericUpDown" only contains a value from 1 to 10

        private void NumDisksNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (NumDisksNumericUpDown.Value < 1)
            {
                NumDisksNumericUpDown.Value = 1;
            }
            else if (NumDisksNumericUpDown.Value > 10)
            {
                NumDisksNumericUpDown.Value = 10;
            }

            // If the user deletes the value in the numericUpDown control,
            // restore the last valid value.

            if (string.IsNullOrEmpty(NumDisksNumericUpDown.Text))
            {
                NumDisksNumericUpDown.Text = NumDisksNumericUpDown.Value.ToString();
            }
        }

        // Ensure that "PauseNumericUpDown" only contains a value from 1 to 1000

        private void PauseNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (PauseNumericUpDown.Value < 1)
            {
                PauseNumericUpDown.Value = 1;
            }
            else if (PauseNumericUpDown.Value > 1000)
            {
                PauseNumericUpDown.Value = 1000;
            }

            // If the user deletes the value in the numericUpDown control,
            // restore the last valid value.

            if (string.IsNullOrEmpty(PauseNumericUpDown.Text))
            {
                PauseNumericUpDown.Text = PauseNumericUpDown.Value.ToString();
            }
        }

        #endregion
    }
}
