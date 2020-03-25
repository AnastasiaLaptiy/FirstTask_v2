using FirstTask_v2.Models;

namespace FirstTask_v2.Managers
{
    public class CardManager
    {
        public CardModel createCard(int id, string name)
        {
            CardModel card = new CardModel
            {
                Id = id,
                Name = name
            };
            return card;
        }
    }
}
