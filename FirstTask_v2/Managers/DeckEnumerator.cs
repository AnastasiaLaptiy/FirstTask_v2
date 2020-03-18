using FirstTask_v2.Models;
using System.Collections;

namespace FirstTask_v2.Managers
{
    public class DeckEnumerator : IEnumerator
    {
        int position = -1;
        private DeckManager deckManager;

        public DeckEnumerator(DeckManager enumerable)
        {
            this.deckManager = enumerable;
        }

        public bool MoveNext()
        {
            if (position < deckManager.Count - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        { position = 0; }

        public object Current
        {
            get { return deckManager.deck[position]; }
        }
    }
}
