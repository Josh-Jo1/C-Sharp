namespace Pascals_Triangle_and_Sierpinski_Triangle
{
    partial class TrianglesForm
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
            this.TrianglePictureBox = new System.Windows.Forms.PictureBox();
            this.PascalsTriangleButton = new System.Windows.Forms.Button();
            this.SierpinskiTriangleButton = new System.Windows.Forms.Button();
            this.CombinedTriangleButton = new System.Windows.Forms.Button();
            this.SierpinskiPyramidsButton = new System.Windows.Forms.Button();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.RowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColourComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TrianglePictureBox
            // 
            this.TrianglePictureBox.Location = new System.Drawing.Point(0, 0);
            this.TrianglePictureBox.Name = "TrianglePictureBox";
            this.TrianglePictureBox.Size = new System.Drawing.Size(762, 490);
            this.TrianglePictureBox.TabIndex = 0;
            this.TrianglePictureBox.TabStop = false;
            this.TrianglePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TrianglePictureBox_Paint);
            // 
            // PascalsTriangleButton
            // 
            this.PascalsTriangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PascalsTriangleButton.Location = new System.Drawing.Point(12, 506);
            this.PascalsTriangleButton.Name = "PascalsTriangleButton";
            this.PascalsTriangleButton.Size = new System.Drawing.Size(110, 55);
            this.PascalsTriangleButton.TabIndex = 1;
            this.PascalsTriangleButton.Text = "Pascal\'s\r\nTriangle";
            this.PascalsTriangleButton.UseVisualStyleBackColor = true;
            this.PascalsTriangleButton.Click += new System.EventHandler(this.PascalsTriangleButton_Click);
            // 
            // SierpinskiTriangleButton
            // 
            this.SierpinskiTriangleButton.AutoSize = true;
            this.SierpinskiTriangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SierpinskiTriangleButton.Location = new System.Drawing.Point(128, 506);
            this.SierpinskiTriangleButton.Name = "SierpinskiTriangleButton";
            this.SierpinskiTriangleButton.Size = new System.Drawing.Size(110, 55);
            this.SierpinskiTriangleButton.TabIndex = 2;
            this.SierpinskiTriangleButton.Text = "Sierpinski\r\nTriangle";
            this.SierpinskiTriangleButton.UseVisualStyleBackColor = true;
            this.SierpinskiTriangleButton.Click += new System.EventHandler(this.SierpinskiTriangleButton_Click);
            // 
            // CombinedTriangleButton
            // 
            this.CombinedTriangleButton.AutoSize = true;
            this.CombinedTriangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombinedTriangleButton.Location = new System.Drawing.Point(244, 506);
            this.CombinedTriangleButton.Name = "CombinedTriangleButton";
            this.CombinedTriangleButton.Size = new System.Drawing.Size(110, 55);
            this.CombinedTriangleButton.TabIndex = 3;
            this.CombinedTriangleButton.Text = "Combined\r\nTriangle";
            this.CombinedTriangleButton.UseVisualStyleBackColor = true;
            this.CombinedTriangleButton.Click += new System.EventHandler(this.CombinedTriangleButton_Click);
            // 
            // SierpinskiPyramidsButton
            // 
            this.SierpinskiPyramidsButton.AutoSize = true;
            this.SierpinskiPyramidsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SierpinskiPyramidsButton.Location = new System.Drawing.Point(360, 506);
            this.SierpinskiPyramidsButton.Name = "SierpinskiPyramidsButton";
            this.SierpinskiPyramidsButton.Size = new System.Drawing.Size(110, 55);
            this.SierpinskiPyramidsButton.TabIndex = 4;
            this.SierpinskiPyramidsButton.Text = "Sierpinski\r\nPyramids";
            this.SierpinskiPyramidsButton.UseVisualStyleBackColor = true;
            this.SierpinskiPyramidsButton.Click += new System.EventHandler(this.SierpinskiPyramidsButton_Click);
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(508, 508);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(46, 17);
            this.rowsLabel.TabIndex = 5;
            this.rowsLabel.Text = "Rows:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(632, 508);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 17);
            this.depthLabel.TabIndex = 6;
            this.depthLabel.Text = "Depth:";
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(501, 540);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(53, 17);
            this.colourLabel.TabIndex = 7;
            this.colourLabel.Text = "Colour:";
            // 
            // RowsUpDown
            // 
            this.RowsUpDown.Location = new System.Drawing.Point(560, 506);
            this.RowsUpDown.Name = "RowsUpDown";
            this.RowsUpDown.Size = new System.Drawing.Size(53, 22);
            this.RowsUpDown.TabIndex = 8;
            this.RowsUpDown.ValueChanged += new System.EventHandler(this.RowsUpDown_ValueChanged);
            // 
            // DepthUpDown
            // 
            this.DepthUpDown.Location = new System.Drawing.Point(688, 506);
            this.DepthUpDown.Name = "DepthUpDown";
            this.DepthUpDown.Size = new System.Drawing.Size(53, 22);
            this.DepthUpDown.TabIndex = 9;
            this.DepthUpDown.ValueChanged += new System.EventHandler(this.DepthUpDown_ValueChanged);
            // 
            // ColourComboBox
            // 
            this.ColourComboBox.FormattingEnabled = true;
            this.ColourComboBox.Location = new System.Drawing.Point(560, 537);
            this.ColourComboBox.Name = "ColourComboBox";
            this.ColourComboBox.Size = new System.Drawing.Size(181, 24);
            this.ColourComboBox.TabIndex = 10;
            this.ColourComboBox.SelectedIndexChanged += new System.EventHandler(this.ColourComboBox_SelectedIndexChanged);
            // 
            // TrianglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 573);
            this.Controls.Add(this.ColourComboBox);
            this.Controls.Add(this.DepthUpDown);
            this.Controls.Add(this.RowsUpDown);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.SierpinskiPyramidsButton);
            this.Controls.Add(this.CombinedTriangleButton);
            this.Controls.Add(this.SierpinskiTriangleButton);
            this.Controls.Add(this.PascalsTriangleButton);
            this.Controls.Add(this.TrianglePictureBox);
            this.Name = "TrianglesForm";
            this.Text = "Pascal\'s Triangle and Sierpinski Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.TrianglePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TrianglePictureBox;
        private System.Windows.Forms.Button PascalsTriangleButton;
        private System.Windows.Forms.Button SierpinskiTriangleButton;
        private System.Windows.Forms.Button CombinedTriangleButton;
        private System.Windows.Forms.Button SierpinskiPyramidsButton;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.NumericUpDown RowsUpDown;
        private System.Windows.Forms.NumericUpDown DepthUpDown;
        private System.Windows.Forms.ComboBox ColourComboBox;
    }
}

