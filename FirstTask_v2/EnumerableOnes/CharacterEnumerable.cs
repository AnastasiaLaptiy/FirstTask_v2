using FirstTask_v2.Enumerators;
using FirstTask_v2.Models;
using System.Collections;

namespace FirstTask_v2.EnumerableOnes
{
    public class CharacterEnumerable:IEnumerable
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new CharacterEnumerator(characterList);

        }
    }
}
