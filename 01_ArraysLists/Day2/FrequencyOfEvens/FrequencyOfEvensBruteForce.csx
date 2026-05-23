// Problem: Frequency of Evens  
// Description: Count how many even numbers appear in the array.

using System;
using System.Collections.Generic;

List<int> numbers = new List<int> {11,22,33,44,-1,24,-1244,24,222};

int result = FrequencyOfEvens(numbers);

Console.WriteLine(result);


int FrequencyOfEvens(List<int> nums)
{
    if (nums == null || nums.Count == 0)
    {
        throw new ArgumentException("List cannot be null or zero");
    }

    int counter = 0;

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] % 2 == 0)
        {
            counter++;        
        }
    }
    return counter;
}

