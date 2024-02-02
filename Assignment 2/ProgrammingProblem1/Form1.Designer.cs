namespace ProgrammingProblem1
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
            this.btnLatinUp = new System.Windows.Forms.Button();
            this.btnLatinDown = new System.Windows.Forms.Button();
            this.btnLatinCenter = new System.Windows.Forms.Button();
            this.txtTranslate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLatinUp
            // 
            this.btnLatinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatinUp.Location = new System.Drawing.Point(68, 63);
            this.btnLatinUp.Name = "btnLatinUp";
            this.btnLatinUp.Size = new System.Drawing.Size(75, 23);
            this.btnLatinUp.TabIndex = 0;
            this.btnLatinUp.Text = "autem";
            this.btnLatinUp.UseVisualStyleBackColor = true;
            this.btnLatinUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLatinDown
            // 
            this.btnLatinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatinDown.Location = new System.Drawing.Point(68, 161);
            this.btnLatinDown.Name = "btnLatinDown";
            this.btnLatinDown.Size = new System.Drawing.Size(75, 23);
            this.btnLatinDown.TabIndex = 1;
            this.btnLatinDown.Text = "descendit";
            this.btnLatinDown.UseVisualStyleBackColor = true;
            this.btnLatinDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLatinCenter
            // 
            this.btnLatinCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatinCenter.Location = new System.Drawing.Point(68, 264);
            this.btnLatinCenter.Name = "btnLatinCenter";
            this.btnLatinCenter.Size = new System.Drawing.Size(75, 23);
            this.btnLatinCenter.TabIndex = 2;
            this.btnLatinCenter.Text = "medium";
            this.btnLatinCenter.UseVisualStyleBackColor = true;
            this.btnLatinCenter.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTranslate
            // 
            this.txtTranslate.AutoSize = true;
            this.txtTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranslate.Location = new System.Drawing.Point(246, 164);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(0, 16);
            this.txtTranslate.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 401);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.btnLatinCenter);
            this.Controls.Add(this.btnLatinDown);
            this.Controls.Add(this.btnLatinUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLatinUp;
        private System.Windows.Forms.Button btnLatinDown;
        private System.Windows.Forms.Button btnLatinCenter;
        private System.Windows.Forms.Label txtTranslate;
    }
}

