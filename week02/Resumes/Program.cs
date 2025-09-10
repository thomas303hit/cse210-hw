using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();
        job1._company = "JustTech";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2021;

        // Create second job
        Job job2 = new Job();
        job2._company = "DocuSoft";
        job2._jobTitle = "Senior Developer";
        job2._startYear = 2021;
        job2._endYear = 2025;

        // Create resume and add jobs
        Resume myResume = new Resume();
        myResume._name = "Lilia Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the complete resume
        myResume.Display();
    }
}