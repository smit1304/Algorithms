//!!!NOTE!!!
//each job takes a single unit of time
//so the minimum possible deadline for any job is 1 unit time

class Job
{
    public string jobId;
    public int deadline;
    public int profit;
    public Job(string jobid, int deadline, int profit)
    {
        this.jobId = jobid;
        this.deadline = deadline;
        this.profit = profit;
    }
    public static int sortByProfit(Job a, Job b)
    {
        return b.profit.CompareTo(a.profit);
    }
}
class JobSequencing
{
    public static void _SequenceJobs(List<Job> listOfJobs, Job[] solutionSet, int maxDeadline)
    {
        int scheduleCount = 0;
        foreach (Job j in listOfJobs)
        {
            if (scheduleCount >= maxDeadline)
                break;
            if (solutionSet[j.deadline] == null)
            {
                solutionSet[j.deadline] = j;
                scheduleCount++;
            }
            else
            {
                for (int i = 1; i < j.deadline; i++)
                {
                    if (solutionSet[i] == null)
                    {
                        solutionSet[i] = j;
                        continue;
                    }
                }
            }
        }
    }
    public static int _SearchMaxProfit(List<Job> listofjobs)
    {
        int maxDeadline = Int32.MinValue;

        foreach (Job j in listofjobs)
        {
            if (maxDeadline < j.deadline)
            {
                maxDeadline = j.deadline;
            }
        }
        return maxDeadline;
    }
    public static void Main(string[] args)
    {
        List<Job> listOfJobs = new List<Job>()
        {
            new Job("c",1,40) , new Job("d",1,30),
            new Job("a",4,20),new Job("b",1,10),
        };
        listOfJobs.Sort(Job.sortByProfit);
        int maxDeadline = _SearchMaxProfit(listOfJobs);
        Job[] solutionSet = new Job[maxDeadline + 1];

        //nullifying solutionSet
        for (int i = 0; i < solutionSet.Length; i++)
        {
            //solutionSet[i] = new Job("", 0, 0);
            solutionSet[i] = null;
        }
        _SequenceJobs(listOfJobs, solutionSet, maxDeadline);
        for (int i = 1; i < solutionSet.Length; i++)
        {
            if (solutionSet[i] == null)
                continue;
            Console.WriteLine("Job id : " + solutionSet[i].jobId + " Deadline : " + solutionSet[i].deadline + " Profit : " + solutionSet[i].profit);
        }

    }
}
