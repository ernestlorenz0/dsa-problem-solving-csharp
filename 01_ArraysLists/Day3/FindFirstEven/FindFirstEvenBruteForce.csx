// Problem: Find First Even
// Description: Find the first even number in the list.


using System; 
using System.Collections.Generic;

List<int> numbers = new List<int> { 53, 25, 65, 73, -23, 3, 65, 83, 1245, 3, 5 };

int? result = FindFirstEven(numbers);

if (result.HasValue)
{
    Console.WriteLine($"The first even number in the list is: {result.Value}");
}
else Console.WriteLine("There has no even number in the list");


private static int? FindFirstEven(List<int> nums)
{
    if (nums == null || nums.Count == 0)
    {
        throw new ArgumentNullException(nameof(nums), "List cannot be null");
    }

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] % 2 == 0)
        {
            return nums[i];
        }
    }

    return null;
}