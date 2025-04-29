namespace CSVquizApp
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(114, 27);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(41, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Label";
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(117, 83);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(103, 20);
            this.rbOptionA.TabIndex = 1;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "radioButton1";
            this.rbOptionA.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(117, 129);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(103, 20);
            this.rbOptionB.TabIndex = 2;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "radioButton2";
            this.rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Location = new System.Drawing.Point(117, 176);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(103, 20);
            this.rbOptionC.TabIndex = 3;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "radioButton3";
            this.rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionD
            // 
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Location = new System.Drawing.Point(117, 225);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(103, 20);
            this.rbOptionD.TabIndex = 4;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "radioButton4";
            this.rbOptionD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(609, 368);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbOptionD);
            this.Controls.Add(this.rbOptionC);
            this.Controls.Add(this.rbOptionB);
            this.Controls.Add(this.rbOptionA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Button btnNext;
    }
}

