public class Marksman : Champion
{
    public static List<Marksman> AllMarksmen { get; private set; } = new List<Marksman>();
    public Marksman(string name, string role, string dmgtype, double winrate) : base(name, role, dmgtype, winrate)
    {
        AllMarksmen.Add(this);
    }
    public override double getWeight()
    {
        return 1.1;
    }
}