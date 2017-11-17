namespace FirstWindowsApp
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(454, 31);
            this.txtName.TabIndex = 0;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(132, 120);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(454, 31);
            this.txtAge.TabIndex = 1;
            this.txtAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAge_MouseClick);
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(448, 199);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 67);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 615);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSubmit;
    }
}

