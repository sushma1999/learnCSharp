// See https://aka.ms/new-console-template for more information
Calculator calculator = new Calculator();

// 3. Define some operations as methods
// MathOperation add = (x, y) => x + y;
//MathOperation subtract = (x, y) => x - y;

MathOperation add = addMethod;//Assignment
MathOperation test = testmethod;//Assignment

// Using Normal Method
double addMethod(double x, double y)
{
return x + y;
}


double testmethod(double i, double j)
{
 return i+j*2;
}

//Using anonymous methods
//MathOperation subtract = (x, y) => x - y;

MathOperation subtract = delegate(double x, double y)
{
    return x-y;
};


//Using Lambda Expression
MathOperation multiply = (x, y) => x * y;//Assignment and invoking (inline)

// 4. Use the calculator with different operations
double result1 = calculator.Calculate(5, 3, add);
double result2 = calculator.Calculate(10, 4, subtract);
double result3 = calculator.Calculate(2, 6, multiply);
double result4 = calculator.Calculate(2, 6, test);

Console.WriteLine($"5 + 3 = {result1}");
Console.WriteLine($"10 - 4 = {result2}");
Console.WriteLine($"2 * 6 = {result3}");
Console.WriteLine($"2 + 6 * 2 = {result4}");