using CliRpgCsharp.Game;
using CliRpgCsharp.Game.PlayerType;

namespace CliRpgCsharp;

internal class Program
{
    private static void Main()
    {
        PrintMainMenu();
        var typeNum = Convert.ToInt32(Console.ReadLine());
        
        var players = new List<Player>();
        while (typeNum != 0)
        {
            Console.Write("\nWhat would you like to name your character?\n-> ");
            string name = Console.ReadLine()!;

            PrintRaceMenu();
            int raceNum = Convert.ToInt32(Console.ReadLine());
            
            players.Add(CreatePlayer(name, typeNum, raceNum));
            
            PrintMainMenu();
            typeNum = Convert.ToInt32(Console.ReadLine());
        }

        PrintAllPlayers(players);
    }

    static void PrintMainMenu()
    {
        Console.Write("\nWhich of the following would you like?\n" +
                      "\t1 - Create a Warrior\n" +
                      "\t2 - Create a Priest\n" +
                      "\t3 - Create a Mage\n" +
                      "\t0 - Finish creating player characters\n" +
                      "-> ");
    }

    static void PrintRaceMenu()
    {
        Console.Write("\nNow, which race do you want?\n" +
                      "\t1 - Human\n" +
                      "\t2 - Elf\n" +
                      "\t3 - Dwarf\n" +
                      "\t4 - Orc\n" +
                      "\t5 - Troll\n" +
                      "-> ");
    }

    static Player CreatePlayer(string name, int typeNum, int raceNum)
    {
        Race race = RaceByNum(raceNum);
        return typeNum switch
        {
            1 => new Warrior(name, race),
            2 => new Priest(name, race),
            _ => new Mage(name, race)
        };
    }

    static Race RaceByNum(int raceNum)
    {
        return raceNum switch
        {
            1 => Race.Human,
            2 => Race.Elf,
            3 => Race.Dwarf,
            4 => Race.Orc,
            5 => Race.Troll,
            _ => Race.Human
        };
    }

    static void PrintAllPlayers(List<Player> players)
    {
        Console.WriteLine("\nPLAYER LIST:");
        foreach (var p in players)
        {
            string name = "NAME: " + p.Name;
            string race = "RACE: " + p.Race;
            string attack = "ATTACK: " + p.AttackString();
            
            Console.WriteLine("{0,-20}{1,-18}{2}", name, race, attack);
        }
    }
}