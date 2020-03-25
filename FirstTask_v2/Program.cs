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

            foreach (var item in charactersList)
            {
                Console.WriteLine($"{item.Name},{item.Ability}");
            }
            Console.ReadKey();
        }
    }
}
