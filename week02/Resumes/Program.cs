using System;
using System.Collections.Generic;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Inventory Control Coordinator";
        job1._company = "DHL Logistics";
        job1._startYear = 2022;
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._jobTitle = "Inventory Control Supervisor";
        job2._company = "Trillium2 Supply Chain";
        job2._startYear = 2024;
        job2._endYear = "Present";

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        
    }
}