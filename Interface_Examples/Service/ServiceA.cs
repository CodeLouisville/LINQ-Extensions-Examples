namespace Interface_Examples.Service;

public class ServiceA : IService
{
    public void DoWork(Job job)
    {
        // ServiceA takes longer to process a square than a circle
        Thread.Sleep(job.Shape is Shape.Square ? 1500 : 200);

        var area = job.Shape.Area();

        Console.WriteLine($"ServiceA: {job.Name} - Area of {job.Shape.GetType().Name} is {area}");
    }
}
