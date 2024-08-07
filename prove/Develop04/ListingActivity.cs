public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3);

        Console.WriteLine("Start listing items:");
        int elapsed = 0;
        int count = 0;
        while (elapsed < Duration)
        {
            Console.ReadLine();
            count++;
            elapsed += 5;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}