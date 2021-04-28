namespace SelectionSort
{
    partial class MinMaxMedianModeSelectionSortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.MaxButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MeanButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.ScrambleButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.DescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(176, 18);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(99, 22);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(283, 15);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 30);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Add to List";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.ItemHeight = 16;
            this.numberListBox.Location = new System.Drawing.Point(20, 85);
            this.numberListBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.numberListBox.Size = new System.Drawing.Size(255, 340);
            this.numberListBox.TabIndex = 3;
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(283, 85);
            this.MaxButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(150, 40);
            this.MaxButton.TabIndex = 4;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(283, 128);
            this.MinButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(150, 40);
            this.MinButton.TabIndex = 5;
            this.MinButton.Text = "Min";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubmitButton_MouseUp);
            // 
            // MeanButton
            // 
            this.MeanButton.Location = new System.Drawing.Point(283, 171);
            this.MeanButton.Margin = new System.Windows.Forms.Padding(4);
            this.MeanButton.Name = "MeanButton";
            this.MeanButton.Size = new System.Drawing.Size(150, 40);
            this.MeanButton.TabIndex = 6;
            this.MeanButton.Text = "Mean (Average)";
            this.MeanButton.UseVisualStyleBackColor = true;
            this.MeanButton.Click += new System.EventHandler(this.MeanButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(283, 214);
            this.MedianButton.Margin = new System.Windows.Forms.Padding(4);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(150, 40);
            this.MedianButton.TabIndex = 7;
            this.MedianButton.Text = "Median";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(283, 257);
            this.ModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(150, 40);
            this.ModeButton.TabIndex = 8;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(283, 300);
            this.SortButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(150, 40);
            this.SortButton.TabIndex = 9;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(17, 439);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 10;
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.Location = new System.Drawing.Point(283, 385);
            this.ScrambleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(150, 40);
            this.ScrambleButton.TabIndex = 11;
            this.ScrambleButton.Text = "Scramble";
            this.ScrambleButton.UseVisualStyleBackColor = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(283, 50);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(150, 30);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AscendingRadioButton
            // 
            this.AscendingRadioButton.AutoSize = true;
            this.AscendingRadioButton.Checked = true;
            this.AscendingRadioButton.Location = new System.Drawing.Point(283, 343);
            this.AscendingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AscendingRadioButton.Name = "AscendingRadioButton";
            this.AscendingRadioButton.Size = new System.Drawing.Size(95, 21);
            this.AscendingRadioButton.TabIndex = 13;
            this.AscendingRadioButton.TabStop = true;
            this.AscendingRadioButton.Text = "Ascending";
            this.AscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // DescendingRadioButton
            // 
            this.DescendingRadioButton.AutoSize = true;
            this.DescendingRadioButton.Location = new System.Drawing.Point(283, 363);
            this.DescendingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DescendingRadioButton.Name = "DescendingRadioButton";
            this.DescendingRadioButton.Size = new System.Drawing.Size(104, 21);
            this.DescendingRadioButton.TabIndex = 14;
            this.DescendingRadioButton.Text = "Descending";
            this.DescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(20, 50);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(125, 50);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(4);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(150, 30);
            this.RandomButton.TabIndex = 16;
            this.RandomButton.Text = "5-6 Random Values";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // MinMaxMedianModeSelectionSortForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 483);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DescendingRadioButton);
            this.Controls.Add(this.AscendingRadioButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ScrambleButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MedianButton);
            this.Controls.Add(this.MeanButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MinMaxMedianModeSelectionSortForm";
            this.Text = "Basic Operations Implemented with Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MeanButton;
        private System.Windows.Forms.Button MedianButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button ScrambleButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton AscendingRadioButton;
        private System.Windows.Forms.RadioButton DescendingRadioButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RandomButton;
    }
}

