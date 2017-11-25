using Methods.Structs;
using Methods.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        int _myValue, _result;
        Queue<Card> _cards = new Queue<Card>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var result = Subtract(1, 4);

            int res;
            Multiply(2, 5, out res);
            var calcResult = Calculate(12, 34);
            var x = calcResult.add + calcResult.div;

            var card = CreatedCard(Values.Five, Suits.Clubs);            
        }

        Card GetCard()
        {
            return _cards.Dequeue();
        }
        Card CreatedCard(Values value, Suits suit)
        {
            var card = new Card(value, suit);
            _cards.Enqueue(card);
            //return new Card(value, suit);
            return card;
        }

        int Subtract(int a, int b)
        {
            //var result = a - b;
            //// Gör något med result
            //return result;

            return a - b;
        }

        (double add, double sub, double mult, double div) Calculate(int a, int b)
        {
            var addResult = a + b;

            return (add: addResult, sub: a - b, mult:  a * b, div: (double)a / b);
        }
        void Multiply(int a, int b, out int result)
        {
            result = a * b;
        }
        void Add(int a, int b)
        {
            _result = a * b;
        }

        private void btnGetCard_Click(object sender, EventArgs e)
        {
            var fetchedCard = GetCard();
        }

        void MyMethod()
        {
            _myValue = 10;
        }
    }
}
