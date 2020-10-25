namespace Lottery
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fieldOne = new System.Windows.Forms.Button();
            this.fieldFour = new System.Windows.Forms.Button();
            this.fieldTwo = new System.Windows.Forms.Button();
            this.fieldThree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldOne
            // 
            this.fieldOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fieldOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fieldOne.BackgroundImage")));
            this.fieldOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fieldOne.Location = new System.Drawing.Point(12, 152);
            this.fieldOne.Name = "fieldOne";
            this.fieldOne.Size = new System.Drawing.Size(200, 200);
            this.fieldOne.TabIndex = 0;
            this.fieldOne.UseVisualStyleBackColor = false;
            this.fieldOne.Click += new System.EventHandler(this.fieldOne_Click);
            // 
            // fieldFour
            // 
            this.fieldFour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fieldFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fieldFour.BackgroundImage")));
            this.fieldFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fieldFour.Location = new System.Drawing.Point(642, 152);
            this.fieldFour.Name = "fieldFour";
            this.fieldFour.Size = new System.Drawing.Size(200, 200);
            this.fieldFour.TabIndex = 1;
            this.fieldFour.UseVisualStyleBackColor = false;
            this.fieldFour.Click += new System.EventHandler(this.fieldFour_Click);
            // 
            // fieldTwo
            // 
            this.fieldTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fieldTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fieldTwo.BackgroundImage")));
            this.fieldTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fieldTwo.Location = new System.Drawing.Point(222, 152);
            this.fieldTwo.Name = "fieldTwo";
            this.fieldTwo.Size = new System.Drawing.Size(200, 200);
            this.fieldTwo.TabIndex = 2;
            this.fieldTwo.UseVisualStyleBackColor = false;
            this.fieldTwo.Click += new System.EventHandler(this.fieldTwo_Click);
            // 
            // fieldThree
            // 
            this.fieldThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fieldThree.BackgroundImage = global::Lottery.Properties.Resources.clover;
            this.fieldThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fieldThree.Location = new System.Drawing.Point(432, 152);
            this.fieldThree.Name = "fieldThree";
            this.fieldThree.Size = new System.Drawing.Size(200, 200);
            this.fieldThree.TabIndex = 3;
            this.fieldThree.UseVisualStyleBackColor = false;
            this.fieldThree.Click += new System.EventHandler(this.fieldThree_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldThree);
            this.Controls.Add(this.fieldTwo);
            this.Controls.Add(this.fieldFour);
            this.Controls.Add(this.fieldOne);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fieldOne;
        private System.Windows.Forms.Button fieldFour;
        private System.Windows.Forms.Button fieldTwo;
        private System.Windows.Forms.Button fieldThree;
        private System.Windows.Forms.Button button1;
    }
}