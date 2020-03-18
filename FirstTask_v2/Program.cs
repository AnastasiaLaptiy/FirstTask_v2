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
            CardManager card = new CardManager();
            DeckManager deck = new DeckManager();

            deck.createDeck(card.CreateCard(1));
            deck.createDeck(card.CreateCard(2));
            deck.createDeck(card.CreateCard(3));
  
            IEnumerator enumerator = deck.GetEnumerator();

            while (enumerator.MoveNext())
            {
                CardModel cardModel = enumerator.Current as CardModel;
                Console.WriteLine(cardModel.Id);
            }

            Console.ReadKey();
        }
    }
}
