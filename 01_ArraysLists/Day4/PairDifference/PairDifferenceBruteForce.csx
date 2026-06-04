// Problem: Pair Difference  
// Description: Find all pairs of numbers whose difference equals a target.


public class Solution {
    public IList<IList<int>> FindPairDifference(int[] nums, int target) {

        IList<IList<int>> result = [];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == target)
                {
                    result.Add([nums[i], nums[j]]);
                }
            }
        }
        
        return result; 
    }
}