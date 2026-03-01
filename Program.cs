// Top-level statements C# program to calculate factorial
// Prompts for positive integer n, computes n! = n × (n-1) × ... × 1
// Applies bounds: too small (<0) → uses 0, too big (>12) → uses 12 (prevents overflow)
// Uses safe TryParse input and long for larger results

Console.Write("Enter a positive (or zero) integer to calculate factorial (recommended: 0-100):");

// Safe input parsing - handles invalid/non-numeric input
if (!uint.TryParse(Console.ReadLine(), out uint n) || n < 0)
{
  Console.WriteLine("Invalid input. Using default value: 0");
  n = 0;
}

if (n > 100)
{
  Console.WriteLine($"Value {n} too big (would overflow). Using default: 20");
  n = 20;
}

Console.WriteLine();  // Blank line for readability

// Calculate factorial using loop
// Initialize result = 1 (0! = 1, and multiplies don't change with ×1)
ulong factorial = 1;
for (uint i = 2; i <= n; i++)
{
  factorial *= i;  // Multiply by each number up to n
}

Console.WriteLine($"{n}! = {factorial}");  // Output result 

// Format with spaces for readability
string factorialstr = factorial.ToString();
int originallength = factorialstr.Length;
for (int i = originallength; i>0; i--)
{ 
  var j = originallength-i;
  if(j%3==2)
    factorialstr = factorialstr.Insert(i-1, " ");  // Insert space every 3 digits from the right
}
Console.WriteLine($"{n}! = {factorialstr}");


factorialstr =factorial.ToString("N0");  // Format with spaces for readability (Hungarian culture)
// Format with spaces for readability
// N0: Number with 0 decimal places
Console.WriteLine($"{n}! = {factorialstr}");
string factstr = factorial.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
// Format with commas for readability
Console.WriteLine($"{n}! = {factstr}");

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();  // Pause before closing
