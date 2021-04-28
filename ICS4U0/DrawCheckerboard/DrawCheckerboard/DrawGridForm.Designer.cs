namespace SimpleGDIPlusExample
{
    partial class DrawGridForm
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
            this.components = new System.ComponentModel.Container();
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.DrawCheckerBoardButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DrawGridButton = new System.Windows.Forms.Button();
            this.FlashButton = new System.Windows.Forms.Button();
            this.FlashTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPictureBox
            // 
            this.GridPictureBox.Location = new System.Drawing.Point(3, 2);
            this.GridPictureBox.Name = "GridPictureBox";
            this.GridPictureBox.Size = new System.Drawing.Size(401, 401);
            this.GridPictureBox.TabIndex = 0;
            this.GridPictureBox.TabStop = false;
            this.GridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPictureBox_Paint);
            // 
            // DrawCheckerBoardButton
            // 
            this.DrawCheckerBoardButton.Location = new System.Drawing.Point(76, 414);
            this.DrawCheckerBoardButton.Name = "DrawCheckerBoardButton";
            this.DrawCheckerBoardButton.Size = new System.Drawing.Size(120, 30);
            this.DrawCheckerBoardButton.TabIndex = 1;
            this.DrawCheckerBoardButton.Text = "Draw Checkerboard";
            this.DrawCheckerBoardButton.UseVisualStyleBackColor = true;
            this.DrawCheckerBoardButton.Click += new System.EventHandler(this.DrawCheckerBoardButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.Location = new System.Drawing.Point(292, 414);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(53, 30);
            this.EraseButton.TabIndex = 2;
            this.EraseButton.Text = "Erase";
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(351, 414);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(53, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DrawGridButton
            // 
            this.DrawGridButton.Location = new System.Drawing.Point(5, 414);
            this.DrawGridButton.Name = "DrawGridButton";
            this.DrawGridButton.Size = new System.Drawing.Size(65, 30);
            this.DrawGridButton.TabIndex = 4;
            this.DrawGridButton.Text = "Draw Grid";
            this.DrawGridButton.UseVisualStyleBackColor = true;
            this.DrawGridButton.Click += new System.EventHandler(this.DrawGridButton_Click);
            // 
            // FlashButton
            // 
            this.FlashButton.Location = new System.Drawing.Point(202, 414);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(84, 30);
            this.FlashButton.TabIndex = 5;
            this.FlashButton.Text = "Flash";
            this.FlashButton.UseVisualStyleBackColor = true;
            this.FlashButton.Click += new System.EventHandler(this.FlashButton_Click);
            // 
            // FlashTimer
            // 
            this.FlashTimer.Interval = 500;
            this.FlashTimer.Tick += new System.EventHandler(this.FlashTimer_Tick);
            // 
            // DrawGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 449);
            this.Controls.Add(this.FlashButton);
            this.Controls.Add(this.DrawGridButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EraseButton);
            this.Controls.Add(this.DrawCheckerBoardButton);
            this.Controls.Add(this.GridPictureBox);
            this.Name = "DrawGridForm";
            this.Text = "Drawing Grids Example: Using GDI+ for Simple Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.Button DrawCheckerBoardButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DrawGridButton;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.Timer FlashTimer;
    }
}

