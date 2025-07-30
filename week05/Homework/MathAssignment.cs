public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(String studentName, string topic, string textbookSection, string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"Student Name: {GetStudentName()} - Topic: {GetTopic()}{Environment.NewLine}Section: {_textbookSection}  Problem: {_problem}";
    }
}