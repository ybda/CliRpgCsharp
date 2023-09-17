namespace CliRpgCsharp.Game;

public enum Race
{
    Human, Elf, Dwarf, Orc, Troll
}

public abstract class Player
{
    public string Name { get; set; }
    public Race Race { get; set; }
    public int Hp { get; set; }
    public int Mana { get; set; }

    protected Player(string name, Race race, int hp, int mana)
    {
        Name = name;
        Race = race;
        Hp = hp;
        Mana = mana;
    }

    public abstract string AttackString();
}