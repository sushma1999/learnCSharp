using System;

namespace Chap2;

static class MathUtilities 
{
    // Static field - shared among all instances of the class
    public static double Pi = 3.14159;

    // Static method - can be called without creating an object
    public static double CalculateCircleArea(double radius) 
    {
        return Pi * radius * radius;
    }
}
