using FirstTask_v2.Managers;
using FirstTask_v2.Models;
using System;

namespace FirstTask_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager cardManager = new CardManager();

            CardModel[] Deck = {
                cardManager.CreateCard(1),
                cardManager.CreateCard(2),
                cardManager.CreateCard(3),
                cardManager.CreateCard(4)
            };

            DeckManager deckList = new DeckManager(Deck);
            foreach (var item in deckList)
            {
                Console.WriteLine(item.Id);
            }

            var enumerator = deckList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Id);
            }

            Console.ReadKey();
        }
    }
}
