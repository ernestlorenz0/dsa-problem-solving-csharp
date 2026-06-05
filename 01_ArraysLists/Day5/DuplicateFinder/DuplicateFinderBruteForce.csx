// Problem: Duplicate Finder  
// Description: Check if the array has any duplicate elements.

public class Solution
{
    public bool DuplicateFinder(int [] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}