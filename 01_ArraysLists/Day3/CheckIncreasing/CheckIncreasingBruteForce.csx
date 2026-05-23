// Problem: Check Increasing  
// Description: Return true if the array is strictly increasing.

using System;
using System.Collections.Generic;

List<int> sampleNumbers = new List<int> {-1, 0, 42, 45, 62, 68, 76, 98, 100, 532};

bool result = CheckIncreasing(sampleNumbers);

Console.WriteLine(result);


bool CheckIncreasing(List<int> nums)
{
    if (nums == null || nums.Count == 0)
    {
        throw new ArgumentException("List cannot be null or empty.");    
    }

    for (int i = 1; i < nums.Count; i++)
    {
        if (nums[i - 1] >= nums[i])
        {
            return false;
        }
    }

    return true;
}



