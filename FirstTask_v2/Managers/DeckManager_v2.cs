using FirstTask_v2.Models;
using System.Collections;
using System.Collections.Generic;

namespace FirstTask_v2.Managers
{
    public class DeckManager_v2:IEnumerable
    {
        List<CardModel> deck = new List<CardModel>
        {
            new CardModel(1),
            new CardModel(2),
            new CardModel(3)
        };

        public CardModel this[int index]
        {
            get { return deck[index]; }
            set { deck.Insert(index, value); }
        }

        public int Count
        {
            get { return deck.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new DeckEnumerator_v2(this);
        }
    }
}
