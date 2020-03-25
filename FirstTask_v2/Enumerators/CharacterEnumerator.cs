using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2.Enumerators
{
    public class CharacterEnumerator : IEnumerator
    {
        private int position = -1;

        private CharacterModel[] character;

        public CharacterEnumerator(CharacterModel[] characterList)
        {
            character = characterList;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {            
            position++;
            return position < character.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        public CharacterModel Current
        {
            get
            {
                try
                {
                    return character[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
