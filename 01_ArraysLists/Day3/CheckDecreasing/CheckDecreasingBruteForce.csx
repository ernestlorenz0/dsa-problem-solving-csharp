// Problem: Check Decreasing  
// Description: Return true if the array is strictly decreasing.

using System;
using System.Collections.Generic;

List<int> sampleNumbers = new List<int> {10,9,8,7,6,5,4,3,2,1,0,-1};

bool result = CheckDecreasing(sampleNumbers);

Console.WriteLine(result);


bool CheckDecreasing(List<int> nums)
{
    if (nums == null || nums.Count == 0)
    {
        throw new ArgumentException("List cannot be null or empty.");    
    }

    for (int i = 0; i < nums.Count-1; i++)
    {
        if (nums[i] <= nums[i + 1])
        {
            return false;
        }
    }

    return true;
}



