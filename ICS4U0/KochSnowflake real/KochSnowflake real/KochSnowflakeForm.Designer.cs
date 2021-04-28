namespace KochSnowflake
{
    partial class KochSnowflakeForm
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
            this.KochSnowflakePictureBox = new System.Windows.Forms.PictureBox();
            this.DisplayKochSnowflakeButton = new System.Windows.Forms.Button();
            this.pointAtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pointBtextbox = new System.Windows.Forms.TextBox();
            this.pointCtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KochSnowflakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KochSnowflakePictureBox
            // 
            this.KochSnowflakePictureBox.Location = new System.Drawing.Point(16, 15);
            this.KochSnowflakePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KochSnowflakePictureBox.Name = "KochSnowflakePictureBox";
            this.KochSnowflakePictureBox.Size = new System.Drawing.Size(800, 724);
            this.KochSnowflakePictureBox.TabIndex = 0;
            this.KochSnowflakePictureBox.TabStop = false;
            this.KochSnowflakePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.KochSnowflakePictureBox_Paint);
            // 
            // DisplayKochSnowflakeButton
            // 
            this.DisplayKochSnowflakeButton.Location = new System.Drawing.Point(16, 746);
            this.DisplayKochSnowflakeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayKochSnowflakeButton.Name = "DisplayKochSnowflakeButton";
            this.DisplayKochSnowflakeButton.Size = new System.Drawing.Size(152, 30);
            this.DisplayKochSnowflakeButton.TabIndex = 1;
            this.DisplayKochSnowflakeButton.Text = "Draw Koch Snowflake";
            this.DisplayKochSnowflakeButton.UseVisualStyleBackColor = true;
            this.DisplayKochSnowflakeButton.Click += new System.EventHandler(this.DisplayKochSnowflakeButton_Click);
            // 
            // pointAtextbox
            // 
            this.pointAtextbox.Location = new System.Drawing.Point(398, 750);
            this.pointAtextbox.Name = "pointAtextbox";
            this.pointAtextbox.Size = new System.Drawing.Size(35, 22);
            this.pointAtextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 753);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Point B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 753);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Point C";
            // 
            // pointBtextbox
            // 
            this.pointBtextbox.Location = new System.Drawing.Point(498, 750);
            this.pointBtextbox.Name = "pointBtextbox";
            this.pointBtextbox.Size = new System.Drawing.Size(35, 22);
            this.pointBtextbox.TabIndex = 6;
            // 
            // pointCtextbox
            // 
            this.pointCtextbox.Location = new System.Drawing.Point(598, 750);
            this.pointCtextbox.Name = "pointCtextbox";
            this.pointCtextbox.Size = new System.Drawing.Size(35, 22);
            this.pointCtextbox.TabIndex = 7;
            // 
            // KochSnowflakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 782);
            this.Controls.Add(this.pointCtextbox);
            this.Controls.Add(this.pointBtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointAtextbox);
            this.Controls.Add(this.DisplayKochSnowflakeButton);
            this.Controls.Add(this.KochSnowflakePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KochSnowflakeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KochSnowflakePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KochSnowflakePictureBox;
        private System.Windows.Forms.Button DisplayKochSnowflakeButton;
        private System.Windows.Forms.TextBox pointAtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pointBtextbox;
        private System.Windows.Forms.TextBox pointCtextbox;
    }
}

