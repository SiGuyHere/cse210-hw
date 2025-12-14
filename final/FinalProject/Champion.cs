public abstract class Champion
{
    public string Name { get; set; }
    public string Lane { get; set; }
    public double WinRate { get; set; }
    public string DmgType { get; set; }
    public double Weight = 1.0;
    public double TempScore= 0;
    public List<string> Counters { get; set; } = new List<string>();
    public static List<Champion> all = new List<Champion>();

    public Champion(string name, string lane, string dmgtype, double winrate)
    {
        Name = name;
        Lane = lane;
        WinRate = winrate;
        DmgType = dmgtype;
        // w3 schools how to add to list on initialization
        all.Add(this);
    }

    public void ShowCounters()
    {
        Console.WriteLine($"Counters to {Name}: {string.Join(", ", Counters)}");
    }

    public override string ToString()
    {
        return $"{Name} ({Lane})";
    }
    public virtual double getWeight()
    {
        return 1.0;
    }
    public static Champion FindChampionByName(string name)
    {
        foreach (Champion c in all)
        {
            if (c.Name.ToLower() == name.ToLower())
                return c;
        }

        return null;
    }
}
