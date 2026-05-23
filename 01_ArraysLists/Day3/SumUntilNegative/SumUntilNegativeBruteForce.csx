// Problem: Sum Until Negative  
// Description: Compute the sum of elements until you encounter the first negative number.


// input: list
// output: number(int/float)
// edge cases: empty list, no positive number, negative number right after the first element

using System;
using System.Collections.Generic;


// Execution Layer
List<int> numbers = new List<int> { 543, 54, 654, -234, 12 };

int? result = SumUntilNegative(numbers);


if (result == null)
{
    Console.WriteLine("No positive number in the List");
}
else Console.WriteLine(result);


// Logic Layer
int? SumUntilNegative(List<int> nums)
{
    if (nums == null) throw new ArgumentNullException(nameof(nums), "List cannot be null");
    
    if (nums.Count == 0) return null;

    int sum = 0;
    bool foundPositive = false; 
    

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] < 0)
        {
            break; 
        }

        sum += nums[i];
        foundPositive = true;
    }

    return foundPositive ? sum : null;
}