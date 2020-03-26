using FirstTask_v2.EnumerableOnes;
using FirstTask_v2.Managers;
using FirstTask_v2.Models;
using System;

namespace FirstTask_v2
{
    public class Program
    {
        static void Main(string[] args)
        {           
            FlowerModel flower = new FlowerModel();
            foreach (var item in flower.FlowerList)
            {
                Console.WriteLine(item);
            }

            CharacterManager characterManager = new CharacterManager();

            CharacterModel[] charactersList =
            {
                 characterManager.CreateCharacter(1, "Hisoka", "Bungee Gum"),
                 characterManager.CreateCharacter(2, "Gon", "Jajanken"),
                 characterManager.CreateCharacter(3, "Killua", "Thunderbolt")
            };

            CharacterEnumerable character = new CharacterEnumerable(charactersList);
            foreach (CharacterModel item in character.GetCharacterEnumerator())
            {
                Console.WriteLine($"{item.Name},{item.Ability}");
            }

            CardManager cardManager = new CardManager();
            CardModel[] deck =
            {
                cardManager.createCard(1,"Moonfire"),
                cardManager.createCard(2,"Flamestrike"),
                cardManager.createCard(3,"Fireball")
            };

            CardEnumerable card = new CardEnumerable(deck);

            foreach (CardModel item in card)
            {
                Console.WriteLine($"{item.Id}, {item.Name}");

            }

            foreach (CardModel item in deck)
            {
                if (item.Id == 1) item.Id++;
                Console.WriteLine(item.Id);
            }

            foreach (CardModel item in deck)
            {
                if (item.Id == 2) item.Id++;
                Console.WriteLine(item.Id);
            }
            
            CardModel[] deckList =
            {
                cardManager.createCard(1,"Frostbolt"),
                cardManager.createCard(2,"Frostnova"),
                cardManager.createCard(3,"Ice Block")
            };

            CardEnumerable cardList = new CardEnumerable(deckList);

            var iterator = cardList.GetEnumerator();
            while (iterator.MoveNext())
            {
                CardModel cardIter = iterator.Current as CardModel;
                Console.WriteLine($"{cardIter.Id},{cardIter.Name}");
            }

            iterator.Reset();

            while (iterator.MoveNext())
            {
                CardModel cardIter = iterator.Current as CardModel;
                Console.WriteLine($"{cardIter.Id},{cardIter.Name}");
            }

            Console.ReadKey();
        }
    }
}
