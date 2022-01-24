namespace DeckShuffleApp
{
    /*
     * Each card contains a rank and a suit
     */
    public class Card
    {
        private string rank;
        private char suit;
        public Card(char suit = 'a', string rank = "1")
        {
            this.suit = suit;
            this.rank = rank;
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public char Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
}
