using System;
using System.Collections.Generic;
using System.Linq;
namespace CardGames
{
    public class Deck
    {
        public List<Card> cardDeck { get; set; }
        public Deck()
        {
            cardDeck = new List<Card>();
                Dictionary<int, string> cardDict = new Dictionary<int, string>()
                {
                    {1, "ace"},
                    {2, "2"},
                    {3, "3"},
                    {4, "4"},
                    {5, "5"},
                    {6, "6"},
                    {7, "7"},
                    {8, "8"},
                    {9, "9"},
                    {10, "10"},
                    {11, "Jack"},
                    {12, "Queen"},
                    {13, "King"}
                };
                string[] suits = new string[] {"Hearts", "Diamonds", "Clubs", "Spades"};
                foreach (string suit in suits)
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        cardDeck.Add(new Card(suit, cardDict[i], i));
                    }
                }
        }

        public void shuffle()
        {
            Random rnd = new Random();
            this.cardDeck = this.cardDeck.OrderBy(x => rnd.Next()).ToList();
        }
        
        public void dealHand(Player player, int amount)
        {
            player.hand = new Hand(this, amount);
        }
    }
}