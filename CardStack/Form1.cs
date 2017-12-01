using CardStack.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardStack
{
    public partial class Form1 : Form
    {
        Stack<Card> _cards = new Stack<Card>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2; i < 15; i++)
            {
                cboValues.Items.Add(i);
            }

            cboSuit.Items.AddRange(
                new string[] { "Hearts", "Clubs", "Spades", "Diamonds" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var suit = cboSuit.SelectedItem.ToString();
            var value = (int)cboValues.SelectedItem;
            var card = new Card(value, suit);

            _cards.Push(card);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (_cards.Count().Equals(0)) return;

            var card = _cards.Pop();
            lstCard.Items.Add($"{card.Value} of {card.Suit}");
        }

        private void lstCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
