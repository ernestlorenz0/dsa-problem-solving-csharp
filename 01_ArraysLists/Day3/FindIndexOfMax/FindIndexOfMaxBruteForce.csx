// Problem: Find Index of Max  
// Description: Find the index of the largest element.

using System;
using System.Collections.Generic;

List<int> sampleNumbers = new List<int> { 124, 54, 76, 34, 12, 56, 76, 87 };

int? output = FindIndexOfMax(sampleNumbers);

if (output.HasValue) Console.WriteLine(output.Value);
else Console.WriteLine("The list is empty");

public static int? FindIndexOfMax(List<int> nums)
{
    
    if (nums == null)
    {
        throw new ArgumentNullException(nameof(nums), "List cannot be null");
    }

    if (nums.Count == 0) return null;

    int maxIndex = 0;

    for (int i = 1; i < nums.Count; i++)
    {
        if (nums[maxIndex] < nums[i])
        {
            maxIndex = i;
        }
    }
    return maxIndex;
}