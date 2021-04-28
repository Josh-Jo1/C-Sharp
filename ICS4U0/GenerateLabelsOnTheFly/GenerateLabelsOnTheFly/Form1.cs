using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateLabelsOnTheFly
{
    public partial class Form1 : Form
    {
        private List<Label> labelList = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateNewLabel(List<Label> labelList, string namePrefix)
        {
            labelList.Add(new Label());

            int largestIndex = labelList.Count - 1;

            labelList[largestIndex].AutoSize = true;
            labelList[largestIndex].Location = new Point(50, 50 + 20 * largestIndex);
            labelList[largestIndex].Name = namePrefix + largestIndex.ToString();
            //labelList[largestIndex].Size = new Size(20, 20);
            labelList[largestIndex].Text = labelList[largestIndex].Name;

            this.Controls.Add(labelList[largestIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateNewLabel(labelList, "Josh");
        }
    }
}
