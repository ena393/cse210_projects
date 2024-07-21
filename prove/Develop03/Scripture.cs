public class Scripture
{
    private string _text;
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _text = text;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.ToString()}");
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public bool HideRandomWords(int count)
    {
        var random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden).OrderBy(x => random.Next()).Take(count).ToList();

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }

        return _words.All(word => word.IsHidden);
    }
}