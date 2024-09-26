// See https://aka.ms/new-console-template for more information
// Accessing static members directly through the class name
using Chap2;

double area = MathUtilities.CalculateCircleArea(5);
Console.WriteLine("Area of the circle: " + area);

// Accessing static field directly
Console.WriteLine("Value of Pi: " + MathUtilities.Pi);
