using Mathfunctions;

int n = 5;
Console.WriteLine($"Factorial of {n}: {MathFunctions.Factorial(n)}");

int min = 1;
int max = 100;
Console.WriteLine($"Random number between {min} and {max}: {MathFunctions.GenerateRandomNumber(min, max)}");

int a = 12;
int b = 18;
Console.WriteLine($"GCD of {a} and {b}: {MathFunctions.GCD(a, b)}");
