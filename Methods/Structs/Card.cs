using Methods.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Structs
{
    struct Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
