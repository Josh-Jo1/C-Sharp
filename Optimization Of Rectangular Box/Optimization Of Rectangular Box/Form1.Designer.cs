namespace Optimization_Of_Rectangular_Box
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExampleButton = new System.Windows.Forms.Button();
            this.MaterialPictureBox = new System.Windows.Forms.PictureBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.BoxPictureBox = new System.Windows.Forms.PictureBox();
            this.XModifier = new System.Windows.Forms.TrackBar();
            this.xModifierLabel = new System.Windows.Forms.Label();
            this.boxVolume = new System.Windows.Forms.Label();
            this.boxLength = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.Label();
            this.boxHeight = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Dubai Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(270, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(564, 63);
            this.Title.TabIndex = 3;
            this.Title.Text = "Optimization of Rectangular Box";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(88, 110);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(720, 22);
            this.Question1.TabIndex = 4;
            this.Question1.Text = "A sheet of metal            units by            units is to be used to make an op" +
    "en box.";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.Location = new System.Drawing.Point(88, 153);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(249, 22);
            this.Question2.TabIndex = 6;
            this.Question2.Text = "Find the maximum volume.";
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(255, 110);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(60, 22);
            this.Length.TabIndex = 7;
            this.Length.TabStop = false;
            this.Length.Click += new System.EventHandler(this.Length_Click);
            this.Length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Length_KeyPress);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(414, 110);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(60, 22);
            this.Width.TabIndex = 8;
            this.Width.TabStop = false;
            this.Width.Click += new System.EventHandler(this.Width_Click);
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(777, 151);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 30);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExampleButton
            // 
            this.ExampleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleButton.Location = new System.Drawing.Point(892, 150);
            this.ExampleButton.Name = "ExampleButton";
            this.ExampleButton.Size = new System.Drawing.Size(100, 30);
            this.ExampleButton.TabIndex = 10;
            this.ExampleButton.Text = "Example";
            this.ExampleButton.UseVisualStyleBackColor = true;
            this.ExampleButton.Click += new System.EventHandler(this.ExampleButton_Click);
            // 
            // MaterialPictureBox
            // 
            this.MaterialPictureBox.Location = new System.Drawing.Point(65, 229);
            this.MaterialPictureBox.Name = "MaterialPictureBox";
            this.MaterialPictureBox.Size = new System.Drawing.Size(175, 124);
            this.MaterialPictureBox.TabIndex = 11;
            this.MaterialPictureBox.TabStop = false;
            this.MaterialPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MaterialPictureBox_Paint);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(114, 356);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(110, 22);
            this.lengthLabel.TabIndex = 12;
            this.lengthLabel.Text = "lengthLabel";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(246, 282);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(103, 22);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "widthLabel";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(104, 234);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(65, 22);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "xLabel";
            // 
            // BoxPictureBox
            // 
            this.BoxPictureBox.Location = new System.Drawing.Point(476, 210);
            this.BoxPictureBox.Name = "BoxPictureBox";
            this.BoxPictureBox.Size = new System.Drawing.Size(570, 300);
            this.BoxPictureBox.TabIndex = 15;
            this.BoxPictureBox.TabStop = false;
            this.BoxPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxPictureBox_Paint);
            // 
            // XModifier
            // 
            this.XModifier.LargeChange = 1;
            this.XModifier.Location = new System.Drawing.Point(57, 434);
            this.XModifier.Maximum = 6;
            this.XModifier.Name = "XModifier";
            this.XModifier.Size = new System.Drawing.Size(255, 56);
            this.XModifier.TabIndex = 16;
            this.XModifier.Value = 3;
            this.XModifier.Visible = false;
            this.XModifier.Scroll += new System.EventHandler(this.XModifier_Scroll);
            // 
            // xModifierLabel
            // 
            this.xModifierLabel.Location = new System.Drawing.Point(81, 473);
            this.xModifierLabel.Name = "xModifierLabel";
            this.xModifierLabel.Size = new System.Drawing.Size(208, 25);
            this.xModifierLabel.TabIndex = 17;
            this.xModifierLabel.Text = "xModifierLabel";
            this.xModifierLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxVolume
            // 
            this.boxVolume.AutoSize = true;
            this.boxVolume.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxVolume.Location = new System.Drawing.Point(370, 468);
            this.boxVolume.Name = "boxVolume";
            this.boxVolume.Size = new System.Drawing.Size(106, 22);
            this.boxVolume.TabIndex = 18;
            this.boxVolume.Text = "boxVolume";
            // 
            // boxLength
            // 
            this.boxLength.AutoSize = true;
            this.boxLength.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLength.Location = new System.Drawing.Point(370, 387);
            this.boxLength.Name = "boxLength";
            this.boxLength.Size = new System.Drawing.Size(100, 22);
            this.boxLength.TabIndex = 19;
            this.boxLength.Text = "boxLength";
            // 
            // boxWidth
            // 
            this.boxWidth.AutoSize = true;
            this.boxWidth.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWidth.Location = new System.Drawing.Point(370, 414);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(92, 22);
            this.boxWidth.TabIndex = 20;
            this.boxWidth.Text = "boxWidth";
            // 
            // boxHeight
            // 
            this.boxHeight.AutoSize = true;
            this.boxHeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHeight.Location = new System.Drawing.Point(370, 441);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(98, 22);
            this.boxHeight.TabIndex = 21;
            this.boxHeight.Text = "boxHeight";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLabel.Location = new System.Drawing.Point(479, 153);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(213, 19);
            this.unitsLabel.TabIndex = 22;
            this.unitsLabel.Text = "Units must be 1 or greater!";
            this.unitsLabel.Visible = false;
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.Location = new System.Drawing.Point(908, 471);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(109, 19);
            this.scaleLabel.TabIndex = 23;
            this.scaleLabel.Text = "*Not to scale";
            this.scaleLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 523);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.unitsLabel);
            this.Controls.Add(this.boxHeight);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.boxLength);
            this.Controls.Add(this.boxVolume);
            this.Controls.Add(this.xModifierLabel);
            this.Controls.Add(this.XModifier);
            this.Controls.Add(this.BoxPictureBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.MaterialPictureBox);
            this.Controls.Add(this.ExampleButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MaterialPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExampleButton;
        private System.Windows.Forms.PictureBox MaterialPictureBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.PictureBox BoxPictureBox;
        private System.Windows.Forms.TrackBar XModifier;
        private System.Windows.Forms.Label xModifierLabel;
        private System.Windows.Forms.Label boxVolume;
        private System.Windows.Forms.Label boxLength;
        private System.Windows.Forms.Label boxWidth;
        private System.Windows.Forms.Label boxHeight;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label scaleLabel;
    }
}

