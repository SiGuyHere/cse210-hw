public class Assassin : Champion
{
    public static List<Assassin> AllAssassins { get; private set; } = new List<Assassin>();
    public Assassin(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllAssassins.Add(this);
    }
    public override double getWeight()
    {
        return 0.95;
    }
}