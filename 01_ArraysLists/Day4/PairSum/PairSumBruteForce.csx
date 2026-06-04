
using System;
using System.Collections.Generic;

// Problem: Pair Sum  
// Description: Find all pairs of numbers whose sum equals a target.

List<int> numbers = new List<int> { 4, 1, 3, 2, 5, 0, 6, -1 };
int given = 5;

var result = PairSum(numbers, given);

if (result == null || result.Count == 0)
{
    Console.WriteLine("There are no pairs of numbers whose sum equals the target.");
}
else 
{
    foreach (var (firstNum, secondNum) in result)
    {
        Console.WriteLine($"{firstNum} + {secondNum} = {given}");
    }
}

List<(int firstNum, int secondNum)> PairSum(List<int> nums, int givenNum)
{
    if (nums is null) { throw new ArgumentNullException(nameof(nums), "List cannot be null"); }
    if (nums.Count == 0) { throw new ArgumentException("List cannot be empty", nameof(nums)); }

    List<(int firstNum, int secondNum)> foundPairs = [];

    for (int i = 0; i < nums.Count; i++)
    {
        for (int j = i + 1; j < nums.Count; j++)
        {
            if (nums[i] + nums[j] == givenNum)
            {
                foundPairs.Add((nums[i], nums[j]));
            }
        }
    }
    
    return foundPairs;
}