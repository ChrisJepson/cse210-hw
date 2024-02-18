using System;

class Scripture
{
    public Reference Reference;
    public Word[] _words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        _words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new Word(wordArray[i]);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Length / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, _words.Length);
            _words[index].Hide();
        }
    }

    public string CheckIfHidden()
    {
        string visibleText = "";
        foreach (Word word in _words)
        {
            visibleText += (word.IsHidden ? "_____" : word.Text) + " ";
        }
        return visibleText.Trim();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}
