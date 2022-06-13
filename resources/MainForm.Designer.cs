
namespace resources
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCard1 = new System.Windows.Forms.Button();
            this.buttonCard2 = new System.Windows.Forms.Button();
            this.labelImageCredit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCard1
            // 
            this.buttonCard1.Location = new System.Drawing.Point(319, 34);
            this.buttonCard1.Name = "buttonCard1";
            this.buttonCard1.Size = new System.Drawing.Size(112, 34);
            this.buttonCard1.TabIndex = 1;
            this.buttonCard1.Text = "Card 1";
            this.buttonCard1.UseVisualStyleBackColor = true;
            this.buttonCard1.Click += new System.EventHandler(this.buttonCard1_Click);
            // 
            // buttonCard2
            // 
            this.buttonCard2.Location = new System.Drawing.Point(319, 74);
            this.buttonCard2.Name = "buttonCard2";
            this.buttonCard2.Size = new System.Drawing.Size(112, 34);
            this.buttonCard2.TabIndex = 1;
            this.buttonCard2.Text = "Card 2";
            this.buttonCard2.UseVisualStyleBackColor = true;
            this.buttonCard2.Click += new System.EventHandler(this.buttonCard2_Click);
            // 
            // labelImageCredit
            // 
            this.labelImageCredit.AutoSize = true;
            this.labelImageCredit.Location = new System.Drawing.Point(61, 400);
            this.labelImageCredit.Name = "labelImageCredit";
            this.labelImageCredit.Size = new System.Drawing.Size(114, 25);
            this.labelImageCredit.TabIndex = 2;
            this.labelImageCredit.Text = "Image Credit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.labelImageCredit);
            this.Controls.Add(this.buttonCard2);
            this.Controls.Add(this.buttonCard1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCard1;
        private System.Windows.Forms.Button buttonCard2;
        private System.Windows.Forms.Label labelImageCredit;
    }
}

