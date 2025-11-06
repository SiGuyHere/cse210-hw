class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description,int time) : base(name, description,time)
    {
    }
    public void Breather()
    {
        DisplayStart();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());
        //stole datetime idea from explanation of assignment
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine($"\nBreathe In...   ");
            DisplayCountdown(6);
            Console.WriteLine($"\nBreathe Out...   ");
            DisplayCountdown(6);
        }
        DisplayEnd();
    }
}