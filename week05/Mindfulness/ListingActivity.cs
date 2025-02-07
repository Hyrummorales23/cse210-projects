class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Queue<string> _unusedPrompts;

    public ListingActivity() : base("Listing Activity", "This activity helps you reflect on good things in your life by listing as many as possible.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        ShufflePrompts();
    }

    private void ShufflePrompts()
    {
        Random rand = new Random();
        _unusedPrompts = new Queue<string>(new List<string>(_prompts.OrderBy(p => rand.Next())));
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
            ShufflePrompts();
        return _unusedPrompts.Dequeue();
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);
        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndingMessage();
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item: ");
            responses.Add(Console.ReadLine());
        }
        return responses;
    }
}