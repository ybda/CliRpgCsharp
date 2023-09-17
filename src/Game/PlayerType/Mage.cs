namespace CliRpgCsharp.Game.PlayerType;

public class Mage : Player
{
    public Mage(string name, Race race) : base(name, race, 150, 150)
    {
    }

    public override string AttackString() => "Attack of Mage";
}