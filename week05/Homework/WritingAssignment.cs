public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Student Name: {GetStudentName()} - Topic: {GetTopic()}{Environment.NewLine}{_title} by {GetStudentName()}";
    }
}