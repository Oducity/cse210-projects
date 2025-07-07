public class Resume
{
    public string _personalName;
    public List<Job> _job = new List<Job>();

    public Resume()
    {

    }

    public void DisplayResume()
    {
        Console.WriteLine($"{_personalName}");
        Console.WriteLine("Jobs Experience:");
        foreach (Job j in _job)
        {
            Console.WriteLine($"Company: {j._companyName}, Job Title: {j._jobTitle}, Start-Year: {j._startYear} - End-Year: {j._endYear}");
        }
    }
}