using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();


        activities.Add(new Running("14 Apr 2026", 30, 3.0f));
        activities.Add(new Cycling("14 Apr 2026", 45, 12.5f));
        activities.Add(new Swimming("14 Apr 2026", 20, 15));

foreach (Activity a in activities)
{
    Console.WriteLine(a.GetSummary());
}
    }
}