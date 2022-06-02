using System;
using System.Linq;
using System.Collections.Generic;
namespace CardGames
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a game\n1. Texas Hold'em\n2. Exit");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 2)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            Console.Clear();
            switch (input)
            {
                case 1:
                    {
                        Console.Clear();
                        startHoldem();
                        break;
                    }
                case 2:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        static void startHoldem()
        {
            int smallBlind = 2;
            int bigBlind = 5;
            Console.WriteLine("How Many Players?");
            int playerAmnt;
            while (!int.TryParse(Console.ReadLine(), out playerAmnt) || playerAmnt < 2)
            {
                Console.WriteLine("Please enter a valid number of atleast 2 players.");
            }
            Console.Clear();

            Deck deck = new Deck();
            HoldemTable table = new HoldemTable();
            deck.shuffle();
            List<HoldemPlayer> players = new List<HoldemPlayer>();
            for (int i = 0; i < playerAmnt; i++)
            {
                Console.WriteLine($"Player {i + 1} enter your name:");
                string name = Console.ReadLine();
                Console.Clear();
                players.Add(new HoldemPlayer(name, 1000));
            }
            foreach(HoldemPlayer player in players)
            {
                deck.dealHand(player, 2);
            }
            foreach(HoldemPlayer player in players)
            {
                if(table.onTable.Count() > 0)
                {
                    Console.WriteLine("The cards on the table are:");
                    foreach(Card c in table.onTable)
                    {
                        Console.Write($"{c.Face} of {c.Suit} ");
                    }
                }
                Console.WriteLine($"The current bet is: ${table.currentBet} and the pot value is: ${table.pot}");
                Console.WriteLine($"{player.name} you have ${player.funds}\nYour cards are {player.hand.cardsInHand[0].Face} of {player.hand.cardsInHand[0].Suit} and {player.hand.cardsInHand[1].Face} of {player.hand.cardsInHand[1].Suit}\nWhat do you wish to do?\n1. Fold\n2. Check\n3. Call\n4. Raise");
                int input;
                while(!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 4)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 4.");
                }
                Console.Clear();
                switch (input)
                {
                    case 1:
                        {
                            player.fold();
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                    case 3:
                        {
                            
                            break;
                        }
                    case 4:
                        {
                            while(true)
                            {
                            while(!int.TryParse(Console.ReadLine(), out input) || input < 1)
                            {
                                Console.WriteLine("Please enter a valid number of at least 1");
                            }
                                if (player.bet(input, table))
                                {
                                    break;
                                }
                            }
                            break;
                        }
                }
            }
        }
    }
}