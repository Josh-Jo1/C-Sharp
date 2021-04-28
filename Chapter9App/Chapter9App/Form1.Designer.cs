namespace Chapter9App
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
            this.AgingChart = new System.Windows.Forms.PictureBox();
            this.AgingAmount1 = new System.Windows.Forms.TextBox();
            this.AgingAmount2 = new System.Windows.Forms.TextBox();
            this.AgingAmount3 = new System.Windows.Forms.TextBox();
            this.AgingAmount4 = new System.Windows.Forms.TextBox();
            this.AgingPercent1 = new System.Windows.Forms.TextBox();
            this.AgingPercent2 = new System.Windows.Forms.TextBox();
            this.AgingPercent3 = new System.Windows.Forms.TextBox();
            this.AgingPercent4 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AgingChart
            // 
            this.AgingChart.Image = global::Chapter9App.Properties.Resources.Grid;
            this.AgingChart.Location = new System.Drawing.Point(200, 405);
            this.AgingChart.Name = "AgingChart";
            this.AgingChart.Size = new System.Drawing.Size(1100, 500);
            this.AgingChart.TabIndex = 0;
            this.AgingChart.TabStop = false;
            this.AgingChart.Visible = false;
            // 
            // AgingAmount1
            // 
            this.AgingAmount1.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingAmount1.Location = new System.Drawing.Point(630, 468);
            this.AgingAmount1.Name = "AgingAmount1";
            this.AgingAmount1.Size = new System.Drawing.Size(200, 26);
            this.AgingAmount1.TabIndex = 1;
            this.AgingAmount1.Text = "0";
            this.AgingAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingAmount1.Visible = false;
            this.AgingAmount1.Click += new System.EventHandler(this.AgingAmount1_Click);
            // 
            // AgingAmount2
            // 
            this.AgingAmount2.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingAmount2.Location = new System.Drawing.Point(630, 519);
            this.AgingAmount2.Name = "AgingAmount2";
            this.AgingAmount2.Size = new System.Drawing.Size(200, 26);
            this.AgingAmount2.TabIndex = 2;
            this.AgingAmount2.Text = "0";
            this.AgingAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingAmount2.Visible = false;
            this.AgingAmount2.Click += new System.EventHandler(this.AgingAmount2_Click);
            // 
            // AgingAmount3
            // 
            this.AgingAmount3.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingAmount3.Location = new System.Drawing.Point(630, 570);
            this.AgingAmount3.Name = "AgingAmount3";
            this.AgingAmount3.Size = new System.Drawing.Size(200, 26);
            this.AgingAmount3.TabIndex = 3;
            this.AgingAmount3.Text = "0";
            this.AgingAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingAmount3.Visible = false;
            this.AgingAmount3.Click += new System.EventHandler(this.AgingAmount3_Click);
            // 
            // AgingAmount4
            // 
            this.AgingAmount4.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingAmount4.Location = new System.Drawing.Point(630, 621);
            this.AgingAmount4.Name = "AgingAmount4";
            this.AgingAmount4.Size = new System.Drawing.Size(200, 26);
            this.AgingAmount4.TabIndex = 4;
            this.AgingAmount4.Text = "0";
            this.AgingAmount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingAmount4.Visible = false;
            this.AgingAmount4.Click += new System.EventHandler(this.AgingAmount4_Click);
            // 
            // AgingPercent1
            // 
            this.AgingPercent1.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingPercent1.Location = new System.Drawing.Point(973, 468);
            this.AgingPercent1.Name = "AgingPercent1";
            this.AgingPercent1.Size = new System.Drawing.Size(200, 26);
            this.AgingPercent1.TabIndex = 5;
            this.AgingPercent1.Text = "0";
            this.AgingPercent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingPercent1.Visible = false;
            this.AgingPercent1.Click += new System.EventHandler(this.AgingPercent1_Click);
            // 
            // AgingPercent2
            // 
            this.AgingPercent2.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingPercent2.Location = new System.Drawing.Point(973, 519);
            this.AgingPercent2.Name = "AgingPercent2";
            this.AgingPercent2.Size = new System.Drawing.Size(200, 26);
            this.AgingPercent2.TabIndex = 6;
            this.AgingPercent2.Text = "0";
            this.AgingPercent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingPercent2.Visible = false;
            this.AgingPercent2.Click += new System.EventHandler(this.AgingPercent2_Click);
            // 
            // AgingPercent3
            // 
            this.AgingPercent3.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingPercent3.Location = new System.Drawing.Point(973, 570);
            this.AgingPercent3.Name = "AgingPercent3";
            this.AgingPercent3.Size = new System.Drawing.Size(200, 26);
            this.AgingPercent3.TabIndex = 7;
            this.AgingPercent3.Text = "0";
            this.AgingPercent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingPercent3.Visible = false;
            this.AgingPercent3.Click += new System.EventHandler(this.AgingPercent3_Click);
            // 
            // AgingPercent4
            // 
            this.AgingPercent4.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.AgingPercent4.Location = new System.Drawing.Point(973, 621);
            this.AgingPercent4.Name = "AgingPercent4";
            this.AgingPercent4.Size = new System.Drawing.Size(200, 26);
            this.AgingPercent4.TabIndex = 8;
            this.AgingPercent4.Text = "0";
            this.AgingPercent4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgingPercent4.Visible = false;
            this.AgingPercent4.Click += new System.EventHandler(this.AgingPercent4_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.button12.Location = new System.Drawing.Point(1000, 673);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 29);
            this.button12.TabIndex = 10;
            this.button12.Text = "Reset";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.AgingPercent4);
            this.Controls.Add(this.AgingPercent3);
            this.Controls.Add(this.AgingPercent2);
            this.Controls.Add(this.AgingPercent1);
            this.Controls.Add(this.AgingAmount4);
            this.Controls.Add(this.AgingAmount3);
            this.Controls.Add(this.AgingAmount2);
            this.Controls.Add(this.AgingAmount1);
            this.Controls.Add(this.AgingChart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AgingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgingChart;
        private System.Windows.Forms.TextBox AgingAmount1;
        private System.Windows.Forms.TextBox AgingAmount2;
        private System.Windows.Forms.TextBox AgingAmount3;
        private System.Windows.Forms.TextBox AgingAmount4;
        private System.Windows.Forms.TextBox AgingPercent1;
        private System.Windows.Forms.TextBox AgingPercent2;
        private System.Windows.Forms.TextBox AgingPercent3;
        private System.Windows.Forms.TextBox AgingPercent4;
        private System.Windows.Forms.Button button12;
    }
}

