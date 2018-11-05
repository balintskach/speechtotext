namespace speechToText
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
            if (disposing && (components != null)) {
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
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.recordBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(35, 155);
            this.resultTxtBox.Multiline = true;
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(460, 244);
            this.resultTxtBox.TabIndex = 1;
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(197, 87);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(141, 23);
            this.recordBtn.TabIndex = 2;
            this.recordBtn.Text = "Start";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by Bálint Skach";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.resultTxtBox);
            this.Name = "Form1";
            this.Text = "Speech To Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Label label1;
    }
}

