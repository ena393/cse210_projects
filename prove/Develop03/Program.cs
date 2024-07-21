using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.HideRandomWords(3))
            {
                scripture.Display();
                Console.WriteLine("All words are hidden. Program will now exit.");
                break;
            }
        }
    }
}