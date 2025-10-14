using System;
using System.Text.Json;
public class Journal
{
    private static List<string> privEntryList = new List<string>();
    private static List<string> entryList
    {
        get { return privEntryList; }
        set { privEntryList = value; }
    }
    public static void DisplayEntries()
    {
        for(int i = 0; i < entryList.Count;i++)
            {
                Console.WriteLine($"{entryList[i]}\n");
            }
    }
    public static void AddEntry(string entry)
    {
        entryList.Add(entry);
    }
    public static void SaveFile(string fileName)
    {
        string jsonString = JsonSerializer.Serialize(entryList, new JsonSerializerOptions { WriteIndented = true }); 
        File.WriteAllText(fileName, jsonString);
    }
    public static void LoadFile(string fileName)
    {
        try
        {
            string file = File.ReadAllText(fileName);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{fileName}' was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
        string fileContent = File.ReadAllText(fileName);
        entryList = JsonSerializer.Deserialize<List<string>>(fileContent);
    } 
}