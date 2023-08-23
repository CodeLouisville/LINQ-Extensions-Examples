namespace Interface_Examples.Shape;

public class Square : IShape
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double Area()
    {
        return _side * _side;
    }
}
