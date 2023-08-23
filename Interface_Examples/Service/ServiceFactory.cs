using Interface_Examples.Shape;

namespace Interface_Examples.Service;

public static class ServiceFactory
{
    public static IService GetBestService(List<Job> jobs)
    {
        var shapeCounter = new Dictionary<string, int>();

        foreach (var job in jobs)
        {
            if (job.Shape is Circle)
            {
                if (shapeCounter.ContainsKey("circle"))
                {
                    shapeCounter["circle"]++;
                }
                else
                {
                    shapeCounter["circle"] = 1;
                }
            }
            else if (job.Shape is Square)
            {
                if (shapeCounter.ContainsKey("square"))
                {
                    shapeCounter["square"]++;
                }
                else
                {
                    shapeCounter["square"] = 1;
                }
            }
            else
            {
                throw new Exception($"We don't know how to process this shape: {job.Shape.GetType().Name}");
            }
        }

        var most = new KeyValuePair<string, int>("none", 0);
        foreach (var kvp in shapeCounter)
        {
            if (kvp.Value > most.Value)
            {
                most = kvp;
            }
        }

        if (most.Key == "circle")
        {
            return new ServiceA();
        }
        else if (most.Key == "square")
        {
            return new ServiceB();
        }
        else
        {
            throw new Exception($"We don't know how to process this shape: {most.Key}");
        }
    }
}
