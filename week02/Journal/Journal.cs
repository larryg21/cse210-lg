using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()

    {
        foreach (Entry entry in _entries)

        {
            Console.WriteLine(entry);
        }

    }

    public void SaveToFile(string filename)

    {
        using (StreamWriter _writer = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)
            {
                _writer.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)

        {
            _entries.Add(Entry.FromFileString(line));
        }
    }

}

 