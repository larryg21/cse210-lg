// Job.cs
using System;


public class Job
    {
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear;
        public string _endYear = "";

        // Method to present the job's information.
        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }



