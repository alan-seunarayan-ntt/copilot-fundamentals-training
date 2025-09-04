
using System;

/// <summary>
/// Provides basic calculator operations for double values.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    public static double Add(double a, double b) => a + b;

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public static double Subtract(double a, double b) => a - b;

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public static double Multiply(double a, double b) => a * b;

    /// <summary>
    /// Divides the first number by the second. Throws DivideByZeroException if b is zero.
    /// </summary>
    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}
