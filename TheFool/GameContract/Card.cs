﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GameContract
{
    [DataContract]
    public class Card
    {
        CardValues value;
        CardSuit suit;

        public Card(CardValues value, CardSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public CardValues GetValue()
        {
            return this.value;
        }

        public CardSuit GetSuit()
        {
            return this.suit;
        }
    }
}
