using System.Runtime.InteropServices;

class Activity
{
    private static string _introMessage;
    private static string _endMessage;
    private int _time;
    private string _name;
    private string _description;
    private static List<BreathingActivity> breathingActivities = [];
    private static List<ReflectionActivity> reflectionActivities = [];
    private static List<ListingActivity> listingActivities = [];
    public Activity(string name, string description, int time)
    {
        _introMessage = "Welcome to";
        _endMessage = $"\n\nGood job!!";
        _time = time;
        _name = name;
        _description = description;
    }
    public static void LogBreathingActivity(BreathingActivity thing)
    {
        breathingActivities.Add(thing);
    }
    public static void LogReflectionActivity(ReflectionActivity thing)
    {
        reflectionActivities.Add(thing);
    }
    public static void LogListingActivity(ListingActivity thing)
    {
        listingActivities.Add(thing);
    }
    public static void DisplayLog()
    {
        Console.WriteLine($"\n\nYou have done {breathingActivities.Count()} breathing activities.");
        Console.WriteLine($"You have done {reflectionActivities.Count()} reflection activities.");
        Console.WriteLine($"You have done {listingActivities.Count()} listing activities.\n\n");
        Thread.Sleep(2000);
    }
    public void DisplayStart()
    {
        Console.WriteLine($"{_introMessage} {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity (in seconds)? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to start... ");
        Thread.Sleep(5000);
    }
    public void DisplayEnd()
    {
        Console.WriteLine($"{_endMessage}");
        Thread.Sleep(3000);
        Console.WriteLine($"You did the {_name} activity for {_time} seconds");
        Thread.Sleep(6000);
    }
    protected int GetTime()
    {
        return _time;
    }
    public static void DisplayCountdown(int time)
    {
        for (int i = 1; i < time + 1; i++)
        {
            //stole the \r thing from w3schools
            Console.Write($"\r{time - i}...   ");
            Thread.Sleep(1000);
        }
    }
    public static void DisplaySpinner(int time)
    {
        for (int i = 0; i < time; i++)
        {
            //stole the explanation in canvas
            Console.Write("+");

            Thread.Sleep(1000);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public static void RandomPrompt(List<string> list)
    {
        Random random = new Random();
        int thing = random.Next(list.Count());
        Console.WriteLine(list[random.Next(list.Count())]);
    }
    public void RandomPromptContinue(List<string> list)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetTime());
        Random random = new Random();
        List<string> savedList = list;
        while (DateTime.Now < futureTime)
        {
            if (list.Count == 0)
            {
                list = savedList;
            }
            int thing = random.Next(list.Count());
            list.Remove(list[thing]);
            Console.WriteLine(list[random.Next(list.Count())]);
            DisplaySpinner(5);
        }
        
    }
}