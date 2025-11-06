using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine($"Which activity would you like to do?\n1.Breathing\n2.Reflection\n3.Listing\n4.Show Log\n5.Quit");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                BreathingActivity breathe = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                breathe.Breather();
                Activity.LogBreathingActivity(breathe);
            }
            else if (userChoice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflect.Reflect();
                Activity.LogReflectionActivity(reflect);
            }
            else if (userChoice == "3")
            {
                ListingActivity list = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                list.Listing();
                Activity.LogListingActivity(list);
            }
            else if (userChoice == "4")
            {
                Activity.DisplayLog();
            }
            else if (userChoice == "5")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}