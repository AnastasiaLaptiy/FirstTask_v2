using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2.Enumerators
{
    public class CardEnumerator: IEnumerator
    {
        private int position = -1;
        private CardModel[] deck;

        public CardEnumerator(CardModel[] deckList)
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
        }
        
        public CardModel Current
        {
            get
            {
                try
                {
                    if (deck[position].Id == 1)
                    {
                        return deck[position];
                    }
                    else return deck[2]; 
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}
