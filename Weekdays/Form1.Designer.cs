namespace Weekdays
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
            this.cboWeekdays = new System.Windows.Forms.ComboBox();
            this.lstWeekdays = new System.Windows.Forms.ListBox();
            this.lblAreEqual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboWeekdays
            // 
            this.cboWeekdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeekdays.FormattingEnabled = true;
            this.cboWeekdays.Location = new System.Drawing.Point(119, 55);
            this.cboWeekdays.Name = "cboWeekdays";
            this.cboWeekdays.Size = new System.Drawing.Size(180, 33);
            this.cboWeekdays.TabIndex = 0;
            this.cboWeekdays.SelectedIndexChanged += new System.EventHandler(this.Weekdays_SelectedIndexChanged);
            // 
            // lstWeekdays
            // 
            this.lstWeekdays.FormattingEnabled = true;
            this.lstWeekdays.ItemHeight = 25;
            this.lstWeekdays.Location = new System.Drawing.Point(119, 122);
            this.lstWeekdays.Name = "lstWeekdays";
            this.lstWeekdays.Size = new System.Drawing.Size(180, 229);
            this.lstWeekdays.TabIndex = 1;
            this.lstWeekdays.SelectedIndexChanged += new System.EventHandler(this.Weekdays_SelectedIndexChanged);
            // 
            // lblAreEqual
            // 
            this.lblAreEqual.AutoSize = true;
            this.lblAreEqual.Location = new System.Drawing.Point(119, 373);
            this.lblAreEqual.Name = "lblAreEqual";
            this.lblAreEqual.Size = new System.Drawing.Size(70, 25);
            this.lblAreEqual.TabIndex = 2;
            this.lblAreEqual.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 648);
            this.Controls.Add(this.lblAreEqual);
            this.Controls.Add(this.lstWeekdays);
            this.Controls.Add(this.cboWeekdays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWeekdays;
        private System.Windows.Forms.ListBox lstWeekdays;
        private System.Windows.Forms.Label lblAreEqual;
    }
}

