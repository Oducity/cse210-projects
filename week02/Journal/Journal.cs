using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Journal
{

    List<Entry> _entry = new List<Entry>();

    public Journal()
    {

    }

    //Created AddEntry() method.
    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);
    }

    //Created DisplayAll() method.
    public void DisplayAll()
    {
        foreach (Entry n in _entry) // loop through the Entry list and display them to the console.
        {
            Console.WriteLine($"Prompt Question: {n._promptText}, Response: {n._entryText}, Date: {n._date}");
        }
    }

    // Created SaveToFile() method.
    public void SaveToFile(string fileName)
    {

        using (StreamWriter writer = new StreamWriter(fileName)) // called the default streamWriter() class in C# library and assign it to a variable, writer.
        {
            foreach (Entry n in _entry)
            {
                string allItems;
                allItems = $"Prompt Question: {n._promptText}, Response: {n._entryText}, Date: {n._date}";
                writer.WriteLine(allItems);
            }
        }
    }

    //Created LoadFromFile() method
    public void LoadFromFile(string fileName)
    {
        string readText = File.ReadAllText(fileName); //Called the default File.ReadAllText() in C# and assign it a variable, readText.
        Console.WriteLine(readText); // Read all text to the console.
    }
}