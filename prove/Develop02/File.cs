using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
public class FileEditing
{
    public static void SaveFile(string fileName, List<string> content)
    {
        string jsonString = JsonSerializer.Serialize(content, new JsonSerializerOptions { WriteIndented = true }); 
        File.WriteAllText(fileName, jsonString);
    }
    public static List<string> LoadFile(string fileName)
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
        List<string> words = JsonSerializer.Deserialize<List<string>>(fileContent);
        return words;
    }
}