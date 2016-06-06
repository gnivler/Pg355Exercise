using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg355Exercise
{
    class Card : IComparable<Card>
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="value"></param>
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
            _name = $"{value} of {suit}";
        }

        public int CompareTo(Card other)
        {
            if (Value > other.Value)
            {
                return 1;
            }
            if (Value < other.Value)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}