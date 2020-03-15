using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2.Managers
{
    public class DeckEnum:IEnumerator
    {
        public CardModel[] deck;

        int position = -1;

        public DeckEnum(CardModel[] list)
        {
            deck = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < deck.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get { return Current; }
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
