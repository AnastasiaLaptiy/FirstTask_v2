using FirstTask_v2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstTask_v2.Managers
{
    public class DeckManager : IEnumerable
    {
        private CardModel[] deck;

        public DeckManager(CardModel[] deckList)
        {
            deck = new CardModel[deckList.Length];
            for (int i = 0; i < deckList.Length; i++)
            {
                deck[i] = deckList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public DeckEnumerator GetEnumerator()
        {
            return new DeckEnumerator(deck);
        }
    }
}