namespace Interface_Examples.Shape;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area()
    {
        return Math.PI * _radius * _radius;
    }
}
