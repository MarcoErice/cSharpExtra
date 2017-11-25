namespace CardStack
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
            this.cboSuit = new System.Windows.Forms.ComboBox();
            this.cboValues = new System.Windows.Forms.ComboBox();
            this.lstCard = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.lbSuit = new System.Windows.Forms.Label();
            this.lbValues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSuit
            // 
            this.cboSuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuit.FormattingEnabled = true;
            this.cboSuit.Location = new System.Drawing.Point(132, 81);
            this.cboSuit.Name = "cboSuit";
            this.cboSuit.Size = new System.Drawing.Size(242, 33);
            this.cboSuit.TabIndex = 0;
            // 
            // cboValues
            // 
            this.cboValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValues.FormattingEnabled = true;
            this.cboValues.Location = new System.Drawing.Point(462, 81);
            this.cboValues.Name = "cboValues";
            this.cboValues.Size = new System.Drawing.Size(242, 33);
            this.cboValues.TabIndex = 1;
            // 
            // lstCard
            // 
            this.lstCard.FormattingEnabled = true;
            this.lstCard.ItemHeight = 25;
            this.lstCard.Location = new System.Drawing.Point(132, 239);
            this.lstCard.Name = "lstCard";
            this.lstCard.Size = new System.Drawing.Size(572, 279);
            this.lstCard.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(242, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(462, 151);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(242, 65);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbSuit
            // 
            this.lbSuit.AutoSize = true;
            this.lbSuit.Location = new System.Drawing.Point(137, 37);
            this.lbSuit.Name = "lbSuit";
            this.lbSuit.Size = new System.Drawing.Size(49, 25);
            this.lbSuit.TabIndex = 5;
            this.lbSuit.Text = "Suit";
            // 
            // lbValues
            // 
            this.lbValues.AutoSize = true;
            this.lbValues.Location = new System.Drawing.Point(466, 37);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(78, 25);
            this.lbValues.TabIndex = 6;
            this.lbValues.Text = "Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 783);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.lbSuit);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCard);
            this.Controls.Add(this.cboValues);
            this.Controls.Add(this.cboSuit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSuit;
        private System.Windows.Forms.ComboBox cboValues;
        private System.Windows.Forms.ListBox lstCard;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lbSuit;
        private System.Windows.Forms.Label lbValues;
    }
}

