using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardValidation
{
    public partial class CreditCardValidationForm : Form
    {
        //Examples: 4484663142585415 - Visa, 601195145328714 - Unsupported, 5358390378156038 - Unsupported, 375627815798423 - Amex

        //To enable generate button, input "25-10-2002" in expiry date textbox

        #region Global Variables

        //Fonts
        Font regularFont = new Font(FontFamily.GenericSansSerif, 10.2F, FontStyle.Regular);     //Italics
        Font italicFont = new Font(FontFamily.GenericSansSerif, 10.2F, FontStyle.Italic);       //Regular

        //Timer variables
        Timer timer = new Timer();
        private int secondsLeft = 5;

        //Generate variables
        Random randInt = new Random();
        bool inputWasGenerated = false;

        #endregion

        #region Constructor Method

        public CreditCardValidationForm()
        {
            InitializeComponent();

            CardNumberTextBox.MaxLength = 19;
            CardNumberTextBox.TabStop = false;

            ExpiryDateTextBox.MaxLength = 10;
            ExpiryDateTextBox.TabStop = false;

            ProceedButton.Enabled = false;
            ProceedButton.TabStop = false;

            CancelButton.TabStop = false;
            CancelButton.Select();

            GenerateButton.Enabled = false;
            GenerateButton.TabStop = false;
        }

        #endregion

        #region Event Handlers

        private void CardNumberTextBox_Click(object sender, EventArgs e)
        {
            SetTextBoxes(CardNumberTextBox, "14-16 digits", "", regularFont);
            SetTextBoxes(ExpiryDateTextBox, "", "MM-DD-YYYY", italicFont);
        }

        private void ExpiryDateTextBox_Click(object sender, EventArgs e)
        {
            SetTextBoxes(ExpiryDateTextBox, "MM-DD-YYYY", "", regularFont);
            SetTextBoxes(CardNumberTextBox, "", "14-16 digits", italicFont);
        }

        private void CreditCardValidationForm_Click(object sender, EventArgs e)
        {
            SetTextBoxes(CardNumberTextBox, "", "14-16 digits", italicFont);
            SetTextBoxes(ExpiryDateTextBox, "", "MM-DD-YYYY", italicFont);

            CancelButton.Select();      //Set focus to cancel button
        }

        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))     //Only accept number and control keys
                e.Handled = true;
        }

        private void ExpiryDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-'))   //Only accept number, control, and '-' keys
                e.Handled = true;
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //Any credit card number range is 12-19
            //http://www.dirigodev.com/blog/ecommerce/anatomy-of-a-credit-card-number/

            if (!inputWasGenerated)     //Not necessary to check if values were generated
            {
                if (CardNumberTextBox.TextLength >= 12)     //Max length set to 19
                {
                    if (CardNumberTextBox.TextLength >= 14 && CardNumberTextBox.TextLength <= 16)   //Range of supported card number lengths
                    {
                        if (CheckSum(CardNumberTextBox.Text) % 10 == 0)
                            cardTypeLabel.Text = CreditCardType(CardNumberTextBox.Text);
                        else
                            cardTypeLabel.Text = "Unsupported";
                    }
                    else
                    {
                        cardTypeLabel.Text = "Unsupported";
                    }
                }
                else
                {
                    cardTypeLabel.Text = "";
                }
            }

            //Conditions to enable proceed button
            if (cardTypeLabel.Text != "Unsupported" && cardTypeLabel.Text != "" && expiryDateLabel.Text == "Active")
                ProceedButton.Enabled = true;
            else
                ProceedButton.Enabled = false;
        }

        private void ExpiryDateTextBox_TextChanged(object sender, EventArgs e)
        {
            //Typical expiration 2-4 years
            //https://pocketsense.com/long-credit-card-expire-16923.html

            if (!inputWasGenerated)     //Not necessary to check if values were generated
            {
                if (ExpiryDateTextBox.Text != "MM-DD-YYYY" && ExpiryDateTextBox.TextLength == 10)   //Max length set to 10
                {
                    bool isDateTime = DateTime.TryParse(ExpiryDateTextBox.Text, out DateTime inputDate);

                    if (isDateTime)
                    {
                        if (inputDate > DateTime.Now)       //Expiry date past today
                        {
                            if (inputDate.Year - DateTime.Now.Year >= 4)    //Expiry year within 4 years
                                expiryDateLabel.Text = "Invalid Date";
                            else
                                expiryDateLabel.Text = "Active";
                        }
                        else
                            expiryDateLabel.Text = "Expired";
                    }
                    else
                    {
                        expiryDateLabel.Text = "Invalid";
                    }
                }
                else
                {
                    expiryDateLabel.Text = "";
                }
            }

            if (ExpiryDateTextBox.Text == "25-10-2002")     //Key to enable generate button
                GenerateButton.Enabled = true;

            //Conditions to enable proceed button
            if (cardTypeLabel.Text != "Unsupported" && cardTypeLabel.Text != "" && expiryDateLabel.Text == "Active")
                ProceedButton.Enabled = true;
            else
                ProceedButton.Enabled = false;
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your transaction has been processed", "Transaction Complete");

            //Timer before closing application
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (secondsLeft > 0)
            {
                countDownLabel.Text = "The application will close in " + secondsLeft.ToString();
                secondsLeft--;
            }
            else
            {
                Application.Exit();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            inputWasGenerated = true;
            CardNumberTextBox.Font = ExpiryDateTextBox.Font = regularFont;

            switch (randInt.Next(1, 5))     //Random selection of a card and its prefix to generate
            {
                case 1:
                    cardTypeLabel.Text = "Visa";
                    CardNumberTextBox.Text = GenerateNumber(4, 16);
                    break;
                case 2:
                    cardTypeLabel.Text = "Master Card or Diners Club (US/CAN)";
                    CardNumberTextBox.Text = GenerateNumber(randInt.Next(51, 55), 16);
                    break;
                case 3:
                    cardTypeLabel.Text = "American Express";
                    CardNumberTextBox.Text = GenerateNumber(randInt.Next(1), 15);
                    break;
                case 4:
                    cardTypeLabel.Text = "Discover";
                    CardNumberTextBox.Text = GenerateNumber(6011, 16);
                    break;
                case 5:
                    cardTypeLabel.Text = "Diners Club (International)";
                    CardNumberTextBox.Text = GenerateNumber(36, 14);
                    break;
            }

            expiryDateLabel.Text = "Active";
            ExpiryDateTextBox.Text = DateTime.Now.AddYears(1).ToString("MM-dd-yyyy");   //1 year ahead of today
        }

        #endregion

        #region Other Methods

        private void SetTextBoxes(TextBox inputBox, string condition, string newText, Font newFont)
        {
            if (inputBox.Text == condition)
            {
                inputBox.Text = newText;
                inputBox.Font = newFont;
            }
        }

        private string CreditCardType(string cardNumber)
        {
            if (cardNumber.Length == 16)
            {
                if (cardNumber.Substring(0, 1) == "4")
                {
                    return "Visa";
                }
                else if (Convert.ToInt16(cardNumber.Substring(0, 2)) >= 51 && Convert.ToInt16(cardNumber.Substring(0, 2)) <= 55)
                {
                    return "Master Card or Diners Club (US/CAN)";
                }
                else if (cardNumber.Substring(0, 4) == "6011")
                {
                    return "Discover";
                }
            }
            else if (cardNumber.Length == 15 && (cardNumber.Substring(0, 2) == "34" || cardNumber.Substring(0, 2) == "37"))
            {
                return "American Express";
            }
            else if (cardNumber.Length == 14 && cardNumber.Substring(0, 2) == "36")
            {
                return "Diners Club (International)";
            }

            return "Unsupported";
        }

        private int CheckSum(string cardNumber)
        {
            if (cardNumber.Length % 2 != 0)         //Align positions for card number length of 15
                cardNumber = '0' + cardNumber;

            int checkSum = 0, number;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                number = Convert.ToInt16(cardNumber[i].ToString());

                if (i % 2 == 0)
                {
                    number *= 2;
                    if (number >= 10)
                        number -= 9;
                }

                checkSum += number;
            }

            return checkSum;
        }

        private string GenerateNumber(int prefix, int length)
        {
            //American Express prefix
            if (prefix == 0)
                prefix = 34;
            else if (prefix == 1)
                prefix = 37;

            string generatedNumber = prefix.ToString();

            while (length - generatedNumber.Length != 1)        //Random numbers till last number
                generatedNumber += randInt.Next(9).ToString();

            generatedNumber += '0';     //Placeholder for last number

            int checkSum = CheckSum(generatedNumber);

            int valueToNext10 = 0;

            while ((checkSum + valueToNext10) % 10 != 0)    //CheckSum should be divisible by 10
                valueToNext10++;

            return generatedNumber.Remove(generatedNumber.Length - 1) + valueToNext10.ToString();     //Remove placeholder and add actual number
        }

        #endregion

    }
}
