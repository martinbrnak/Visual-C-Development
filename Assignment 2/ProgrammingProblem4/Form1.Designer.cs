namespace ProgrammingProblem4
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
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPunchLine = new System.Windows.Forms.Button();
            this.txtJoke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(68, 66);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPunchLine
            // 
            this.btnPunchLine.Location = new System.Drawing.Point(68, 152);
            this.btnPunchLine.Name = "btnPunchLine";
            this.btnPunchLine.Size = new System.Drawing.Size(75, 23);
            this.btnPunchLine.TabIndex = 1;
            this.btnPunchLine.Text = "Punch Line";
            this.btnPunchLine.UseVisualStyleBackColor = true;
            this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
            // 
            // txtJoke
            // 
            this.txtJoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtJoke.AutoSize = true;
            this.txtJoke.BackColor = System.Drawing.SystemColors.Control;
            this.txtJoke.Location = new System.Drawing.Point(189, 123);
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(0, 13);
            this.txtJoke.TabIndex = 2;
            this.txtJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 241);
            this.Controls.Add(this.txtJoke);
            this.Controls.Add(this.btnPunchLine);
            this.Controls.Add(this.btnSetup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnPunchLine;
        private System.Windows.Forms.Label txtJoke;
    }
}

