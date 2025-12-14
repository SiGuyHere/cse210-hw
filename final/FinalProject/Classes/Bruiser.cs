public class Bruiser : Champion
{
    public static List<Bruiser> AllBruisers { get; private set; } = new List<Bruiser>();
    public Bruiser(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllBruisers.Add(this);
    }
    public override double getWeight()
    {
        return 0.9;
    }
}