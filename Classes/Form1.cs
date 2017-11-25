using Classes.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        List<Person> _persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var person = new Person(txtName.Text, (int)numAge.Value);
            //person.SetAge((int)numAge.Value);
            //person.Name = txtName.Text;
            _persons.Add(person);
        }
    }
}
