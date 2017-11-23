namespace Loops
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
            this.lbCars = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnMoveCars = new System.Windows.Forms.Button();
            this.lbSelectedCars = new System.Windows.Forms.Label();
            this.lstSelectedCars = new System.Windows.Forms.ListBox();
            this.btnMoveCarsWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCars
            // 
            this.lbCars.AutoSize = true;
            this.lbCars.Location = new System.Drawing.Point(38, 40);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(57, 25);
            this.lbCars.TabIndex = 0;
            this.lbCars.Text = "Cars";
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 25;
            this.lstCars.Location = new System.Drawing.Point(43, 88);
            this.lstCars.Name = "lstCars";
            this.lstCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCars.Size = new System.Drawing.Size(181, 254);
            this.lstCars.TabIndex = 1;
            // 
            // btnMoveCars
            // 
            this.btnMoveCars.Location = new System.Drawing.Point(43, 367);
            this.btnMoveCars.Name = "btnMoveCars";
            this.btnMoveCars.Size = new System.Drawing.Size(181, 56);
            this.btnMoveCars.TabIndex = 2;
            this.btnMoveCars.Text = "Move (For)";
            this.btnMoveCars.UseVisualStyleBackColor = true;
            this.btnMoveCars.Click += new System.EventHandler(this.btnMoveCars_Click);
            // 
            // lbSelectedCars
            // 
            this.lbSelectedCars.AutoSize = true;
            this.lbSelectedCars.Location = new System.Drawing.Point(308, 40);
            this.lbSelectedCars.Name = "lbSelectedCars";
            this.lbSelectedCars.Size = new System.Drawing.Size(147, 25);
            this.lbSelectedCars.TabIndex = 3;
            this.lbSelectedCars.Text = "Selected Cars";
            // 
            // lstSelectedCars
            // 
            this.lstSelectedCars.FormattingEnabled = true;
            this.lstSelectedCars.ItemHeight = 25;
            this.lstSelectedCars.Location = new System.Drawing.Point(313, 88);
            this.lstSelectedCars.Name = "lstSelectedCars";
            this.lstSelectedCars.Size = new System.Drawing.Size(177, 254);
            this.lstSelectedCars.TabIndex = 4;
            // 
            // btnMoveCarsWhile
            // 
            this.btnMoveCarsWhile.Location = new System.Drawing.Point(313, 367);
            this.btnMoveCarsWhile.Name = "btnMoveCarsWhile";
            this.btnMoveCarsWhile.Size = new System.Drawing.Size(177, 56);
            this.btnMoveCarsWhile.TabIndex = 5;
            this.btnMoveCarsWhile.Text = "Move (While)";
            this.btnMoveCarsWhile.UseVisualStyleBackColor = true;
            this.btnMoveCarsWhile.Click += new System.EventHandler(this.btnMoveCarsWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 746);
            this.Controls.Add(this.btnMoveCarsWhile);
            this.Controls.Add(this.lstSelectedCars);
            this.Controls.Add(this.lbSelectedCars);
            this.Controls.Add(this.btnMoveCars);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.lbCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCars;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnMoveCars;
        private System.Windows.Forms.Label lbSelectedCars;
        private System.Windows.Forms.ListBox lstSelectedCars;
        private System.Windows.Forms.Button btnMoveCarsWhile;
    }
}

