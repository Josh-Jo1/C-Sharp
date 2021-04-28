using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionSort
{
    public partial class MinMaxMedianModeSelectionSortForm : Form
    {
        #region Global Declarations, Initializations and Instantiations
        // Global variables and objects should be created at the top of the class.
        // If a variable or object is global to a class, any procedure in the class
        // can access and modify it.

        // Declaration: Associates a name with a data type or class
        // Initialization: Gives a variable its initial value
        // Instantiation: Creates an object and initializes it

        /*
         * The part of the following statement that lies to the left of the equals sign 
         * associates the name "numberList" with a list of "double" values. This is called 
         * a "declaration." The part that lies on the right creates the initially empty list. 
         * This is called an "instantiation."
         */
        private List<double> numberList = new List<double>();

        #endregion

        #region A Note on Object-Oriented Programming
        /*
         * In object-oriented programming, classes are the "blueprints" or "templates" for
         * making objects. Just as a cookie-cutter can be used to make any number of cookies,
         * a class can be used to make any number of objects. In Microsoft Visual Studio,
         * objects consist of properties, methods and events.
         * 
         * property-> A variable that belongs to an object, typically used to store
         *            information about a characteristic of the object
         * method  -> A procedure or function that belongs to an object. Methods are
         *            ACTIONS that can be performed by, to or for an object.
         * event   -> An event is a message sent by an object to signal the occurrence 
         *            of an action. Events are used to trigger the execution of code.
         * 
         * For example, the "Button" class is used to make buttons in Windows Forms
         * applications. 
         * 
         * Text    -> A property found within the Button class. It stores the text that is 
         *            displayed on the button.
         * Hide    -> A method found within the Button class. It is used to hide a button.
         * Click   -> An event found within the Button class. The "Click" event is is raised
         *            whenever the user clicks on a button.
         */
        #endregion

        #region Constructor Method
        // The following is called a "constructor method" for the form "SelectionSortForm."
        // Place within the constructor method any code that needs to be executed as 
        // soon as the form is created (i.e. loaded). 
        public MinMaxMedianModeSelectionSortForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers
        
        //Add to List Button
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting

            if (isNumeric) // This is equivalent to 'if (isnumeric == true)'
            {
                // Add the entered number to both the list and the list box
                numberList.Add(number);
                numberListBox.Items.Add(number);

                outputLabel.Text = "";
            }
            else
            {
                MessageBox.Show("You may only enter numbers.", "Who was your kindergarten teacher?");
            }

            numberTextBox.SelectAll();
            numberTextBox.Focus();
        }

        //Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (numberList.Count != 0)
            {
                numberList.Clear();
                numberListBox.Items.Clear();
                numberListBox.SelectedIndex = -1;
                outputLabel.Text = "";
            }

            numberTextBox.Focus();
        }

        //Random List Button
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();

            numberList.Clear();
            numberListBox.Items.Clear();
            outputLabel.Text = "";

            for (int i = 0; i < rndm.Next(5, 7); i++)
            {
                double randomNumber = rndm.Next(-100, 100);
                numberList.Add(randomNumber);
                numberListBox.Items.Add(randomNumber);
            }
            
            numberTextBox.Focus();
        }

        //Search Button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1;

            double index = Search(number, numberList);

            if (isNumeric && numberList.Count != 0)
            {
                if (Double.IsNaN(index))
                {
                    outputLabel.Text = number.ToString() + " was not found.";
                }
                else
                {
                    numberListBox.SetSelected((int)index, true);

                    index++;
                    outputLabel.Text = number.ToString() + " was found at position " + index.ToString() + ".";
                }
            }
            else
            {
                outputLabel.Text = "The textbox or list is empty.";
            }

            numberTextBox.Focus();
        }

        //Max Button
        private void MaxButton_Click(object sender, EventArgs e)
        {
            List<double> maxValueAndIndex = MinimumMaximum(numberList, true);

            numberListBox.SelectedIndex = -1;

            if (maxValueAndIndex.Count != 0)
            {
                double max = maxValueAndIndex[0];

                numberListBox.SelectedIndex = (int)maxValueAndIndex[1];

                outputLabel.Text = "The maximum value is " + max.ToString() + ".";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }

        //Min Button
        private void MinButton_Click(object sender, EventArgs e)
        {
            List<double> minValueAndIndex = MinimumMaximum(numberList, false);
            
            numberListBox.SelectedIndex = -1;

            if (minValueAndIndex.Count != 0)
            {
                double min = minValueAndIndex[0];
                
                numberListBox.SelectedIndex = (int)minValueAndIndex[1];

                outputLabel.Text = "The minimum value is " + min.ToString() + ".";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }

        //Mean (Average) Button
        private void MeanButton_Click(object sender, EventArgs e)
        {
            double mean = Mean(numberList);

            numberListBox.SelectedIndex = -1;

            if (!Double.IsNaN(mean))
            {
                outputLabel.Text = "The mean value is " + mean.ToString() + ".";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }

        //Median Button
        private void MedianButton_Click(object sender, EventArgs e)
        {
            List<double> medianValueAndIndex = Median(numberList);

            numberListBox.SelectedIndex = -1;

            if (medianValueAndIndex.Count != 0)
            {
                double median = medianValueAndIndex[0];

                numberListBox.SelectedIndex = (int)medianValueAndIndex[1];

                if (!Double.IsNaN(medianValueAndIndex[2]))
                {
                    numberListBox.SelectedIndex = (int)medianValueAndIndex[2];
                }

                outputLabel.Text = "The median value is " + median.ToString() + ".";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }

        //Mode Button
        private void ModeButton_Click(object sender, EventArgs e)
        {
            List<double> sortedList = SelectionSort(numberList, true);

            //List<double> modeValues = Mode(sortedList);

            List<double> modeValues = DevMode(sortedList);

            //List<double> modeValues = KevMode(sortedList);

            numberListBox.SelectedIndex = -1;

            if (modeValues.Count != 0)
            {
                for (int i = 0; i < modeValues.Count; i++)
                {
                    double index = Search(modeValues[i], numberList);

                    numberListBox.SelectedIndex = (int)index;
                }
                
                outputLabel.Text = "The mode values are " + String.Join(", ", modeValues) + ".";

                if (modeValues.Count == 1)
                {
                    outputLabel.Text = "The mode value is " + String.Concat(modeValues) + ".";
                }
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }

        //Sort Button
        private void SortButton_Click(object sender, EventArgs e)
        {
            //numberList = SelectionSort(numberList, AscendingRadioButton.Checked);

            //numberList = GnomeSort(numberList);

            numberList = CocktailSort(numberList);
          
            if (numberList.Count != 0)
            {
                numberListBox.Items.Clear();

                foreach (double item in numberList)
                {
                    numberListBox.Items.Add(item.ToString());
                }

                outputLabel.Text = "";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }
        
        //Scramble Button
        private void ScrambleButton_Click(object sender, EventArgs e)
        {
            List<double> scrambledList = Scramble(numberList);
        
            numberListBox.SelectedIndex = -1;

            if (numberList.Count != 0)
            {
                numberListBox.Items.Clear();

                foreach (double item in scrambledList)
                {
                    numberListBox.Items.Add(item.ToString());
                }

                outputLabel.Text = "";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }

            numberTextBox.Focus();
        }
        
        // Used to ensure that the focus stays on the text box when the button is clicked.
        // Otherwise, the button will have the focus.
        private void SubmitButton_MouseUp(object sender, MouseEventArgs e)
        {
            numberTextBox.SelectAll();
            numberTextBox.Focus();
        }

        #endregion

        #region Programmer-Defined Methods

        //Search Algorithm
        private static double Search(double number, List<double> listOfNumbers)
        {
            double index = Double.NaN;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (number == listOfNumbers[i])
                {
                    index = i;
                }
            }

            return index;
        }
                
        //MinMax Algorithm
        private static List<double> MinimumMaximum(List<double> listOfNumbers, bool findMax)
        {
            List<double> minMaxValueAndIndex = new List<double>();

            if (listOfNumbers.Count > 0)
            {
                double smallestLargest = listOfNumbers[0];
                double smallestLargestIndex = 0;

                for (int i = 1; i < listOfNumbers.Count; i++)
                {
                    if (findMax)
                    {
                        if (listOfNumbers[i] > smallestLargest)
                        {
                            smallestLargest = listOfNumbers[i];
                            smallestLargestIndex = i;
                        }
                    }
                    else
                    {
                        if (listOfNumbers[i] < smallestLargest)
                        {
                            smallestLargest = listOfNumbers[i];
                            smallestLargestIndex = i;
                        }
                    }
                }

                minMaxValueAndIndex.Add(smallestLargest);
                minMaxValueAndIndex.Add(smallestLargestIndex);
            }

            return minMaxValueAndIndex;
        }

        //Mean Algorithm
        private static double Mean(List<double> listOfNumbers)
        {
            double mean = Double.NaN;

            if (listOfNumbers.Count > 0)
            {
                double sum = listOfNumbers[0];

                for (int i = 1; i < listOfNumbers.Count; i++)
                {
                    sum += listOfNumbers[i];
                }

                mean = sum / listOfNumbers.Count;
            }

            return mean;
        }
        
        //Median Algorithm
        private static List<double> Median(List<double> listOfNumbers)
        {
            List<double> medianValueAndIndex = new List<double>();

            List<double> listOfNumbersSorted = SelectionSort(listOfNumbers, true);

            if (listOfNumbers.Count > 0)
            {
                double median = listOfNumbersSorted[listOfNumbersSorted.Count / 2];     //upper median
                double medianIndex = Search(median, listOfNumbers);                     //upper median index
                double lowerMedianIndex = Double.NaN;

                if (listOfNumbers.Count % 2 == 0)
                {
                    double lowerMedian = listOfNumbersSorted[listOfNumbersSorted.Count / 2 - 1];
                    lowerMedianIndex = Search(lowerMedian, listOfNumbers);

                    median = (lowerMedian + median) / 2;
                }

                medianValueAndIndex.Add(median);
                medianValueAndIndex.Add(medianIndex);
                medianValueAndIndex.Add(lowerMedianIndex);
            }

            return medianValueAndIndex;
        }
        
        //Mode Algorithm
        private static List<double> Mode(List<double> listOfNumbers)
        {
            List<double> modeValuesList = new List<double>();
            
            if (listOfNumbers.Count > 0)
            {
                List<double> modeInstancesList = new List<double>();

                if (listOfNumbers.Count == 1)
                {
                    modeValuesList.Add(listOfNumbers[0]);
                    modeInstancesList.Add(1);
                }
                else
                {
                    double modeFrequency = 1;

                    for (int i = 0; i < listOfNumbers.Count - 1; i++)
                    {
                        if (listOfNumbers[i] != listOfNumbers[i + 1])
                        {
                            modeValuesList.Add(listOfNumbers[i]);
                            modeInstancesList.Add(modeFrequency);

                            modeFrequency = 0;
                        }

                        modeFrequency++;
                    }

                    if (listOfNumbers[listOfNumbers.Count - 2] == listOfNumbers[listOfNumbers.Count - 1])
                    {
                        modeValuesList.Add(listOfNumbers[listOfNumbers.Count - 2]);
                        modeInstancesList.Add(modeFrequency);
                    }
                    else
                    {
                        modeValuesList.Add(listOfNumbers[listOfNumbers.Count - 1]);
                        modeInstancesList.Add(1);
                    }

                    List<double> mostInstances = MinimumMaximum(modeInstancesList, true);

                    for (int i = modeValuesList.Count - 1; i > -1; i--)
                    {
                        if (mostInstances[0] != modeInstancesList[i])
                        {
                            modeValuesList.RemoveAt(i);
                        }
                    }
                }   
            }

            return modeValuesList;
        }

        //Dev Mode Algorithm
        private static List<double> DevMode(List<double> listOfNumbers)
        {
            List<double> modeValuesList = new List<double>();

            if (listOfNumbers.Count > 0)
            {
                Dictionary<double, double> modeDict = new Dictionary<double, double>();

                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    if (modeDict.ContainsKey(listOfNumbers[i]))
                    {
                        modeDict[listOfNumbers[i]] += 1;
                    }
                    else
                    {
                        modeDict.Add(listOfNumbers[i], 1);
                    }
                }

                List<double> mostInstances = MinimumMaximum(modeDict.Values.ToList(), true);

                for (int i = modeDict.Count - 1; i > -1; i--)
                {
                    if (mostInstances[0] != modeDict.Values.ElementAt(i))
                    {
                        modeDict.Remove(modeDict.Keys.ElementAt(i));
                    }
                }

                modeValuesList = modeDict.Keys.ToList();
            }

            return modeValuesList;
        }

        //Kevin Mode Algorithm
        private static List<double> KevMode(List<double> listOfNumbers)
        {
            List<double> modeValuesList = new List<double>();

            if (listOfNumbers.Count > 0)
            {
                if (listOfNumbers.Count == 1)
                {
                    modeValuesList.Add(listOfNumbers[0]);
                }
                else
                {
                    double currentModeFrequency = 1, highestModeFrequency = 0;

                    for (int i = listOfNumbers.Count - 2; i > -1; i--)
                    {
                        if (listOfNumbers[i] != listOfNumbers[i + 1])
                        {
                            if (highestModeFrequency < currentModeFrequency)
                            {
                                highestModeFrequency = currentModeFrequency;

                                modeValuesList.Clear();
                                modeValuesList.Add(listOfNumbers[i + 1]);
                            }
                            else if (currentModeFrequency == highestModeFrequency)
                            {
                                modeValuesList.Add(listOfNumbers[i + 1]);
                            }

                            currentModeFrequency = 0;
                        }

                        currentModeFrequency++;
                    }

                    modeValuesList = SelectionSort(modeValuesList, true);
                }
            }

            return modeValuesList;
        }

        //Sort Algorithm
        private static List<double> SelectionSort(List<double> listOfNumbers, bool asc)
        {
            List<double> sortedList = new List<double>();

            List<double> listOfNumbersCopy = new List<double>(listOfNumbers);

            if (listOfNumbersCopy.Count > 0)
            {
                foreach (double number in listOfNumbers)
                {
                    List<double> minMax = MinimumMaximum(listOfNumbersCopy, !asc);
                    sortedList.Add(minMax[0]);
                    listOfNumbersCopy.Remove(minMax[0]);
                }
            }

            return sortedList;
        }
        
        //Scramble Algorithm
        private static List<double> Scramble(List<double> listOfNumbers)
        {
            List<double> scrambledList = new List<double>();

            List<double> listOfNumbersCopy = new List<double>(listOfNumbers);

            if (listOfNumbers.Count > 0)
            {
                Random rndm = new Random();

                foreach (double number in listOfNumbers)
                {
                    double value = listOfNumbersCopy[rndm.Next(0, listOfNumbersCopy.Count)];
                    scrambledList.Add(value);
                    listOfNumbersCopy.Remove(value);
                }
            }

            return scrambledList;
        }

        //Practice Test
        private static List<double> GnomeSort(List<double> listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i != 0 && listOfNumbers[i] < listOfNumbers[i - 1])
                {
                    double copy = listOfNumbers[i];
                        
                    listOfNumbers[i] = listOfNumbers[i - 1];
                    listOfNumbers[i - 1] = copy;

                    i -= 2;
                }
            }

            return listOfNumbers;
        }

        //Actual Test
        private static List<double> CocktailSort(List<double> listOfNumbers)
        {
            List<double> sortedList = new List<double>(listOfNumbers);

            int start = 0, end = listOfNumbers.Count - 1;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = start; i < end; i++)
                {
                    if (sortedList[i] > sortedList[i + 1])
                    {
                        double copy = sortedList[i];

                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = copy;

                        sorted = false;
                    }
                }
                /*
                if (sorted)
                {
                    break;
                }
                */
                end -= 1;

                for (int i = end; i > start; i--)
                {
                    if (sortedList[i] < sortedList[i - 1])
                    {
                        double copy = sortedList[i];

                        sortedList[i] = sortedList[i - 1];
                        sortedList[i - 1] = copy;

                        sorted = false;
                    }
                }

                start += 1;
            }

            return sortedList;
        }
            
        #endregion

        }// end of class
}// end of namespace
