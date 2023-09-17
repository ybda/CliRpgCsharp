namespace CliRpgCsharp.Game.PlayerType;

public class Warrior : Player
{
    public Warrior(string name, Race race) : base(name, race, 200, 0)
    {
    }

    public override string AttackString() => "Attack of Warrior";
}