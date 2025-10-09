public class Prompt
{
    public static string RandomPrompt(){
        Random random = new Random();
        List<string> prompts = new List<string> { "What did you do today?",
        "What made you happy today?", "What are you most grateful for?",
        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?" };
        int randomNum = random.Next(4);
        string randomPrompt = prompts[randomNum];
        return randomPrompt;
} 
}

