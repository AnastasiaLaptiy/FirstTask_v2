using FirstTask_v2.Enumerators;
using FirstTask_v2.Models;
using System.Collections;

namespace FirstTask_v2.EnumerableOnes
{
    public class CardEnumerable 
    {
        private CardModel[] deck;

        public CardEnumerable(CardModel[] deckList)
        {
            for (int i = 0; i < deckList.Length; i++)
            {
                deck = deckList;

            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CardEnumerator(deck);

        }
    }
}
