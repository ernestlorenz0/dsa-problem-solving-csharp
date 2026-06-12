public class Solution
{
    public int UniquePairs(int[] nums)
    {
        if (nums is null || nums.Length < 2)
            throw new ArgumentException("Array cannot be null and it must contain at least 2 values.");

        int counter = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                counter++;
            }
        }

        return counter;
    }
}