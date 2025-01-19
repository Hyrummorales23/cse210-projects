public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a memorable moment from your day.",
        "What is one thing you learned today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}