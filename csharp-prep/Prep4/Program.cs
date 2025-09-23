using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberInput = -1;
        while (numberInput != 0)
        {
            Console.WriteLine("Enter a number to add to the list (0 to stop):");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }
        List<int> noNegNumbers = numbers.ToList();
        noNegNumbers.RemoveAll(n => n < 0);
        Console.WriteLine($"The smallest non-negative number you entered is: {noNegNumbers.Min()}");
        Console.WriteLine($"The sum of the number you entered is: {numbers.Sum()}");
        Console.WriteLine($"The average of the numbers you entered is: {numbers.Sum() / numbers.Count()}");
        Console.WriteLine($"The largest number you entered is: {numbers.Max()}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}