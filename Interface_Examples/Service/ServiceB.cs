namespace Interface_Examples.Service;

public class ServiceB : IService
{
    public void DoWork(Job job)
    {
        // ServiceB takes longer to process a circle than a square
        Thread.Sleep(job.Shape is Shape.Circle ? 1000 : 500);

        var area = job.Shape.Area();

        Console.WriteLine($"ServiceB: {job.Name} - Area of {job.Shape.GetType().Name} is {area}");
    }
}
