namespace CliRpgCsharp.Game.PlayerType;

public class Priest : Player
{
    public Priest(string name, Race race) : base(name, race, 100, 200)
    {
    }

    public override string AttackString() => "Attack of Priest";
}