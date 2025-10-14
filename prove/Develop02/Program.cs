using System;
class Program
{
    //I first saved the file as a normal text file, but switched to JSON for the stretch
    //and the JSON file is so much easier to manage. I removed like 10 lines of code for it LOL.
    static void Main(string[] args)
    {
        bool run = true;
        while (run == true)
        {
            Console.WriteLine("1.Write\n2.Display\n3.Save\n4.Load\n5.Quit");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                string prompt = Prompt.RandomPrompt();
                Console.WriteLine($"{prompt}\n>");
                string userInput = Console.ReadLine();
                Entry.CreateEntry(userInput, prompt);
                Journal.AddEntry(Entry.entry);

            } else if (userChoice == "2"){
                Journal.DisplayEntries();
            } else if (userChoice == "3")
            {
                Console.WriteLine("What do you want your file name to be?");
                string fileName = Console.ReadLine();
                Journal.SaveFile(fileName);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is your file name?");
                string fileName = Console.ReadLine();
                Journal.LoadFile(fileName);
            } else if (userChoice == "5")
            {
                run = false;
            } else
            {
                Console.WriteLine("Not a valid choice");
            }
        }

    }
}