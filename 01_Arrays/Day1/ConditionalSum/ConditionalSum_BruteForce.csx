
// Problem: Conditional Sum
// Description: Compute the sum of all positive numbers in an integer array.
// Approach: Brute Force / Linear Traversal
// Time Complexity: O(N) - Inspect each element exactly once.
// Space Complexity: O(1) - Constant memory, storing only the sum variable.

using System;

int ConditionalSum (int[] arr)
{
    int zero = 0;
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (zero < arr[i])
        {
            sum += arr[i];
        }
    }
    return sum;
}

int [] numbers = {1,2,3,4,-124,5,5};

Console.WriteLine($"Conditional Sum: {ConditionalSum(numbers)}");