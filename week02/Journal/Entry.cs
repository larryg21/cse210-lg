public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    public override string ToString()
    {
        return $" Date: {_date}\n Prompt: {_promptText}\n Answer: {_entryText}\n";
    }

    public string ToFileString()

    {

        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)

    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);

    }
    

}