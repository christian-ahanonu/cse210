using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    // scripture constructor
    public Scripture(string refer, string text)
    {
        _reference = new Reference(refer);

        _words = new List<Word>();

        string[] textArray = text.Split(' ');
        foreach (string w in textArray)
        {
            _words.Add(new Word(w)); // add the splitted scripture text to the _words list
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<int> _nonHiddenIndices = new List<int>();

        // Collect indices of words that are not hidden
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                _nonHiddenIndices.Add(i);
            }
        }
        
        // Shuffle the non-hidden indices list to ensure randomness
        for (int i = 0; i < _nonHiddenIndices.Count; i++)
        {
            int j = rand.Next(i, _nonHiddenIndices.Count);
            int temp = _nonHiddenIndices[i];
            _nonHiddenIndices[i] = _nonHiddenIndices[j];
            _nonHiddenIndices[j] = temp;
        }

        // Hide words based on the shuffled list of non-hidden indices
        for (int i = 0; i < numberToHide && i < _nonHiddenIndices.Count; i++)
        {
            _words[_nonHiddenIndices[i]].Hide(); // randomly selects a word and hide it
        }
    }

    // display the scripture reference
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n"; 

        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        // loop through the _words list and check if each word is hidden completely or not
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}