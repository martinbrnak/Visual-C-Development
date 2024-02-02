namespace ProgrammingProblem5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgTails = new System.Windows.Forms.PictureBox();
            this.imgHeads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeads
            // 
            this.btnHeads.Location = new System.Drawing.Point(59, 349);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(75, 44);
            this.btnHeads.TabIndex = 0;
            this.btnHeads.Text = "Show Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(179, 349);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(75, 45);
            this.btnTails.TabIndex = 1;
            this.btnTails.Text = "Show Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgTails
            // 
            this.imgTails.Image = ((System.Drawing.Image)(resources.GetObject("imgTails.Image")));
            this.imgTails.Location = new System.Drawing.Point(232, 89);
            this.imgTails.Name = "imgTails";
            this.imgTails.Size = new System.Drawing.Size(180, 180);
            this.imgTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTails.TabIndex = 3;
            this.imgTails.TabStop = false;
            this.imgTails.Visible = false;
            // 
            // imgHeads
            // 
            this.imgHeads.Image = ((System.Drawing.Image)(resources.GetObject("imgHeads.Image")));
            this.imgHeads.Location = new System.Drawing.Point(21, 89);
            this.imgHeads.Name = "imgHeads";
            this.imgHeads.Size = new System.Drawing.Size(180, 180);
            this.imgHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeads.TabIndex = 4;
            this.imgHeads.TabStop = false;
            this.imgHeads.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 419);
            this.Controls.Add(this.imgHeads);
            this.Controls.Add(this.imgTails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox imgTails;
        private System.Windows.Forms.PictureBox imgHeads;
    }
}

