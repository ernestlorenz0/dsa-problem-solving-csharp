// Problem: Contains Duplicate  
// Description: Check if the array contains any duplicate elements.

int [] arr = {14,2,3,4,5,6,7,81,12,28,1,44,123,14};
bool hasDuplicate = false; // flag variable

HashSet<int> seen = new HashSet<int>(); // hashing pattern(HashSet) 

for (int i = 0; i < arr.Length; i++) // iteration
{
    if (!seen.Add(arr[i]))  // Condition + state update 
    {
        hasDuplicate = true;    // state update
        break;  // early exit
    }
}

Console.WriteLine(hasDuplicate);
