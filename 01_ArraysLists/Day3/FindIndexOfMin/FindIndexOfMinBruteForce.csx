// Problem: Find Index of Min  
// Description: Find the index of the smallest element.

using System;
using System.Collections.Generic;

List<int> sampleNumbers = new List<int> { 124, 54, 76, 34, 12, 56, 76, 87 };

int? output = FindIndexOfMin(sampleNumbers);

if (output.HasValue) Console.WriteLine(output.Value);
else Console.WriteLine("The list is empty");

public static int? FindIndexOfMin(List<int> nums)
{
    
    if (nums == null)
    {
        throw new ArgumentNullException(nameof(nums), "List cannot be null");
    }

    if (nums.Count == 0) return null;

    int minIndex = 0;

    for (int i = 1; i < nums.Count; i++)
    {
        if (nums[minIndex] > nums[i])
        {
            minIndex = i;
        }
    }
    return minIndex;
}