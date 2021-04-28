using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9App
{
    public partial class Form1 : Form
    {
        /* Majority of designer was created from code
         * 
         * Properties changed in Form designer:
         * Width set to 1400 and height to 850
         * StartPosition set to CenterScreen
         * Made a PictureBox and TextBoxes for aging schedule only
         */

        int buttonPressed;

        Label label1Title = new Label
        {
            AutoSize = true,
            Text = "Chapter 9",
            Font = new Font("Lucida Console", 16)
        };

        Button button1 = new Button
        {
            AutoSize = true,
            Text = "Types of Receivables",
            Font = new Font("Lucida Console", 12)
        };

        Button button2 = new Button
        {
            AutoSize = true,
            Text = "Calculation of Interest",
            Font = new Font("Lucida Console", 12)
        };

        Button button3 = new Button
        {
            AutoSize = true,
            Text = "Journal Entries",
            Font = new Font("Lucida Console", 12)
        };

        Button button4 = new Button
        {
            AutoSize = true,
            Text = "Acid Test Ratio",
            Font = new Font("Lucida Console", 12)
        };

        Button button5 = new Button
        {
            AutoSize = true,
            Text = "Receivables Turnover Ratio",
            Font = new Font("Lucida Console", 12)
        };

        Button button6 = new Button
        {
            AutoSize = true,
            Text = "Collection Period",
            Font = new Font("Lucida Console", 12)
        };

        Label label2Basis = new Label
        {
            AutoSize = true,
            Text = "Methods of Estimating Uncollectibles",
            Font = new Font("Lucida Console", 12)
        };

        Button button7 = new Button
        {
            AutoSize = true,
            Text = "Percentage of Sales Basis",
            Font = new Font("Lucida Console", 12)
        };

        Button button8 = new Button
        {
            AutoSize = true,
            Text = "Percentage of Receivables Basis",
            Font = new Font("Lucida Console", 12)
        };

        Label label3Content = new Label
        {
            AutoSize = true,
            Location = new Point(80, 250),
            Font = new Font("Lucida Console", 11)
        };

        Button button9 = new Button
        {
            AutoSize = true,
            Location = new Point(900, 500),
            Text = "Question",
            Font = new Font("Lucida Console", 11),
            Visible = false
        };

        Button button10 = new Button
        {
            AutoSize = true,
            Location = new Point(290, 548),
            Text = "Calculate",
            Font = new Font("Lucida Console", 11),
            Visible = false
        };

        Button button11 = new Button
        {
            AutoSize = true,
            Location = new Point(850, 460),
            Text = "Aging Schedule",
            Font = new Font("Lucida Console", 11),
            Visible = false
        };

        TextBox textBox1 = new TextBox
        {
            Location = new Point(100, 440),
            Size = new Size(200, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        TextBox textBox2 = new TextBox
        {
            Location = new Point(350, 440),
            Size = new Size(200, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        TextBox textBox3 = new TextBox
        {
            Location = new Point(600, 440),
            Size = new Size(200, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        TextBox textBox4 = new TextBox
        {
            Location = new Point(340, 490),
            Size = new Size(220, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        TextBox textBox5 = new TextBox
        {
            Location = new Point(130, 440),
            Size = new Size(280, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        TextBox textBox6 = new TextBox
        {
            Location = new Point(500, 440),
            Size = new Size(290, 10),
            Font = new Font("Lucida Console", 11),
            TextAlign = HorizontalAlignment.Center,
            Visible = false
        };

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void TextBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void TextBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        Button button13 = new Button
        {
            AutoSize = true,
            Location = new Point(800,500),
            Text = "Next",
            Font = new Font("Lucida Console", 12),
            Visible = false
        };

        private void NotRatioCalculationButtons()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button9.Visible = true;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            label4Calc.Text = "";
            AgingChart.Visible = false;

            AgingAmount1.Visible = false;
            AgingAmount1.Text = "0";
            AgingAmount2.Visible = false;
            AgingAmount2.Text = "0";
            AgingAmount3.Visible = false;
            AgingAmount3.Text = "0";
            AgingAmount4.Visible = false;
            AgingAmount4.Text = "0";
            AgingPercent1.Visible = false;
            AgingPercent1.Text = "0";
            AgingPercent2.Visible = false;
            AgingPercent2.Text = "0";
            AgingPercent3.Visible = false;
            AgingPercent3.Text = "0";
            AgingPercent4.Visible = false;
            AgingPercent4.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();

            Controls.Add(label1Title);
            Controls.Add(button1);
            button1.Click += new EventHandler(Button1_Click);
            Controls.Add(button2);
            button2.Click += new EventHandler(Button2_Click);
            Controls.Add(button3);
            button3.Click += new EventHandler(Button3_Click);
            Controls.Add(button4);
            button4.Click += new EventHandler(Button4_Click);
            Controls.Add(button5);
            button5.Click += new EventHandler(Button5_Click);
            Controls.Add(label2Basis);
            Controls.Add(button6);
            button6.Click += new EventHandler(Button6_Click);
            Controls.Add(button7);
            button7.Click += new EventHandler(Button7_Click);
            Controls.Add(button8);
            button8.Click += new EventHandler(Button8_Click);
            Controls.Add(label3Content);
            Controls.Add(button9);
            button9.Click += new EventHandler(Button9_Click);
            Controls.Add(button10);
            button10.Click += new EventHandler(Button10_Click);
            Controls.Add(textBox1);
            textBox1.Click += new EventHandler(TextBox1_Click);
            Controls.Add(textBox2);
            textBox2.Click += new EventHandler(TextBox2_Click);
            Controls.Add(textBox3);
            textBox3.Click += new EventHandler(TextBox3_Click);
            Controls.Add(textBox4);
            textBox4.Click += new EventHandler(TextBox4_Click);
            Controls.Add(label4Calc);
            Controls.Add(textBox5);
            textBox5.Click += new EventHandler(TextBox5_Click);
            Controls.Add(textBox6);
            textBox6.Click += new EventHandler(TextBox6_Click);
            Controls.Add(button11);
            button11.Click += new EventHandler(Button11_Click);
            Controls.Add(button13);
            button13.Click += new EventHandler(Button13_Click);

            Animation.Interval = 5;
            Animation.Tick += new EventHandler(Animation_Tick);
            Animation.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)  //Types of Receivables
        {
            NotRatioCalculationButtons();
            buttonPressed = 1;

            label3Content.Text = "Accounts Receivable\n\n" +
                "  They are amounts owed by customers on account and are generally expected to be collected\n\n" +
                "  within 30 days.\n\n\n" +
                "Notes Receivable\n\n" +
                "  A note normally requires the debtor to pay interest and extends for time periods of 30 to 90\n\n" +
                "  days and represents a debt owed to the creditor.";

            button9.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)  //Calculation of Interest
        {
            NotRatioCalculationButtons();
            buttonPressed = 2;

            label3Content.Text = "Calculation of Interest\n\n" +
                "  A notes payable require the recording of interest revenue which is a percentage of the\n\n" +
                "  debt that the debtor owes to the creditor. For example: $1000 x 6% x 3/12 = $15.\n\n\n\n\n\n\n\n\n" +
                "                          x                           x                         /12\n\n\n\n\n\n\n" +
                "                                      =";

            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.Text = "Principal Value";
            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Text = "Interest Rate in %";
            textBox3.Visible = true;
            textBox3.BringToFront();
            textBox3.Text = "Time in MONTHS";
            button10.Visible = true;
            button10.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)  //Journal Entries
        {
            NotRatioCalculationButtons();
            buttonPressed = 3;

            label3Content.Text = "Converting from A/R to N/R\n\n" +
                "          Notes Receivables - Bhatti Boys          1,000\n\n" +
                "               Accounts Receivables - Bhatti Boys      1,000\n\n\n" +
                "Interest Revenue\n\n" +
                "          Accounts Receivable          13.50\n\n" +
                "               Interest revenue             13.50\n\n\n" +
                "Honouring Notes Receivables\n\n" +
                "          Cash                                 10,150\n\n" +
                "               Notes Receivable - Bhatti Boys      10,000\n\n" +
                "               Interest revenue                    150";

            button9.Visible = false;
            button13.Visible = true;
            button13.BringToFront();
        }

        int counter = 1;

        private void Button13_Click(object sender, EventArgs e) //Journal Entries - Next
        {
            if (counter == 1)
            {
                counter = 2;

                label3Content.Text = "Dishonouring Notes Receivables (expecting eventual collection)\n\n" +
                "          Accounts Receivable - Bhatti Boys        10,150\n\n" +
                "               Notes Receivable - Bhatti Boys          10,000\n\n" +
                "               Interest revenue                        150\n\n\n" +
                "Dishonouring Notes Receivables (not expecting collection)\n\n" +
                "          Allowance for Doubtful Accounts          10,000\n\n" +
                "               Notes Receivable - Bhatti Boys          10,000\n\n\n" +
                "Uncollectible Accounts (sales basis AND receivables basis)\n\n" +
                "          Bad Debts Expense                        24,000\n\n" +
                "               Allowance for Doubtful Accounts          24,000";
            }
            else
            {
                counter = 1;

                label3Content.Text = "Credit Card Expense (bank credit card)\n\n" +
                "          Cash                                 6,499\n\n" +
                "          Credit Card Expense (6,700 * 3%)     201\n\n" +
                "               Sales                               6,700\n\n\n" +
                "Credit Card Expense (non-bank credit card)\n\n" +
                "          Accounts Receivables - American Express      475\n\n" +
                "               Credit Card Expense (500 * 5%)          25\n\n" +
                "               Sales                                       500\n\n\n" +
                "          Cash                                             475\n\n" +
                "               Accounts Receivables - American Express         475";

                button9.Visible = true;
                button9.BringToFront();
            }
        }

        private void Button4_Click(object sender, EventArgs e)  //Acid Test
        {
            NotRatioCalculationButtons();
            buttonPressed = 4;

            label3Content.Text = "Acid Test Ratio\n\n" +
                "  The Acid Test Ratio measures a company’s short-term liquidity which is the company's ability to\n\n" +
                "  satisfy its short-term debts immediately using its current assets. For example, an acid test ratio\n\n" +
                "  of 2:1 would mean the company has $2 of current assets for every dollar of current liabilities.\n\n\n\n\n\n\n" +
                "                          +                           +\n" +
                " ________________________________________________________________________________\n\n\n\n\n\n" +
                "                                      =";

            textBox1.Visible = true;
            textBox1.BringToFront();
            textBox1.Text = "Cash";
            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Text = "Temporary Investment";
            textBox3.Visible = true;
            textBox3.BringToFront();
            textBox3.Text = "Accounts Receivable";
            textBox4.Visible = true;
            textBox4.Text = "Current Liabilities";
            textBox4.BringToFront();
            button9.BringToFront();
            button10.Visible = true;
            button10.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)  //Receivables Turnover
        {
            NotRatioCalculationButtons();
            buttonPressed = 5;

            label3Content.Text = "Receivables Turnover Ratio\n\n" +
                "  The Receivables Turnover Ratio measures the company’s efficiency in converting credit sales to\n\n" +
                "  cash. For example, a receivables turnover ratio of 9 would mean that the company goes through 9\n\n" +
                "  cycles of selling on credit and then collecting those receivable back in cash. The higher the\n\n" +
                "  receivables turnover ratio is, the more liquid the company’s receivables are.\n\n\n\n\n\n" +
                "               ___________________________________________________               \n\n\n\n\n\n" +
                "                                      =";

            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Text = "Net Credit Sales";
            textBox4.Visible = true;
            textBox4.Text = "AVG Accounts Receivable";
            textBox4.BringToFront();
            button9.BringToFront();
            button10.Visible = true;
            button10.BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)  //Collection Period
        {
            NotRatioCalculationButtons();
            buttonPressed = 6;

            label3Content.Text = "Collection Period\n\n" +
                "  The Collection Period measures the effectiveness of a company’s credit and collection policies.\n\n" +
                "  For example, a collection period of 40 days would mean that the company collects its receivables in\n\n" +
                "  40 days (on average) which tells you how efficient the company’s credit and collection policies are.\n\n" +
                "  Generally, the Collection Period should not greatly exceed credit term period which is the time\n\n" +
                "  allowed for payment (usually 30 days).\n\n\n\n" +
                "               ___________________________________________________               \n\n\n\n\n\n" +
                "                                      =";

            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox2.Text = "Total Days in Year";
            textBox4.Visible = true;
            textBox4.Text = "Receivable Turnover";
            textBox4.BringToFront();
            button9.BringToFront();
            button10.Visible = true;
            button10.BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)  //Percentage of Sales
        {
            NotRatioCalculationButtons();
            buttonPressed = 7;

            label3Content.Text = "Percentage of Sales Basis\n\n" +
                "  In the percentage of sales basis, management establishes a percentage relationship between the\n\n" +
                "  amount of credit sales and expected losses from uncollectible account. The expected bad debt\n\n" +
                "  losses are determined by applying the percentage to the value of sales from the current period.\n\n" +
                "  For example:  $600000 x 2% = $12000.\n\n\n\n\n" +
                "                                        x               \n\n\n\n\n\n\n" +
                "                                      =";

            textBox5.Visible = true;
            textBox5.BringToFront();
            textBox5.Text = "Total or Net Credit Sales";
            textBox6.Visible = true;
            textBox6.BringToFront();
            textBox6.Text = "Uncollectible Sales in %";
            button9.BringToFront();
            button10.Visible = true;
            button10.BringToFront();
        }

        private void Button8_Click(object sender, EventArgs e)  //Percentage of Receivables
        {
            NotRatioCalculationButtons();
            buttonPressed = 8;

            label3Content.Text = "Percentage of Receivables Basis\n\n" +
                "  Under the percentage of receivables basis, management establishes a percentage relationship\n\n" +
                "  between the amount of accounts receivable and the required balance in the allowance accounts.\n\n" +
                "  The required balance in the allowance account is determined by applying the percentage to the\n\n" +
                "  accounts receivable balance at the end of the current period. For example:  $100000 x 2% = $2000.\n\n\n\n\n" +
                "                                        x               \n\n\n\n\n\n\n" +
                "                                      =";

            textBox5.Visible = true;
            textBox5.BringToFront();
            textBox5.Text = "Total Receivables";
            textBox6.Visible = true;
            textBox6.BringToFront();
            textBox6.Text = "Uncollectible Receivables in %";
            button9.BringToFront();
            button10.Visible = true;
            button10.BringToFront();
            button11.Visible = true;
            button11.BringToFront();
        }

        private void Button9_Click(object sender, EventArgs e)  //Question
        {
            NotRatioCalculationButtons();

            switch (buttonPressed)
            {
                case 2:
                    label3Content.Text = "Question\n\n" +
                        "  Praj did not attend the CPA presentation and as a result he missed out on learning important\n\n" +
                        "  information that he needed in order to determine how much interest he is owed from a debtor.\n\n" +
                        "  Use the relevant information to determine the interest revenue.\n\n\n\n" +
                        "  Principal Value of Note, $880        Total Accounts Receivable, $7600\n\n" +
                        "  Cash, $22000                        Annual Interest Rate, 6%\n\n" +
                        "  Time, 5 months";
                    break;
                case 3:
                    label3Content.Text = "Question\n\n" +
                        "  “Pahul and Mohit Inc.” just made their first sale and are very excited. However,\n\n" +
                        "  they realize that they don’t know how to record the journal entry for the sale that was made\n\n" +
                        "  through a CIBC credit card. They sold an item for $6,700 and they know that the credit card\n\n" +
                        "  company charges them 3% for every transaction. What is the journal entry in this scenario?";
                    break;
                case 4:
                    label3Content.Text = "Question\n\n" +
                        "  The Bhatti Boys have the current values stored on record. Use the appropriate information to\n\n" +
                        "  determine their acid test ratio.\n\n\n\n" +
                        "  Cash, $2200                          Temporary Investments, $1200\n\n" +
                        "  Total Accounts Receivable, $7600     Doubtful Accounts, $380 (5%)\n\n" +
                        "  Current Liabilities, $650";
                    break;
                case 5:
                    label3Content.Text = "Question\n\n" +
                        "  Aryan has opened up a competitor to Staples after he was fired for being too cool. His company\n\n" +
                        "  has the current values stored on record. Use the appropriate information to determine his\n\n" +
                        "  company's receivables turnover ratio.\n\n\n\n" +
                        "  Accounts Receivable at the Beginning of Year, $7100      Net Credit Sales, $40000\n\n" +
                        "  Accounts Receivable at the End of Year, $8200           Current Liabilities, $650\n\n" +
                        "  Time, 5 months";
                    break;
                case 6:
                    label3Content.Text = "Question\n\n" +
                        "  Aryan calculated the receivables turnover ratio but he carelessly forgot to calculate\n\n" +
                        "  his company’s collection period. Help him out by using this information to determine his\n\n" +
                        "  collection period.\n\n\n\n" +
                        "  Accounts Receivable at the Beginning of Year, $7100      Net Credit Sales, $40000\n\n" +
                        "  Accounts Receivable at the End of Year, $8200           Current Liabilities, $650\n\n" +
                        "  Long-term Liabilities, $12000";
                    break;
                case 7:
                    label3Content.Text = "Question\n\n" +
                        "  Using very advanced calculus, Harshil has determined the values seen below. Calculate\n\n" +
                        "  the bad debts expenses under the percentage of sales basis using the relevant information.\n\n\n\n" +
                        "  Annual Interest Rate, 6%         Net Credit Sales, $40000        Cash, $22000\n\n" +
                        "  Percentage of Receivables that are Uncollectible, 5%\n\n" +
                        "  Percentage of Sales that are Uncollectible, 5%\n\n";
                    break;
                case 8:
                    label3Content.Text = "Question\n\n" +
                        "  Harshil realizes that he wants to know the value of uncollectible accounts under the\n\n" +
                        "  percentage of receivables basis instead. Help him calculate the bad debts expense using\n\n" +
                        "  the relevant information from below.\n\n\n\n" +
                        "  Total Accounts Receivable, $7600                 Annual Interest Rate, 6%\n\n" +
                        "  Percentage of Receivables that are Uncollectible, 5%\n\n" +
                        "  Accounts Receivable at the Beginning of Year, $7100\n\n" +
                        "  Accounts Receivable at the End of Year, $8200";
                    break;
            }
        }

        Label label4Calc = new Label()
        {
            AutoSize = true,
            Location = new Point(450, 550),
            Font = new Font("Lucida Console", 11, FontStyle.Underline)
        };

        private void Button10_Click(object sender, EventArgs e) //Calculate
        {
            label4Calc.BringToFront();

            double calc;

            if (buttonPressed == 2)
            {
                try
                {
                    calc = Convert.ToDouble(textBox1.Text) * (Convert.ToDouble(textBox2.Text) / 100) * (Convert.ToDouble(textBox3.Text) / 12);
                    label4Calc.Text = "$" + Math.Round(calc, 2).ToString();
                }
                catch (FormatException)
                {
                    label4Calc.Text = "Enter Numbers Only";
                }
            }
            else if (buttonPressed == 4)
            {
                try
                {
                    calc = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text)) / Convert.ToDouble(textBox4.Text);
                    label4Calc.Text = Math.Round(calc, 2).ToString();
                }
                catch (FormatException)
                {
                    label4Calc.Text = "Enter Numbers Only";
                }
            }
            else if (buttonPressed == 7 | buttonPressed == 8)
            {
                try
                {
                    calc = Convert.ToDouble(textBox5.Text) * (Convert.ToDouble(textBox6.Text) / 100);
                    label4Calc.Text = "$" + Math.Round(calc, 2).ToString();
                }
                catch (FormatException)
                {
                    label4Calc.Text = "Enter Numbers Only";
                }
            }
            else if (buttonPressed == 11)
            {
                try
                {
                    calc = Convert.ToDouble(AgingAmount1.Text) * (Convert.ToDouble(AgingPercent1.Text) / 100) +
                        Convert.ToDouble(AgingAmount2.Text) * (Convert.ToDouble(AgingPercent2.Text) / 100) +
                        Convert.ToDouble(AgingAmount3.Text) * (Convert.ToDouble(AgingPercent3.Text) / 100) +
                        Convert.ToDouble(AgingAmount4.Text) * (Convert.ToDouble(AgingPercent4.Text) / 100);
                    label4Calc.Text = "$" + Math.Round(calc, 2).ToString();
                }
                catch (FormatException)
                {
                    label4Calc.Text = "Enter Numbers Only";
                }
            }
            else //buttonPressed == 5 or 6
            {
                try
                {
                    calc = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox4.Text);
                    label4Calc.Text = Math.Round(calc, 2).ToString();
                }
                catch (FormatException)
                {
                    label4Calc.Text = "Enter Numbers Only";
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e) //Aging Schedule
        {
            NotRatioCalculationButtons();
            buttonPressed = 11;

            label3Content.Text = "Aging Schedule\n\n" +
                "  An aging schedule is a table that values accounts receivables based off of their age.\n\n" +
                "  As age of receivable increase, so does the percentage of it that is written off.";

            AgingChart.Visible = true;
            button9.Visible = false;
            button10.Visible = true;
            button10.BringToFront();
            label4Calc.Text = "Total Uncollectible";
            label4Calc.BringToFront();

            AgingAmount1.Visible = true;
            AgingAmount1.BringToFront();
            AgingAmount2.Visible = true;
            AgingAmount2.BringToFront();
            AgingAmount3.Visible = true;
            AgingAmount3.BringToFront();
            AgingAmount4.Visible = true;
            AgingAmount4.BringToFront();
            AgingPercent1.Visible = true;
            AgingPercent1.BringToFront();
            AgingPercent2.Visible = true;
            AgingPercent2.BringToFront();
            AgingPercent3.Visible = true;
            AgingPercent3.BringToFront();
            AgingPercent4.Visible = true;
            AgingPercent4.BringToFront();
            button12.Visible = true;
            button12.BringToFront();
        }

        private void AgingAmount1_Click(object sender, EventArgs e)
        {
            AgingAmount1.Text = "";
        }

        private void AgingAmount2_Click(object sender, EventArgs e)
        {
            AgingAmount2.Text = "";
        }

        private void AgingAmount3_Click(object sender, EventArgs e)
        {
            AgingAmount3.Text = "";
        }

        private void AgingAmount4_Click(object sender, EventArgs e)
        {
            AgingAmount4.Text = "";
        }

        private void AgingPercent1_Click(object sender, EventArgs e)
        {
            AgingPercent1.Text = "";
        }

        private void AgingPercent2_Click(object sender, EventArgs e)
        {
            AgingPercent2.Text = "";
        }

        private void AgingPercent3_Click(object sender, EventArgs e)
        {
            AgingPercent3.Text = "";
        }

        private void AgingPercent4_Click(object sender, EventArgs e)
        {
            AgingPercent4.Text = "";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            AgingAmount1.Text = "0";
            AgingAmount2.Text = "0";
            AgingAmount3.Text = "0";
            AgingAmount4.Text = "0";
            AgingPercent1.Text = "0";
            AgingPercent2.Text = "0";
            AgingPercent3.Text = "0";
            AgingPercent4.Text = "0";
        }

        int ticks = 0;
        Timer Animation = new Timer();

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (ticks < 25)
            {
                label1Title.Location = new Point(-20 + 20 * ticks, 30);
                button1.Location = new Point(-320 + 20 * ticks, 65);
                button2.Location = new Point(-70 + 20 * ticks, 65);
                button3.Location = new Point(200 + 20 * ticks, 65);
                button4.Location = new Point(-280 + 20 * ticks, 110);
                button5.Location = new Point(-90 + 20 * ticks, 110);
                button6.Location = new Point(210 + 20 * ticks, 110);
                label2Basis.Location = new Point(-300 + 20 * ticks, 165);
                button7.Location = new Point(-250 + 20 * ticks, 190);
                button8.Location = new Point(50 + 20 * ticks, 190);

                ticks++;
            }
            else
            {
                Animation.Enabled = false;
            }
        }
    }
}
