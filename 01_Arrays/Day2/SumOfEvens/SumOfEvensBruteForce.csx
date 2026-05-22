// Problem: Sum of Evens  
// Description: Compute the sum of all even numbers in the array.

using System;
using System.Collections.Generic;

List<int> sampleNum = new List<int> {2,-4,4,5,6,10,12,13,15,211,-2};

int total = SumOfEvens(sampleNum);

Console.WriteLine(total);

int SumOfEvens(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
    {
        throw new ArgumentException("List cannot be null or 0");
    }

    int accumulator = 0;

    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            accumulator += numbers[i];        
        }
    }
    return accumulator;
}

