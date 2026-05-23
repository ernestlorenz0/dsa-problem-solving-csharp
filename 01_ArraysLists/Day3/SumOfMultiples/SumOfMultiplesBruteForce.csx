using System;
using System.Collections.Generic;

// Execution Layer
List<int> numbers = new List<int> { 10, 3, 5, 20, 7, 30 };
int divisor = 5;

int? result = SumOfMultiples(numbers, divisor);

if (result.HasValue) 
    Console.WriteLine($"Sum of multiples of {divisor}: {result.Value}");
else 
    Console.WriteLine($"No multiples of {divisor} found.");


// Logic Layer
int? SumOfMultiples(List<int> nums, int x)
{
    // S - Specific Exception
    if (nums == null) throw new ArgumentNullException(nameof(nums), "List cannot be null");
    
    if (x == 0) throw new ArgumentException("X cannot be zero", nameof(x));

    int sum = 0;
    bool foundAny = false;

    // T - Trailing Bounds: Full loop
    for (int i = 0; i < nums.Count; i++)
    {
        // P - Pure Logic: Check if multiple
        if (nums[i] % x == 0)
        {
            sum += nums[i];
            foundAny = true;
        }
    }

    // O - Optimal Return: Ternary operator for clean return
    return foundAny ? sum : (int?)null;
}