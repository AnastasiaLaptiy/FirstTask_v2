using FirstTask_v2.Managers;
using System.Collections;
using System.Collections.Generic;

namespace FirstTask_v2.Models
{
    public class DeckManager
    {
        public List<CardModel> deck = new List<CardModel>();
        
        public void createDeck(CardModel card)
        {
            deck.Add(card);
        }
        public int Count
        {
            get { return deck.Count; }
        }
        public IEnumerator GetEnumerator()
        {
            return new DeckEnumerator(this);
        }

    }
}
