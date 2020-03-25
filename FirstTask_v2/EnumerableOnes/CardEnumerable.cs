using FirstTask_v2.Models;
using System.Collections;


namespace FirstTask_v2.EnumerableOnes
{
    public class CardEnumerable : IEnumerable
    {
        private CardModel[] deck;

        public CardEnumerable(CardModel[] deckList)
        {
            for (int i = 0; i < deckList.Length; i++)
            {
                deck[i] = deckList[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
