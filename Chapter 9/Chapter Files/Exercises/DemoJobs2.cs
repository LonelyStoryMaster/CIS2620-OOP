using System;
using static System.Console;

class DemoJobs {
    static void Main() {
        string[] jobNames = {"Washing Windows", "Mowing the Lawn", "Walking the Dog", "Exterior Painting", "Interior Painting",
                             "Landscaping", "Weeding", "Raking Leaves", "Feed the fish", "Sweeping", "Watering the Flowers",
                             "Trim the Hedges", "Clean the Garage", "Pick Fruit", "Clean the Pool"};
        Job[] jobs = generateJobs(jobNames, 10, 150, 25);

        WriteLine("Generated Jobs:");
        foreach (Job job in jobs) {
            WriteLine(job);
        }

        WriteLine("\nAdded Jobs:");
        for (int i = 0; i < jobs.Length; i += 2) {
            Job addedJob = jobs[i] + jobs[i+1];
            WriteLine(addedJob);
        }
    }

    static Job[] generateJobs(string[] jobNames, int numJobs, int maxRate, int maxHours) {
        Random rando = new Random();
        Job[] jobs = new Job[numJobs];
        for (int i = 0; i < numJobs; i++) {
            int namePos = rando.Next(0, jobNames.Length);
            string jobName = jobNames[namePos];
            int hourlyRate = rando.Next(1, maxRate);
            int numHours = rando.Next(1, maxHours);
            Job newJob = new Job(jobName, numHours, hourlyRate);
            jobs[i] = newJob;
        }
        return jobs;
    }
}

class Job {
    private string jobDescription;
    private int numHours, pricePerHour, totalCost, pricePerHour2, numHours2;

    public string JobDescription { get { return this.jobDescription; } set { this.jobDescription = value; } }
    public int NumHours { get { return this.numHours; } set { this.numHours = value; this.totalCost = this.TotalCost; } }
    public int PricePerHour { get { return this.pricePerHour; } set { this.pricePerHour = value; this.totalCost = this.TotalCost; } }
    public int NumHours2 { get { return this.numHours2; } set { this.numHours2 = value; this.totalCost = this.TotalCost; } }
    public int PricePerHour2 { get { return this.pricePerHour2; } set { this.pricePerHour2 = value; this.totalCost = this.TotalCost; } }
    public int TotalCost { get { return ((this.PricePerHour * this.NumHours) + (this.PricePerHour2 * this.NumHours2)); } }

    public Job(string description, int numHours, int hourlyPrice, int numHours2 = 0, int hourlyPrice2 = 0) {
        this.JobDescription = description;
        this.NumHours = numHours;
        this.PricePerHour = hourlyPrice;
        this.NumHours2 = numHours2;
        this.PricePerHour2 = hourlyPrice2;
    }

    public override string ToString() {
        return String.Format("{0} at ${1}/hr for {2} hours and ${3}/hr for {4} hours will be ${5}", this.JobDescription, this.PricePerHour,
                             this.NumHours, this.PricePerHour2, this.NumHours2, this.TotalCost);
    }

    public static Job operator+(Job first, Job second) {
        string newDescription = String.Format("{0} and {1}", first.JobDescription, second.JobDescription);
        return (new Job(newDescription, first.NumHours, first.PricePerHour, second.NumHours, second.PricePerHour));
    }
}