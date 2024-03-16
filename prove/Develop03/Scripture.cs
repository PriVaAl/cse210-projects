using System;
using System.Linq;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
   
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        //List<Word> visibleW = _words.FindAll( word => ! word.IsHidden());
        //int wordsToHide = Math.Min(numberToHide, visibleW.Count);
        int wordsToHide = random.Next(1, numberToHide + 1);
        List<Word> visibleW = _words.Where( word => !word.IsHidden()).ToList();
        
        for (int i = 0; i < wordsToHide && visibleW.Any(); i++)
        {
            int index = random.Next(visibleW.Count);
            visibleW[index].Hide();
            visibleW.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        List<string> displayW = new List<string>();
        foreach (Word word in _words)
        {
            displayW.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayW);
    }

    public bool IsCompletelyHidden()
    {
    
        return _words.All(word => word.IsHidden());
    }
}