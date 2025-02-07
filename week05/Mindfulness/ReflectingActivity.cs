class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Queue<string> _unusedPrompts;

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on times when you showed strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself?"
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

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}