public class DraftAdvisor
{
    public List<Champion> TeamPicks { get; set; } = new List<Champion>();
    public List<Champion> EnemyPicks { get; set; } = new List<Champion>();

    public DraftAdvisor() { }

    public List<Champion> SuggestTopChampions(string lane)
    {
        List<Champion> availableChamps = new List<Champion>();

        for (int i = 0; i < Champion.all.Count; i++)
        {
            Champion champ = Champion.all[i];
            if (champ.Lane.ToLower() != lane.ToLower())
            {
                continue;
            }

            bool alreadyPicked = false;
            for (int j = 0; j < TeamPicks.Count; j++)
            {
                if (TeamPicks[j] == champ)
                {
                    alreadyPicked = true;
                    break;
                }
            }
            for (int j = 0; j < EnemyPicks.Count; j++)
            {
                if (EnemyPicks[j] == champ)
                {
                    alreadyPicked = true;
                    break;
                }
            }
            if (alreadyPicked)
                continue;

            champ.TempScore = CalculateScore(champ); 
            availableChamps.Add(champ);
        }

        for (int i = 1; i < availableChamps.Count; i++)
        {
            Champion key = availableChamps[i];
            int j = i - 1;
            while (j >= 0 && availableChamps[j].TempScore < key.TempScore)
            {
                availableChamps[j + 1] = availableChamps[j];
                j--;
            }
            availableChamps[j + 1] = key;
        }

        List<Champion> top5 = new List<Champion>();
        for (int i = 0; i < availableChamps.Count && i < 5; i++)
        {
            top5.Add(availableChamps[i]);
        }

        return top5;
    }

    private double CalculateScore(Champion champ)
    {
        double score = champ.WinRate;

        for (int i = 0; i < EnemyPicks.Count; i++)
        {
            Champion enemy = EnemyPicks[i];
            for (int j = 0; j < enemy.Counters.Count; j++)
            {
                if (enemy.Counters[j] == champ.Name)
                {
                    score -= 3.0;
                    break;
                }
            }
        }


        for (int i = 0; i < EnemyPicks.Count; i++)
        {
            Champion enemy = EnemyPicks[i];
            for (int j = 0; j < champ.Counters.Count; j++)
            {
                if (champ.Counters[j] == enemy.Name)
                {
                    score += 3.0;
                    break;
                }
            }
        }


        for (int i = 0; i < TeamPicks.Count; i++)
        {
            if (TeamPicks[i].GetType() == champ.GetType())
            {
                score -= 2.0;
                break;
            }
        }

        double adCount = 0, apCount = 0;
        for (int i = 0; i < TeamPicks.Count; i++)
        {
            double weight = TeamPicks[i].getWeight();
            if (TeamPicks[i].DmgType == "Attack") adCount += weight;
            if (TeamPicks[i].DmgType == "Ability") apCount += weight;
        }
        double champWeight = champ.getWeight();
        if (champ.DmgType == "Attack") adCount += champWeight;
        if (champ.DmgType == "Ability") apCount += champWeight;

        double diff = Math.Abs(adCount - apCount);
        score -= diff*2;

        return score;
    }
}