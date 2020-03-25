using FirstTask_v2.Models;

namespace FirstTask_v2.Managers
{
    public class CharacterManager
    {
        public CharacterModel CreateCharacter(int id, string name, string ability)
        {
            CharacterModel character = new CharacterModel
            {
                Id = id,
                Name = name,
                Ability = ability
            };
            return character;
        }
    }
}
