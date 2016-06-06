using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg355Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private List<Card> hand = new List<Card>();
        private Card card;
        private string output;

        private void button1_Click(object sender, EventArgs e)
        {
            makeCard();
            MessageBox.Show(card.ToString());
        }

        private Card makeCard()
        {
            card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            return card;
        }

        private List<Card> makeHand()
        {
            while (hand.Count < 5)
            {
                card = makeCard();
                if (hand.Contains(card))
                {
                    hand.Remove(card);
                }
                else
                {
                    hand.Add(card);
                }
            }
            return hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hand.Clear();
            hand = makeHand();
            hand.Sort();
            showHand(hand);
        }

        private void showHand(List<Card> hand)
        {
            output = "";
            foreach (var card in hand)
            {
                output += $"{card.ToString()}\n";
            }
            MessageBox.Show(output);
        }
    }
}