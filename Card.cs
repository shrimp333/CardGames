using System;
namespace CardGames
{
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }
        public Card(string pSuit, string pFace, int pValue)
        {
            Suit = pSuit;
            Face = pFace;
            Value = pValue;
        }
    }
}