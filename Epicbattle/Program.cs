using System;
using System.IO;
namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples\";
            string[] heroes = GetDataFromFile(rootPath + "heroes.txt");
            string[] villians = GetDataFromFile(rootPath + "villains.txt");
            string[] weapon = GetDataFromFile(rootPath + "Weapon.txt");
            string[] armor = GetDataFromFile(rootPath + "armor.txt");
            //string[] heroes = { "Travis Scotch", "Scooby-Doo", "Sponge Bob", "Patrick" };
            //string[] villians = { "Plankton", "Hitler", "Nigga from Ghetto", "Mall Security", "That guy" };

            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villians);
            string randomHeroWeapon = GetWeapon(weapon);
            string randomVillainWeapon = GetWeapon(weapon);
            string heroArmor = GetRandomElement(armor);
            string villainArmor = GetRandomElement(armor);
            string heroHP = GenerateHP(heroArmor);
            string villain = GenerateHP(villainArmor);

            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random hero weapon is {randomHeroWeapon}");
            Console.WriteLine($"Your random hero armor is{heroArmor}");
            Console.WriteLine($"Your random villian is {randomVillain}");
            Console.WriteLine($"Your random  villian weapon is {randomVillainWeapon}");
            Console.WriteLine($"Your random villain armor is{villainArmor}");

        }

        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndex(someArray)];
        }

        public static string GetWeapon(string[] someArray)
        {
            return someArray[GetRandomIndex(someArray)];
        }

        public static int GetRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }

        public static string[] GetDataFromFile(string filePath)
        {
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
        public static int GenerateHP(string armor)
        {
            return armor.Length;


        }
    }
}