﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public static string Plural (Values value)
        {
            if (value == Values.Six)
                return "Sixes"'
            else
                return value.ToString() + "s";
        }

        public Player(String name, Random random, TextBox textBoxOnForm)
        {

        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i<=13++)
            {
                Values value = (Values) i;
                int howMany = 0;
                for (int card = 0; card<cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany ==4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                    cards.PullOutValues(value);
                }
                return books;
            }

        }

        public Deck DoYouHaveAny(Values value)
        {

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {

        }

        public int CardCount { get { return cards.Count; } }

        public void TakeCard(Card card) { cards.Add(card); }

        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }

        public Card Peek(int cardNumber) { return cards.GetCardNames(); }

        public void SortHand() { cards.SortByValue(); }
        

    }
}
