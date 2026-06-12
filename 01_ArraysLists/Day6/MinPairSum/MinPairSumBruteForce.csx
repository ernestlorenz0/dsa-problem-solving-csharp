// Problem: Min Pair Sum  
// Description: Find the minimum sum among all pairs.

// input: array
// output: int

public class Solution
{
    public int MinPairSum(int[] nums)
    {
        if (nums is null || nums.Length < 2) throw new ArgumentException("Array cannot be null or atleast have 2 elements");
        
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int current = nums[i] + nums[j];

                if (min > current)
                {
                    min = current;
                }
            }
        }
        return min;
    }
}