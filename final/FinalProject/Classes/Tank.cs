public class Tank : Champion
{
    public static List<Tank> AllTanks { get; private set; } = new List<Tank>();
    public Tank(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllTanks.Add(this);
    }
    public override double getWeight()
    {
        return 0.5;
    }
}