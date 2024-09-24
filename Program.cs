using Stacks_palmer_justin;
using System;

namespace Stacks_palmer_justin
{
    internal class Program
    {
        static void Main(string[] args)
        {// array list of cards
            Card[] myCardsArray = new Card[]
            {
                new Card("A", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds"),
            };
            //foreach loop removing cards from deck.
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);
            //number and suit of card in deck foreach loop the card number of card 
            Console.WriteLine("Cards in Deck:");
            foreach(Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
            //cards in your hand jack diamonds 8 hearts 3 diamonds
            Console.WriteLine($"Cards in the deck: {startingDeck.Count};");

            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));
            // prints to the console got any 8's
            Console.WriteLine("Got any 8's");
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }
            //prints to the console Cards in the deck.
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");
            //cards remove from hand 
            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);
            // number and suit of card in deck foreach loop the card
            Console.WriteLine("Card in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}
