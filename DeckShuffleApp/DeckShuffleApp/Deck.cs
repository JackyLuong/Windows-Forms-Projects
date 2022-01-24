using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DeckShuffleApp
{
    /*
     * Each Deck has an Array of Cards
     */
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            initCards();
        }
        private void initCards()
        {
            string[] rank = new string[] { "A", "2", "3", "4", "5", "6", "7","8", "9", "10", "J", "Q", "K" };
            char[] suitChar = { '\u2663', '\u2666', '\u2665', '\u2660' };
            int COUNT = 0;
            for(int i = 0; i < rank.Length; i++)
            {
                for (int j = 0; j < suitChar.Length; j++)
                {
                    Card initCard = new Card(suitChar[j], rank[i]);
                    cards.Add(initCard);
                    COUNT++;
                }
            }
        }
        public void shuffleDeck()
        {
            for(int i = 0; i < cards.Count; i++)
            {
                int actNum = generateRandInt();
                if(actNum == 1)
                {
                    Card currentCard = cards[i];
                    cards.RemoveAt(i);
                    cards.Add(currentCard);
                }
            }
        }
        private int generateRandInt()
        {
            Random gen = new Random();
            int num = gen.Next(2);
            return num;
        }

        public List<Card> Cards 
        { 
            get
            {
                return cards;
            }
        }
    }
}
