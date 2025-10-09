using System;
class Program
{
    //I first saved the file as a normal text file, but switched to JSON for the stretch
    //and the JSON file is so much easier to manage. I removed like 10 lines of code for it LOL.
    static void Main(string[] args)
    {
        bool run = true;
        List<string> entryList = new List<string>();
        while (run == true)
        {
            Console.WriteLine("1.Write\n2.Display\n3.Save\n4.Load\n5.Quit");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                string prompt = Prompt.RandomPrompt();
                Console.WriteLine($"{prompt}\n>");
                string userInput = Console.ReadLine();
                string entry = Journal.CreateEntry(userInput, prompt);
                entryList.Add(entry);

            } else if (userChoice == "2"){
                for(int i = 0; i < entryList.Count;i++)
                {
                    Console.WriteLine($"{entryList[i]}\n");
                }
            } else if (userChoice == "3")
            {
                Console.WriteLine("What do you want your file name to be?");
                string fileName = Console.ReadLine();
                FileEditing.SaveFile(fileName, entryList);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("What is your file name?");
                string fileName = Console.ReadLine();
                entryList = FileEditing.LoadFile(fileName);
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