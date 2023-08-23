using System.Diagnostics;
using Interface_Examples.Service;

namespace Interface_Examples;

public class JobExecutor
{
    public IService Service { get; set; }

    public JobExecutor(IService service)
    {
        Service = service;
    }

    public void Execute(Job job, bool timeExecution)
    {
        var stopwatch = Stopwatch.StartNew();
        Service.DoWork(job);
        if (timeExecution)
        {
            Console.WriteLine("Execution time: " + stopwatch.ElapsedMilliseconds + "ms\n");
        }
    }
}
