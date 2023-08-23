using Interface_Examples.Shape;

namespace Interface_Examples;

public class Job
{
    public string Name { get; }
    public IShape Shape { get; }

    public Job(string name, IShape shape)
    {
        Name = name;
        Shape = shape;
    }
}
