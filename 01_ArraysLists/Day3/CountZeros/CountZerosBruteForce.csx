// Problem: Count Zeros  
// Description: Count how many elements are equal to zero.


using System; 
using System.Collections.Generic;

List<int> numbers = new List<int> { 54, 25, 65, 76, -23, 35, 65, 8, 124, 3, 0, 0, 0, 5 };

int result = CountZeros(numbers);

Console.WriteLine($"The number of elements that are equal to 0 are: {result}");

private int CountZeros(List<int> nums) // [A] [S] [M] [P]
{
    int counter = 0;

    if (nums == null)
    {
        throw new ArgumentNullException(nameof(nums), "List cannot be null");
    }

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] == 0)
        {
            counter++;
        }
    }
    return counter;
}