// Problem: Two Sum  
// Description: Find two numbers in an array that add up to a target using HashSet.

int [] arr = {1,2,3,4,5,6,7,8,9,10};
int target = 10;

var test = new HashSet<int>(); // accumulator

for (int i = 0; i < arr.Length; i++) // iteration
{
    int complement = target - arr[i];

    if (test.Contains(complement)) // condition (checker)
    {
        Console.WriteLine($"{complement} + {arr[i]} = {target}");
        break;
    }
    test.Add(arr[i]); // state update
}
