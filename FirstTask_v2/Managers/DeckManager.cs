using FirstTask_v2.Managers;
using System.Collections;

namespace FirstTask_v2.Models
{
    public class DeckManager : IEnumerable
    {
        DeckModel deckModel = new DeckModel();
       
        public DeckManager(CardModel[] deck)
        {
            deckModel.Deck = new CardModel[deck.Length];
            for (int i = 0; i < deck.Length; i++)
            {
                deckModel.Deck[i] = deck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public DeckEnum GetEnumerator()
        {
            return new DeckEnum(deckModel.Deck);
        }
    }
}