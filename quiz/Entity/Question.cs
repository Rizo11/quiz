namespace quiz.Entity;


public class Question
{
    public string QuestionText { get; set; }
    public Dictionary<string, bool> Answers { get; set; }

    public Question(string questionText="What is your name", Dictionary<string, bool> answers = null)
    {
        QuestionText = questionText;
        Answers = answers ?? new Dictionary<string, bool>()
        {
            { "Answer 1", true },
            { "Answer 2", false },
            { "Answer 3", false },
            { "Answer 4", false }
        };
    }
}

