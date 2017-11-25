namespace Methods
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
            this.btnGetCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetCard
            // 
            this.btnGetCard.Location = new System.Drawing.Point(57, 63);
            this.btnGetCard.Name = "btnGetCard";
            this.btnGetCard.Size = new System.Drawing.Size(261, 124);
            this.btnGetCard.TabIndex = 0;
            this.btnGetCard.Text = "Get Card";
            this.btnGetCard.UseVisualStyleBackColor = true;
            this.btnGetCard.Click += new System.EventHandler(this.btnGetCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 846);
            this.Controls.Add(this.btnGetCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCard;
    }
}

