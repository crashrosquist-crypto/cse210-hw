using System;

public class Scripture
{
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordsArray = text.Split(' ');

        foreach (string wordText in wordsArray)
        {
            Word newWord = new Word(wordText);

            _words.Add(newWord);
        }
    }
    private List<Word> _words = new List<Word>();

    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int hiddenCount = 0;

    while (hiddenCount < numberToHide && !IsCompletelyHidden())
    {
        int index = random.Next(_words.Count);

        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
        }
    }
}

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) 
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText += word.GetDisplayText() + " ";
        }

        return $"{referenceText} {verseText}";
    }
}