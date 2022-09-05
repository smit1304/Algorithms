using System.Collections;
class Activity
{
    public int startTime;
    public int endTime;
    public Activity(int startTime, int endTime)
    {
        this.startTime = startTime;
        this.endTime = endTime;
    }
}
class ActivtySelectionProblem
{
    public static int cmpbyendtime(Activity a1, Activity a2)
    {
        return a1.endTime.CompareTo(a2.endTime);
    }
    public static void Main(string[] args)
    {
        List<Activity> solution = new List<Activity>();
        List<Activity> activities = new List<Activity>(){
            new Activity(1,2),new Activity(1,3),new Activity(1,4),new Activity(2,5),
            new Activity(3,7),new Activity(4,9),new Activity(5,6),new Activity(6,8),
            new Activity(7,9)
        };
        //sort this list of activities by finish time 
        activities.Sort(cmpbyendtime);
        /*pick activities one by one check if their stat time is greater or equal to end time 
        of the previous activity if it is then push that activity to solution list.
        */
        foreach (Activity i in activities)
        {
            //while solution set is empty add first activity
            if (solution.Count == 0)
            {
                solution.Add(i);
                continue;
            }
            if (solution[(solution.Count - 1)].endTime <= i.startTime)
            {
                //add to solution set
                solution.Add((Activity)i);
            }
        }
        Console.WriteLine("Total number of activity scheduled : " + solution.Count);
        foreach (Activity i in solution)
        {
            Console.WriteLine("Start time : " + i.startTime + " End time : " + i.endTime);
        }
    }
}
