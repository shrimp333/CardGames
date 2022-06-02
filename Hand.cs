using System;
using System.Collections.Generic;
using System.Linq;
namespace CardGames
{
    public class Hand
    {
        public List<Card> cardsInHand { get; set; }
        public Hand(Deck deck, int amount)
        {
            cardsInHand = new List<Card>();
            if (deck.cardDeck.Count() - 1 >= 1)
            {
                for (int i = 0; i < amount; i++)
                {
                    cardsInHand.Add(new Card(deck.cardDeck[0].Suit, deck.cardDeck[0].Face, deck.cardDeck[0].Value));
                    deck.cardDeck.RemoveAt(0);
                }
            }
        }
    }
}