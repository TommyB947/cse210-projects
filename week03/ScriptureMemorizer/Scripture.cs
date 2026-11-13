using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();



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
        int num = _words.Count() + 1;

        for (int i = 1; i < numberToHide; i++)
        {
            int randomNumber = Random.Shared.Next(1, num) - 1;
            _words[randomNumber].Hide();
        }

        if (IsCompletlyHidden() == true)
            {
                for (int i = 0; i < _words.Count; i++)
                {
                    _words[i].Show();
                }
            }
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

    private bool IsCompletlyHidden()
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