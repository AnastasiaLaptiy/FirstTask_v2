using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2.Enumerators
{
    public class CardEnumerator : IEnumerator, IEnumerable
    {
        private int position = -1;
        private CardModel[] deck;

        public CardEnumerator(CardModel[] deckList)
        {
            deck = deckList;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public CardModel Current
        {
            get
            {
                try
                {
                    return deck[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < deck.Length;
        }

        public void Reset()
        {
            position = -1;
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
