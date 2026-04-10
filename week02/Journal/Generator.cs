public class PromptGenerator
{
    public List<string> _prompts;

    public Random rand = new Random();
    public string RandomPrompt()
    {
         int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
