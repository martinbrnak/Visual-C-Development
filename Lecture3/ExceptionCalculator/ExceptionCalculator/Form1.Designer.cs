namespace ExceptionCalculator
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
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtBoxNumber1 = new System.Windows.Forms.TextBox();
            this.txtBoxNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(135, 226);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(101, 88);
            this.btnMult.TabIndex = 0;
            this.btnMult.Text = "Multiply";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(256, 226);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(120, 88);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtBoxNumber1
            // 
            this.txtBoxNumber1.Location = new System.Drawing.Point(159, 100);
            this.txtBoxNumber1.Name = "txtBoxNumber1";
            this.txtBoxNumber1.Size = new System.Drawing.Size(159, 26);
            this.txtBoxNumber1.TabIndex = 2;
            // 
            // txtBoxNumber2
            // 
            this.txtBoxNumber2.Location = new System.Drawing.Point(159, 160);
            this.txtBoxNumber2.Name = "txtBoxNumber2";
            this.txtBoxNumber2.Size = new System.Drawing.Size(159, 26);
            this.txtBoxNumber2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(159, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(0, 20);
            this.txtResult.TabIndex = 4;
            // 
            // txtNumber1
            // 
            this.txtNumber1.AutoSize = true;
            this.txtNumber1.Location = new System.Drawing.Point(52, 100);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(78, 20);
            this.txtNumber1.TabIndex = 5;
            this.txtNumber1.Text = "Number 1";
            // 
            // txtNumber2
            // 
            this.txtNumber2.AutoSize = true;
            this.txtNumber2.Location = new System.Drawing.Point(56, 160);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(74, 20);
            this.txtNumber2.TabIndex = 6;
            this.txtNumber2.Text = "Number2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtBoxNumber2);
            this.Controls.Add(this.txtBoxNumber1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtBoxNumber1;
        private System.Windows.Forms.TextBox txtBoxNumber2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label txtNumber1;
        private System.Windows.Forms.Label txtNumber2;
    }
}

