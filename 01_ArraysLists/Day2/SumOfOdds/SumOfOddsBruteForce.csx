// Problem: Sum of Odds  
// Description: Compute the sum of all odd numbers in the array.

using System;
using System.Collections.Generic;

List<int> sampleNum = new List<int> {1,2,3,4,5,6,7,8,9,10,5,1,-124,-12,-12};

int total = SumOfOdds(sampleNum);

Console.WriteLine(total);

int SumOfOdds(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
    {
        throw new ArgumentException("List cannot be null or 0");
    }

    int accumulator = 0;

    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            accumulator += numbers[i];        
        }
    }
    return accumulator;
}

