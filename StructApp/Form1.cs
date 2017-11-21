using StructApp.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructApp
{
    public partial class Form1 : Form
    {
        List<Cards> _cards = new List<Cards>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            var card1 = new Cards(Enums.CardValues.King, Enums.CardSuits.Hearts);
            _cards.Add(new Cards(Enums.CardValues.Jack, Enums.CardSuits.Hearts));
            _cards.Add(new Cards(Enums.CardValues.Queen, Enums.CardSuits.Diamonds));
            _cards.Add(card1);

            if (card1.Suit == Enums.CardSuits.Diamonds)
            {

            }
            var selectedCards = _cards.Where(c => c.Suit.Equals(Enums.CardSuits.Hearts));
            */
            _cards.Add(new Cards(Enums.CardValues.Ace, Enums.CardSuits.Diamonds));
            _cards.Add(new Cards(Enums.CardValues.King, Enums.CardSuits.Diamonds));
            _cards.Add(new Cards(Enums.CardValues.Ace, Enums.CardSuits.Clubs));
            _cards.Add(new Cards(Enums.CardValues.Two, Enums.CardSuits.Diamonds));

            foreach (var card in _cards)
            {
                if (card.Suit.Equals(Enums.CardSuits.Clubs))
                {
                    // Do something
                }
            }

            var cards = _cards.Where(c => (int)c.Value > (int)Enums.CardValues.Ten &&
            c.Suit.Equals(Enums.CardSuits.Diamonds));
        }
    }
}
