namespace quiz.Entity;


public class Question
{
    public string QuestionText { get; set; }
    public Dictionary<string, bool> Answers { get; set; }

    public Question(string questionText, Dictionary<string, bool> answers)
    {
        QuestionText = questionText;
        Answers = answers;
    }
}

