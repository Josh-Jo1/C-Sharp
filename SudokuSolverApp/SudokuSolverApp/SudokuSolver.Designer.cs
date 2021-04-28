namespace SudokuSolverApp
{
    partial class SudokuSolver
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
            this.GridPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EasyPuzzleButton = new System.Windows.Forms.Button();
            this.MediumPuzzleButton = new System.Windows.Forms.Button();
            this.HardPuzzleButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.HintButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPictureBox
            // 
            this.GridPictureBox.Location = new System.Drawing.Point(30, 30);
            this.GridPictureBox.Name = "GridPictureBox";
            this.GridPictureBox.Size = new System.Drawing.Size(601, 556);
            this.GridPictureBox.TabIndex = 0;
            this.GridPictureBox.TabStop = false;
            this.GridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPictureBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "A well-designed puzzle will\r\nhave 1 unique solution!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EasyPuzzleButton
            // 
            this.EasyPuzzleButton.Location = new System.Drawing.Point(680, 170);
            this.EasyPuzzleButton.Name = "EasyPuzzleButton";
            this.EasyPuzzleButton.Size = new System.Drawing.Size(125, 30);
            this.EasyPuzzleButton.TabIndex = 2;
            this.EasyPuzzleButton.Text = "Easy Puzzle";
            this.EasyPuzzleButton.UseVisualStyleBackColor = true;
            this.EasyPuzzleButton.Click += new System.EventHandler(this.EasyPuzzleButton_Click);
            // 
            // MediumPuzzleButton
            // 
            this.MediumPuzzleButton.Location = new System.Drawing.Point(680, 220);
            this.MediumPuzzleButton.Name = "MediumPuzzleButton";
            this.MediumPuzzleButton.Size = new System.Drawing.Size(125, 30);
            this.MediumPuzzleButton.TabIndex = 3;
            this.MediumPuzzleButton.Text = "Medium Puzzle";
            this.MediumPuzzleButton.UseVisualStyleBackColor = true;
            this.MediumPuzzleButton.Click += new System.EventHandler(this.MediumPuzzleButton_Click);
            // 
            // HardPuzzleButton
            // 
            this.HardPuzzleButton.Location = new System.Drawing.Point(680, 270);
            this.HardPuzzleButton.Name = "HardPuzzleButton";
            this.HardPuzzleButton.Size = new System.Drawing.Size(125, 30);
            this.HardPuzzleButton.TabIndex = 4;
            this.HardPuzzleButton.Text = "Hard Puzzle";
            this.HardPuzzleButton.UseVisualStyleBackColor = true;
            this.HardPuzzleButton.Click += new System.EventHandler(this.HardPuzzleButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(680, 370);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(125, 30);
            this.SolveButton.TabIndex = 5;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // HintButton
            // 
            this.HintButton.Location = new System.Drawing.Point(680, 420);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(125, 30);
            this.HintButton.TabIndex = 6;
            this.HintButton.Text = "Hint";
            this.HintButton.UseVisualStyleBackColor = true;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(698, 453);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(107, 17);
            this.hintLabel.TabIndex = 7;
            this.hintLabel.Text = "Select a square";
            this.hintLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(680, 556);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 30);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SudokuSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.HintButton);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.HardPuzzleButton);
            this.Controls.Add(this.MediumPuzzleButton);
            this.Controls.Add(this.EasyPuzzleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPictureBox);
            this.Name = "SudokuSolver";
            this.Text = "Sudoku Solver";
            ((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EasyPuzzleButton;
        private System.Windows.Forms.Button MediumPuzzleButton;
        private System.Windows.Forms.Button HardPuzzleButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button HintButton;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

