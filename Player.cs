using System;
namespace CardGames
{
    public abstract class Player
    {
        public Hand hand { get; set; }
        public int funds { get; set; }
        public string name { get; set; }
        public Player(string name, int funds)
        {
            this.name = name;
            this.funds = funds;
        }
    }
}
