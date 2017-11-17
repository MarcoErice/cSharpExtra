using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (txtName.Text == string.Empty)
            {
                txtName.Text = "Name";
            }
            if (txtAge.Text == string.Empty)
            {
                txtAge.Text = "Age";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            //var age = txtAge.Text;
            int age;
            int.TryParse(txtAge.Text, out age);
            var msg = string.Empty;
            if (age > 0 && age < 13)
            {
                msg = $"{name} is a child.";
            }
            else if (age >= 13 && age <= 18)
            {
                msg = $"{name} is a teenager.";
            }
            else
            {
                msg = $"{name} is an adult.";
            }
            // var message = $"{name} is {age} years old.";
            MessageBox.Show(msg);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
        }

        private void txtAge_MouseClick(object sender, MouseEventArgs e)
        {
            txtAge.Text = "";
        }
    }
}
