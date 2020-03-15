using FirstTask_v2.Models;

namespace FirstTask_v2.Managers
{
    public class CardManager 
    {
        public CardModel CreateCard(int id)
        {
            CardModel card = new CardModel()
            {
                Id = id
            };
            return card;
        }
    }
}
