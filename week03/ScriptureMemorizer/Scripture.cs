using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string _reference;
    public List<Word> _words = new List<Word>();



    public Scripture(Reference Reference, string text)
    {
        _reference = Reference.GetDisplayText();
        
        string[] d = {" "};

        string[] words = text.Split(d, StringSplitOptions.RemoveEmptyEntries);

        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }



    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        string text = "";
        for (int i = 0; i < _words.Count; i++)
        {
            text = text + " " +_words[i].GetDisplayText();
        }
        return text;
    }

    public bool IsCompletlyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}