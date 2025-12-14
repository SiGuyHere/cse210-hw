public class Support : Champion
{
    public static List<Support> AllSupports { get; private set; } = new List<Support>();
    public Support(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllSupports.Add(this);
    }
    public override double getWeight()
    {
        return 0.6;
    }
}