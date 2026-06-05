

public class Solution
{
    public int MaxPairSum(int[] nums)
    {
        if (nums is null || nums.Length < 2) return 0;

        int maxPair = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int current = nums[i] + nums[j];

                if (current > maxPair)
                {
                    maxPair = current;
                }
            }
        }
        return maxPair;
    }
}