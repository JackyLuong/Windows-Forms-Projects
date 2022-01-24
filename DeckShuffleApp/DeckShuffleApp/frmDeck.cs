using System;
using System.Windows.Forms;

namespace DeckShuffleApp
{
    public partial class frmDeck : Form
    {
        private Deck cardDeck = new Deck();

        public frmDeck()
        {
            InitializeComponent();
        }

        //Loads all the cards in the deck
        private void frmDeck_Load(object sender, EventArgs e)
        {
            foreach (Card card in cardDeck.Cards)
            {
                lstDeck.Items.Add($"{card.Suit}{card.Rank}");
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            cardDeck.shuffleDeck();
            lstDeck.Items.Clear();
            foreach (Card card in cardDeck.Cards)
            {
                lstDeck.Items.Add($"{card.Suit}{card.Rank}");
            }
        }
    }
}
