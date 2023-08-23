using System.Diagnostics;
using Interface_Examples;
using Interface_Examples.Service;
using Interface_Examples.Shape;

// change this to false to test ServiceFactory
var testDifferentServices = true;

if (testDifferentServices)
{
    var circleJob = new Job(
        name: "CircleJob",
        shape: new Circle(radius: 1D));

    var squareJob = new Job(
        name: "SquareJob",
        shape: new Square(side: 5D));

    Console.WriteLine("\nUsing ServiceA");

    var jobExecutor = new JobExecutor(service: new ServiceA());

    jobExecutor.Execute(circleJob, timeExecution: true);
    jobExecutor.Execute(squareJob, timeExecution: true);

    Console.WriteLine("Changing service to ServiceB");

    jobExecutor.Service = new ServiceB();

    jobExecutor.Execute(circleJob, timeExecution: true);
    jobExecutor.Execute(squareJob, timeExecution: true);
}
else
{
    var jobs = new List<Job>
    {
        new Job(
            name: "CircleJob",
            shape: new Circle(radius: 1D)),
        new Job(
            name: "CircleJob",
            shape: new Circle(radius: 1D)),
        new Job(
            name: "SquareJob",
            shape: new Square(side: 5D)),
        new Job(
            name: "SquareJob",
            shape: new Square(side: 5D)),
        new Job(
            name: "SquareJob",
            shape: new Square(side: 5D))
    };

    var bestService = ServiceFactory.GetBestService(jobs);
    var jobExecutor = new JobExecutor(service: bestService);

    var stopwatch = Stopwatch.StartNew();

    foreach (var job in jobs)
    {
        jobExecutor.Execute(job, timeExecution: false);
    }

    Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds} ms\n");
}

