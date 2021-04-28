namespace CreditCardValidation
{
    partial class CreditCardValidationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExpiryDateTextBox = new System.Windows.Forms.TextBox();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countDownLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total: $12.37";
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberTextBox.Location = new System.Drawing.Point(162, 113);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(224, 27);
            this.CardNumberTextBox.TabIndex = 4;
            this.CardNumberTextBox.Text = "14-16 digits";
            this.CardNumberTextBox.Click += new System.EventHandler(this.CardNumberTextBox_Click);
            this.CardNumberTextBox.TextChanged += new System.EventHandler(this.CardNumberTextBox_TextChanged);
            this.CardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTextBox_KeyPress);
            // 
            // ExpiryDateTextBox
            // 
            this.ExpiryDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateTextBox.Location = new System.Drawing.Point(162, 177);
            this.ExpiryDateTextBox.Name = "ExpiryDateTextBox";
            this.ExpiryDateTextBox.Size = new System.Drawing.Size(224, 27);
            this.ExpiryDateTextBox.TabIndex = 5;
            this.ExpiryDateTextBox.Text = "MM-DD-YYYY";
            this.ExpiryDateTextBox.Click += new System.EventHandler(this.ExpiryDateTextBox_Click);
            this.ExpiryDateTextBox.TextChanged += new System.EventHandler(this.ExpiryDateTextBox_TextChanged);
            this.ExpiryDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpiryDateTextBox_KeyPress);
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTypeLabel.Location = new System.Drawing.Point(121, 143);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(265, 20);
            this.cardTypeLabel.TabIndex = 6;
            this.cardTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateLabel.Location = new System.Drawing.Point(121, 207);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(265, 20);
            this.expiryDateLabel.TabIndex = 7;
            this.expiryDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProceedButton
            // 
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.Location = new System.Drawing.Point(204, 234);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(97, 32);
            this.ProceedButton.TabIndex = 8;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(307, 234);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(79, 32);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditCardValidation.Properties.Resources.Card_Types;
            this.pictureBox1.Location = new System.Drawing.Point(407, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 307);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // countDownLabel
            // 
            this.countDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownLabel.Location = new System.Drawing.Point(12, 234);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(119, 85);
            this.countDownLabel.TabIndex = 11;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(250, 272);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(102, 32);
            this.GenerateButton.TabIndex = 13;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CreditCardValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 331);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.ExpiryDateTextBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardValidationForm";
            this.Text = "Credit Card Validation";
            this.Click += new System.EventHandler(this.CreditCardValidationForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.TextBox ExpiryDateTextBox;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Button GenerateButton;
    }
}

