using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Implementations;

public class Triangle : IShape
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public double GetArea()
    {
        double s = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }

    public bool IsRightAngled()
    {
        double[] sidesSquared = { _side1 * _side1, _side2 * _side2, _side3 * _side3 };
        return sidesSquared.Any(side => sidesSquared.Sum() - side == side);
    }
}