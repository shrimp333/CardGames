using System;
namespace CardGames
{
    class HoldemPlayer:Player
    {
        public bool isFolded { get; set; }
        public HoldemPlayer(string pName, int funds):base(pName, funds)
        {
            isFolded = false;
        }
        public void fold()
        {
            this.isFolded = true;
        }
        public bool bet(int i, HoldemTable table)
        {
            if (this.funds >= i)
            {
                this.funds -= i;
                table.pot += i;
                Console.WriteLine($"You have bet ${i}");
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You're unable to bet that much.");
                return false;
            }
        }
    }
}
