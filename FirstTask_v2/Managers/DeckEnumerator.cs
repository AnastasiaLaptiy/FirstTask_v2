using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2.Managers
{
    public class DeckEnumerator : IEnumerator
    {
        private int position = -1;
        private CardModel[] deck;

        public DeckEnumerator(CardModel[] deckList)
        {
            deck = deckList;
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

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
            set { }
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
    }
}