using ShapeLibrary.Implementations;

namespace ShapeLibraryTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CircleAreaCalculation()
    {
        // Arrange
        double radius = 5;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI * radius * radius;

        // Act
        double actualArea = circle.GetArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    [Test]
    public void TriangleAreaCalculation()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);
        double expectedArea = 6;

        // Act
        double actualArea = triangle.GetArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [Test]
    public void RightAngledTriangleCheck()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsTrue(isRightAngled);
    }
}