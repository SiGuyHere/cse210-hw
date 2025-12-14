public class Mage : Champion
{
    public static List<Mage> AllMages { get; private set; } = new List<Mage>();
    public Mage(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllMages.Add(this);
    }
    public override double getWeight()
    {
        return 1.1;
    }
}