using StructApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructApp.Structs
{
    struct Cards : IComparable
    {
        public CardValues Value { get; set; }
        public CardSuits Suit { get; set; }

        public Cards(CardValues value, CardSuits suit)
        {
            Value = value;
            Suit = suit;
        }

        public int CompareTo(object compareCard)
        {
            if (Value.Equals(((Cards)compareCard).Value)) return 0;
            else if (Value.Equals(((Cards)compareCard).Value)) return 1;
            else  return -1;
        }
    }
}
