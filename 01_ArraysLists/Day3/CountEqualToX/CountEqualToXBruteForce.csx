// Problem: Count Equal to X  
// Description: Count how many elements are exactly equal to a given number X.


List<int> nums = new List<int> { 2, 53, 65, 6, 87, 24, 83, 24, 35, 64, 6546, 32, 24 };
int target = 24;

int result = CountEqualToX(nums, target);

Console.WriteLine($"The number of the elements that are equal to {target} is/are {result}");

int CountEqualToX(List<int> sampleNums, int givenNum)
{
    if (sampleNums == null)
    {
        throw new ArgumentNullException("List cannot be null");
    }

    int counter = 0;

    for (int i = 0; i < sampleNums.Count; i++)
    {
        if (sampleNums[i] == givenNum)
        {
            counter++;
        }
    }
    return counter;
}

