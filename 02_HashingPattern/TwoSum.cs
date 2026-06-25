// Problem: Two Sum  
// Description: Find two numbers in an array that add up to a target using HashSet.

int [] arr = {1,2,3,4,5,6,7,8,9,10};
int target = 10;

HashSet<int> test = new HashSet<int>();

for (int i = 0; i < arr.Length; i++)
{
    int complement = target - arr[i];

    if (test.Contains(complement))
    {
        Console.WriteLine($"{complement} + {arr[i]} = {target}");
        break;
    }
    test.Add(arr[i]);
}
