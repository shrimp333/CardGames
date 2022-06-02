using System;
using System.Collections.Generic;
namespace CardGames
{
    class HoldemTable
    {
        public List<Card> onTable { get; set; }
        public int pot { get; set; }
        public int dealerPos { get; set; }
        public int currentBet { get; set; }
        public HoldemTable()
        {
            dealerPos = 0;
            pot = 0;
            onTable = new List<Card>();
        }
        public void dealCard(Deck deck)
        {
            Card card = new Card(deck.cardDeck[0].Suit, deck.cardDeck[0].Face, deck.cardDeck[0].Value);
            onTable.Add(card);
            deck.cardDeck.RemoveAt(0);
        }
    }
}
