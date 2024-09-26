class Calculator
{
    // 2. Method to perform a calculation using a delegate
    public double Calculate(double num1, double num2, MathOperation operation)
    {
        return operation(num1, num2);
    }
}