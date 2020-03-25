using FirstTask_v2.Enumerators;
using FirstTask_v2.Models;
using System.Collections;

namespace FirstTask_v2.EnumerableOnes
{
    public class CharacterEnumerable
    {
        private CharacterModel[] characterList;
        public CharacterEnumerable(CharacterModel[] characters)
        {
            characterList = new CharacterModel[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                characterList[i] = characters[i];
            }
        }

        public IEnumerable GetCharacterEnumerator()
        {
            return new CharacterEnumerator(characterList);
        }
        /*
        public IEnumerator GetEnumerator()
        {
            return new CharacterEnumerator(characterList);
        }*/
    }
}
