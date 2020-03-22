using System;
using System.Collections;

namespace FirstTask_v2.Managers
{
    public class DeckEnumerator_v2 : IEnumerator
    {
        private int position = -1;
        DeckManager_v2 deck;

        public DeckEnumerator_v2(DeckManager_v2 deckList)
        {
            deck = deckList;
        }

        public bool MoveNext()
        {
            position++;
            return position < deck.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
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