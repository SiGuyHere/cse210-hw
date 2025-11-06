class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _answers;
    public ListingActivity(string name, string description, int time) : base(name, description, time)
    {
        _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
        _answers = [];
    }

    public void Listing()
    {
        DisplayStart();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());
        RandomPrompt(_prompts);
        Console.WriteLine("Get ready to list");
        DisplayCountdown(5);
        _answers = [];
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("");
            string answer = Console.ReadLine();
            _answers.Add(answer);
        }
        Console.WriteLine($"You listed {_answers.Count()} things.");
        DisplayEnd();
    }
}