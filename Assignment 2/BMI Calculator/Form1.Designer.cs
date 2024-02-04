namespace BMI_Calculator
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
            this.txtHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.Label();
            this.txtHeightUnit1 = new System.Windows.Forms.Label();
            this.txtHeightUnit2 = new System.Windows.Forms.Label();
            this.txtWeightUnit = new System.Windows.Forms.Label();
            this.boxHeight1 = new System.Windows.Forms.TextBox();
            this.boxHeight2 = new System.Windows.Forms.TextBox();
            this.boxWeight = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtHeader = new System.Windows.Forms.Label();
            this.linkEnglish = new System.Windows.Forms.LinkLabel();
            this.linkMetric = new System.Windows.Forms.LinkLabel();
            this.txtFormatting1 = new System.Windows.Forms.Label();
            this.txtFormatting2 = new System.Windows.Forms.Label();
            this.txtFormatting3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEnglish = new System.Windows.Forms.Label();
            this.txtMetric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.AutoSize = true;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(62, 83);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 16);
            this.txtHeight.TabIndex = 0;
            this.txtHeight.Text = "1. Height";
            // 
            // txtWeight
            // 
            this.txtWeight.AutoSize = true;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(62, 188);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(71, 16);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.Text = "2. Weight";
            // 
            // txtHeightUnit1
            // 
            this.txtHeightUnit1.AutoSize = true;
            this.txtHeightUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightUnit1.Location = new System.Drawing.Point(138, 120);
            this.txtHeightUnit1.Name = "txtHeightUnit1";
            this.txtHeightUnit1.Size = new System.Drawing.Size(34, 16);
            this.txtHeightUnit1.TabIndex = 2;
            this.txtHeightUnit1.Text = "Feet";
            // 
            // txtHeightUnit2
            // 
            this.txtHeightUnit2.AutoSize = true;
            this.txtHeightUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightUnit2.Location = new System.Drawing.Point(261, 120);
            this.txtHeightUnit2.Name = "txtHeightUnit2";
            this.txtHeightUnit2.Size = new System.Drawing.Size(46, 16);
            this.txtHeightUnit2.TabIndex = 3;
            this.txtHeightUnit2.Text = "Inches";
            // 
            // txtWeightUnit
            // 
            this.txtWeightUnit.AutoSize = true;
            this.txtWeightUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightUnit.Location = new System.Drawing.Point(138, 208);
            this.txtWeightUnit.Name = "txtWeightUnit";
            this.txtWeightUnit.Size = new System.Drawing.Size(53, 16);
            this.txtWeightUnit.TabIndex = 4;
            this.txtWeightUnit.Text = "Pounds";
            // 
            // boxHeight1
            // 
            this.boxHeight1.Location = new System.Drawing.Point(141, 147);
            this.boxHeight1.Name = "boxHeight1";
            this.boxHeight1.Size = new System.Drawing.Size(100, 20);
            this.boxHeight1.TabIndex = 5;
            // 
            // boxHeight2
            // 
            this.boxHeight2.Location = new System.Drawing.Point(264, 147);
            this.boxHeight2.Name = "boxHeight2";
            this.boxHeight2.Size = new System.Drawing.Size(100, 20);
            this.boxHeight2.TabIndex = 6;
            // 
            // boxWeight
            // 
            this.boxWeight.Location = new System.Drawing.Point(141, 238);
            this.boxWeight.Name = "boxWeight";
            this.boxWeight.Size = new System.Drawing.Size(100, 20);
            this.boxWeight.TabIndex = 7;
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.Color.White;
            this.txtHeader.Location = new System.Drawing.Point(-1, -1);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Padding = new System.Windows.Forms.Padding(15, 5, 600, 5);
            this.txtHeader.Size = new System.Drawing.Size(822, 35);
            this.txtHeader.TabIndex = 8;
            this.txtHeader.Text = "Adult BMI Calculator";
            this.txtHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHeader.UseWaitCursor = true;
            // 
            // linkEnglish
            // 
            this.linkEnglish.AutoSize = true;
            this.linkEnglish.LinkVisited = true;
            this.linkEnglish.Location = new System.Drawing.Point(495, 54);
            this.linkEnglish.Name = "linkEnglish";
            this.linkEnglish.Size = new System.Drawing.Size(41, 13);
            this.linkEnglish.TabIndex = 9;
            this.linkEnglish.TabStop = true;
            this.linkEnglish.Text = "English";
            this.linkEnglish.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEnglish_LinkClicked);
            // 
            // linkMetric
            // 
            this.linkMetric.AutoSize = true;
            this.linkMetric.Location = new System.Drawing.Point(542, 54);
            this.linkMetric.Name = "linkMetric";
            this.linkMetric.Size = new System.Drawing.Size(36, 13);
            this.linkMetric.TabIndex = 10;
            this.linkMetric.TabStop = true;
            this.linkMetric.Text = "Metric";
            this.linkMetric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMetric_LinkClicked);
            // 
            // txtFormatting1
            // 
            this.txtFormatting1.AutoSize = true;
            this.txtFormatting1.Location = new System.Drawing.Point(485, 54);
            this.txtFormatting1.Name = "txtFormatting1";
            this.txtFormatting1.Size = new System.Drawing.Size(13, 13);
            this.txtFormatting1.TabIndex = 11;
            this.txtFormatting1.Text = "( ";
            // 
            // txtFormatting2
            // 
            this.txtFormatting2.AutoSize = true;
            this.txtFormatting2.Location = new System.Drawing.Point(534, 55);
            this.txtFormatting2.Name = "txtFormatting2";
            this.txtFormatting2.Size = new System.Drawing.Size(9, 13);
            this.txtFormatting2.TabIndex = 12;
            this.txtFormatting2.Text = "|";
            // 
            // txtFormatting3
            // 
            this.txtFormatting3.AutoSize = true;
            this.txtFormatting3.Location = new System.Drawing.Point(574, 55);
            this.txtFormatting3.Name = "txtFormatting3";
            this.txtFormatting3.Size = new System.Drawing.Size(13, 13);
            this.txtFormatting3.TabIndex = 13;
            this.txtFormatting3.Text = " )";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(141, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.btnCalculate.Size = new System.Drawing.Size(122, 34);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.AutoSize = true;
            this.txtEnglish.Location = new System.Drawing.Point(495, 55);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(41, 13);
            this.txtEnglish.TabIndex = 15;
            this.txtEnglish.Text = "English";
            // 
            // txtMetric
            // 
            this.txtMetric.AutoSize = true;
            this.txtMetric.Location = new System.Drawing.Point(542, 55);
            this.txtMetric.Name = "txtMetric";
            this.txtMetric.Size = new System.Drawing.Size(36, 13);
            this.txtMetric.TabIndex = 16;
            this.txtMetric.Text = "Metric";
            this.txtMetric.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 342);
            this.Controls.Add(this.txtMetric);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFormatting3);
            this.Controls.Add(this.txtFormatting2);
            this.Controls.Add(this.txtFormatting1);
            this.Controls.Add(this.linkMetric);
            this.Controls.Add(this.linkEnglish);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.boxWeight);
            this.Controls.Add(this.boxHeight2);
            this.Controls.Add(this.boxHeight1);
            this.Controls.Add(this.txtWeightUnit);
            this.Controls.Add(this.txtHeightUnit2);
            this.Controls.Add(this.txtHeightUnit1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHeight;
        private System.Windows.Forms.Label txtWeight;
        private System.Windows.Forms.Label txtHeightUnit1;
        private System.Windows.Forms.Label txtHeightUnit2;
        private System.Windows.Forms.Label txtWeightUnit;
        private System.Windows.Forms.TextBox boxHeight1;
        private System.Windows.Forms.TextBox boxHeight2;
        private System.Windows.Forms.TextBox boxWeight;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.LinkLabel linkEnglish;
        private System.Windows.Forms.LinkLabel linkMetric;
        private System.Windows.Forms.Label txtFormatting1;
        private System.Windows.Forms.Label txtFormatting2;
        private System.Windows.Forms.Label txtFormatting3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label txtEnglish;
        private System.Windows.Forms.Label txtMetric;
    }
}

