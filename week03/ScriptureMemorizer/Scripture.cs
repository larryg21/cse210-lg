using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        Random rnd = new Random();
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden()) visibleIndexes.Add(i);
        
        }
        

        for (int i = 0; i < count && visibleIndexes.Count > 0; i++)
        {
            int index = rnd.Next(visibleIndexes.Count);
            _words[visibleIndexes[index]].Hide();
            visibleIndexes.RemoveAt(index);
        }

    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsFullyHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}