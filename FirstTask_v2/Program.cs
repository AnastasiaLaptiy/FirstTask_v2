using FirstTask_v2.Managers;
using FirstTask_v2.Models;
using System;
using System.Collections;

namespace FirstTask_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            CardModel[] card = new CardModel[3]
            {
                new CardModel(1),
                new CardModel(2),
                new CardModel(3),
            };

            DeckManager deckList = new DeckManager(card);
            foreach (var item in deckList)
            {
                Console.WriteLine(item.Id);
            }

            foreach (var item in deckList)
            {
                item.Id++;
                Console.WriteLine(item.Id);
            }

            card[2].Id++;
            foreach (var item in deckList)
            {
                Console.WriteLine(item.Id);
            }
            Console.ReadKey();
        }
    }
}
