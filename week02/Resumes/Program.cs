using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        // Created job1 and job2 objects.
        Job job1 = new Job();
        Job job2 = new Job();
        //Created first job information.
        job1._companyName = "Unicon Aluminum Company";
        job1._jobTitle = "Lead Engineer";
        job1._startYear = 2006;
        job1._endYear = 2025;
        //Created second job information.
        job2._companyName = "Unicon Solar Solutions";
        job2._jobTitle = "Lead Engineer";
        job2._startYear = 2022;
        job2._endYear = 2025;
        //created the Resume class object.
        Resume resume = new Resume();
        resume._personalName = "Odumamwen Evans Henry Aisiokuebor";
        resume._job.Add(job1); //Add job1 to the resume _job list.
        resume._job.Add(job2); //Add job2 to the resume _job list.

        resume.DisplayResume();
    }
}